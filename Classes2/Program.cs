using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            math.Fxn(5, 10);
            math.Fxn(num1: 8, num2: 20);
        }
    }
}
