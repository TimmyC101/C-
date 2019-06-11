using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 50.60m;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
