using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean lokiFed = false;
            Boolean lokiExercised = false;
            Boolean lokiScratched = false;
            Boolean lokiHappy = lokiFed && lokiExercised && lokiScratched;
            while (!lokiHappy)
            {
                if (!lokiFed)
                {
                    lokiFed = true;
                    Console.WriteLine("Loki has been fed.");
                }
                if (!lokiExercised)
                {
                    lokiExercised = true;
                    Console.WriteLine("Loki has been exercised.");
                }
                if (!lokiScratched)
                {
                    lokiScratched = true;
                    Console.WriteLine("Loki's belly has been rubbed.");
                }
                lokiHappy = lokiFed && lokiExercised && lokiScratched;
                Console.WriteLine("This code is really pointless.  Oh well.");
            }
            Console.WriteLine("");
            Console.WriteLine("Now let's play a guessing game.  Guess a number between 1 and 100");
            Random rnd = new Random();
            int random = rnd.Next(1, 101);
            Boolean guess = false;
            do
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == random)
                {
                    Console.WriteLine(number + " is equal to " + random + ".  Good guess!");
                    guess = true;
                }
                else if (number > random)
                {
                    Console.WriteLine("Too high!  Try a lower number.");
                }
                else if (number < random)
                {
                    Console.WriteLine("Too low!  Try a higher number.");
                }
            }
            while (!guess);
            Console.ReadLine();
        }
    }
}
