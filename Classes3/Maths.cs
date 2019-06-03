using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Maths
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Addition(int num1, out int num3, int num2 = 5)
        {
            num3 = num2;
            return num1 + num2;
        }
    }
}
