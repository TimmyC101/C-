using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name, then your middle name, then your last name");
            string first = Console.ReadLine();
            string middle = Console.ReadLine();
            string last = Console.ReadLine();
            Console.WriteLine("Your full name is " + first + " " + middle + " " + last + ".");
            string firstUp = first.ToUpper();
            Console.WriteLine(firstUp);
            StringBuilder paragraph = new StringBuilder();
            int i = 1;
            Console.WriteLine("Construct a 20 word paragraph...");
            while (i <= 20) 
            {
                paragraph.Append(Console.ReadLine() + " ");
                i = i + 1;
            }
            paragraph.Append(".");
            Console.WriteLine(paragraph);
            Console.Read();
        }
    }
}
