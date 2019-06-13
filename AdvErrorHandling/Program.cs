using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Globals.Boo = false;
            while (!Globals.Boo)
            {
                try
                {
                    YearBorn();
                }
                catch (NegativeError)
                {
                    Console.WriteLine("Please don't enter negative numbers.");
                    Console.ReadLine();
                }
                catch (ZeroError)
                {
                    Console.WriteLine("Please enter a whole number greater than 0 with no decimals.");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Bad things happened.");
                    Console.ReadLine();
                }
            }
        }

        static void YearBorn()
        {
            bool valid = false;
            int age = 0;
            while (!valid)
            {
                Console.WriteLine("Please enter your age.");
                valid = int.TryParse(Console.ReadLine(), out age);
                if (age < 0)
                {
                    throw new NegativeError();
                }
                if (age == 0)
                {
                    throw new ZeroError();
                }
                if (!valid)
                {
                    throw new Exception();
                }
            }
            Globals.Boo = true;
            DateTime yearBorn = DateTime.Now.AddYears(-age);
            Console.WriteLine("You were born in " + yearBorn.ToString("yyyy") + ".");
            Console.ReadLine();
        }

        public class NegativeError : Exception
        {
            public NegativeError()
                : base() { }
        }

        public class ZeroError : Exception
        {
            public ZeroError()
                : base() { }
        }

        public static class Globals
        {
            public static bool Boo;
        }
    }
}
