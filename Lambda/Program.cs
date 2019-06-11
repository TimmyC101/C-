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

            List<Employee> joes = new List<Employee>();
            // use foreach loop to create list of Joes
            foreach (Employee person in employees)
            {
                if (person.first == "Joe")
                {
                    joes.Add(person);
                }
            }
            Console.WriteLine("List of Joes using foreach loop:");
            foreach (Employee joe in joes)
            {
                Console.WriteLine("First Name: " + joe.first + " || Last Name: " + joe.last + " || ID: " + joe.Id);
            }
            Console.WriteLine(" ");

            // use lambda function to create list of Joes
            Console.WriteLine("List of Joes using lambda function:");
            List<Employee> joes2 = employees.Where(x => x.first == "Joe").ToList();
            foreach (Employee joe in joes2)
            {
                Console.WriteLine("First Name: " + joe.first + " || Last Name: " + joe.last + " || ID: " + joe.Id);
            }
            Console.WriteLine(" ");

            // use lambda function to create list of employees with id greater than 5
            Console.WriteLine("List of employees with ID > 5, using lambda function:");
            List<Employee> idGreater5 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee item in idGreater5)
            {
                Console.WriteLine("First Name: " + item.first + " || Last Name: " + item.last + " || ID: " + item.Id);
            }

            Console.ReadLine();
        }
    }
}
