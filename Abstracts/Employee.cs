using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName + ".");
            base.SayName();
        }
    }
}
