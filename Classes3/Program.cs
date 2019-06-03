using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            Console.WriteLine("Please enter one or two numbers.  You may leave the second number blank.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string str2 = Console.ReadLine();
            if (!string.IsNullOrEmpty(str2))
            {
                int num2 = Convert.ToInt32(str2);
                int sum = math.Addition(num1, num2);
                Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            }
            else
            {
                int sum = math.Addition(num1, out int num3);
                Console.WriteLine(num1 + " + " + num3 + " = " + sum);
            }
            Console.ReadLine();
        }
    }
}
