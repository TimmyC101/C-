using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int result;
            math.Divide(num, out result);
            DisplayResult();
            int divideBy = 4;
            math.Divide(num, out result, divideBy);
            Console.WriteLine(num + " / " + divideBy + " = " + result);

            int a = 0;
            int b = 0;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Execute function with output parameters");
            Console.ReadLine();
            getValue(out a, out b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();

            Console.WriteLine("My name is " + statics.firstName + " " + statics.middleName + " " + statics.lastName);
            Console.ReadLine();

            void DisplayResult()
            {
                Console.WriteLine(num + " / 2 = " + result);
                Console.ReadLine();
            }

            void getValue(out int x, out int y)
            {
                x = 5;
                y = 10;
            }

        }
    }
}
