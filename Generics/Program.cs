using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> str = new Employee<string>();
            str.Things = new List<string>() { "Tim", "Calhoun", "Owns" };
            Employee<int> nums = new Employee<int>();
            nums.Things = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (string item in str.Things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in nums.Things)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
