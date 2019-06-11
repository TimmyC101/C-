using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { first = "Tim", last = "Calhoun", Id = 1 });
            employees.Add(new Employee { first = "Andy", last = "Calhoun", Id = 2 });
            employees.Add(new Employee { first = "Matt", last = "Marquez", Id = 3 });
            employees.Add(new Employee { first = "Joe", last = "Rosenberg", Id = 4 });
            employees.Add(new Employee { first = "Garyt", last = "Walker", Id = 5 });
            employees.Add(new Employee { first = "Callen", last = "McLaughlin", Id = 6 });
            employees.Add(new Employee { first = "Ryan", last = "Chabala", Id = 7 });
            employees.Add(new Employee { first = "Lauren", last = "Gronberg", Id = 8 });
            employees.Add(new Employee { first = "Laura", last = "Styles", Id = 9 });
            employees.Add(new Employee { first = "Joe", last = "Zeusowitz", Id = 10 });

            int count1 = 0;
            foreach (Employee person in employees)
            {
                if (person.first == "Joe")
                {
                    count1++;
                }
            }
            Console.WriteLine("Number of Joes using foreach loop: " + count1);

            int count2 = employees.Count(x => x.first == "Joe");
            Console.WriteLine("Number of Joes using lambda fxn: " + count2);

            int count3 = employees.Count(x => x.Id > 5);
            Console.WriteLine("Number of employee ID's greater than 5 using lambda fxn: " + count3);

            Console.ReadLine();
        }
    }
}
