using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName + ".");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Press any key to exit the program");
            Console.ReadLine();
        }

        public static Employee operator ==(Employee employee)
        {

        }
    }
}
