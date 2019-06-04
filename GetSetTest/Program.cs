using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            getset test = new getset();
            Console.WriteLine(test.Name);
            Console.ReadLine();
            test.Name = "Alex";
            Console.WriteLine(test.Name);
            Console.ReadLine();
        }
    }
}
