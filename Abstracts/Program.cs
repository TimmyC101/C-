using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.SayName();
            IQuittable person2 = new Employee();
            person2.Quit();
        }
    }
}
