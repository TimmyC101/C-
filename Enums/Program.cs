using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = false;
            while (!test)
            {
                try
                {
                    Console.WriteLine("Please enter the current day of the week.");
                    string dayString = Console.ReadLine();
                    Days day = (Days)Enum.Parse(typeof(Days), dayString, true);
                    Console.WriteLine(day);
                    test = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid day of the week.  This shouldn't be hard...");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("");
            Console.WriteLine("I always believed in you");
            Console.ReadLine();
        }
        public enum Days { Monday, Tuesday, Wednesday, Thrusday, Friday, Saturday, Sunday }
    }
}
