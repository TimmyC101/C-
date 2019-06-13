using System;
using Casino;
using Casino.Blackjack;
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
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Throw this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred, please contact your system administrator.");
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

    }
}
