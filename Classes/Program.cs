using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            Console.WriteLine("Please enter two numbers on which to perform teh Maths.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = math.Addition(num1, num2);
            int subtract = math.Subtraction(num1, num2);
            int multi = math.Multiplication(num1, num2);
            Console.WriteLine("");
            Console.WriteLine(num1 + " + " + num2 + " = " + add);
            Console.WriteLine(num1 + " - " + num2 + " = " + subtract);
            Console.WriteLine(num1 + " x " + num2 + " = " + multi);
            Console.ReadLine();
        }
    }
}
