using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package in pounds");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a Good Day.  Press any button to exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Enter Package width in inches.");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Package height in inches.");
            double height = Convert.ToDouble(Console.ReadLine());
            if (width + height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.  Have a Good Day.  Press any button to exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double quote = (width + height) * weight / 100;
            string quoteStr = quote.ToString("0.00");
            Console.WriteLine("The total cost of your package is $" + quoteStr);
            Console.ReadLine();
        }
    }
}
