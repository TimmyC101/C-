using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Multiply user input by 50");
            string multiStr = Console.ReadLine();
            int multi = Convert.ToInt32(multiStr);
            int product = 50 * multi;
            Console.WriteLine("50 times " + multi + " is " + product);
            Console.WriteLine("Add 25 to user input");
            string addStr = Console.ReadLine();
            int add = Convert.ToInt32(addStr);
            int sum = 25 + add;
            Console.WriteLine("25 plus " + add + " is " + sum);
            Console.WriteLine("Divide user input by 12.5");
            string divStr = Console.ReadLine();
            double div = Convert.ToDouble(divStr);
            double quotient = div / 12.5;
            Console.WriteLine(div + " divided by 12.5 is " + quotient);
            Console.WriteLine("Is user input greater than 50?");
            string greaterStr = Console.ReadLine();
            int greater = Convert.ToInt32(greaterStr);
            Boolean greaterThan = greater > 50;
            Console.WriteLine("Is " + greater + " greater than 50?");
            Console.WriteLine(greaterThan);
            Console.WriteLine("Remainder of user input divided by 7");
            string remainStr = Console.ReadLine();
            int remain = Convert.ToInt32(remainStr);
            int remainder = remain % 7;
            Console.WriteLine("The remainder of " + remain + " divided by 7 is " + remainder);
            Console.Read();
        }
    }
}
