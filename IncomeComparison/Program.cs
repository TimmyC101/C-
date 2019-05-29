using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Enter Hourly Rate:");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours worked per week:");
            int hours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Person 2:");
            Console.WriteLine("Enter Hourly Rate:");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours worked per week:");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            int sal1 = rate1 * hours1 * 52;
            int sal2 = rate2 * hours2 * 52;
            Console.WriteLine("The annual salary of person 1 is:");
            Console.WriteLine(sal1);
            Console.WriteLine("The annual salary of person 2 is:");
            Console.WriteLine(sal2);
            Console.WriteLine("Does person 1 make more money than person 2?");
            Boolean test = sal1 > sal2;
            Console.WriteLine(test);
            Console.ReadLine();

        }
    }
}
