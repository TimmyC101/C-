using System;
using Casino;
using Casino.Blackjack;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Please tell me your name.");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool valid = false;
            int bank = 0;
            while (!valid)
            {
                Console.WriteLine("What is your buy-in?");
                valid = int.TryParse(Console.ReadLine(), out bank);
                if (!valid)
                {
                    Console.WriteLine("Please enter a whole number using digits only.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Blackjack table changing $" + bank + "!!!!");
            Console.WriteLine("Hello, {0}.  Shall we begin?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yep" || answer == "sure" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackjackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred, please contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }
            Console.WriteLine("Feel free to look around the casino.  Goodbye for now.");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackjackGame;Integrated Security=True;
                                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackjackGame;Integrated Security=True;
                                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }

    }
}
