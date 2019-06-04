using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes4
{
    class Maths
    {
        public void Divide(int num1, out int num2)
        {
            num2 =  num1 / 2;
        }
        public void Divide(int num1, out int num2, int divideBy = 2)
        {
            num2 = num1 / divideBy;
        }
    }
}
