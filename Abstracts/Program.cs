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
            Employee person2 = new Employee();
            person2.firstName = "Sample";
            person2.lastName = "Student";
            person2.SayName();
            Employee person3 = new Employee();
            person3.firstName = "Tim";
            person3.lastName = "Calhoun";
            person3.SayName();
        }
    }
}
