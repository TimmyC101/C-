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
            Console.WriteLine("What is your buy-in?");
            int bank = Convert.ToInt32(Console.ReadLine());
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
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }
            Console.WriteLine("Feel free to look around the casino.  Goodbye for now.");

            Console.ReadLine();
        }

    }
}
