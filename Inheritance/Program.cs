using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            person1.SayName();
            Employee person2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            person2.SayName();
            Employee person3 = new Employee() { FirstName = "Tim", LastName = "Calhoun", Id = 2 };
            person3.SayName();
            bool test1 = person1 == person2;
            Console.WriteLine(test1);
            bool test2 = person1 == person3;
            Console.WriteLine(test2);
            bool test3 = person2 == person3;
            Console.WriteLine(test3);
            Console.ReadLine();
        }
    }
}
