using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The current time and date is: " + now);
            Console.WriteLine("Please enter a whole number.");
            int hours = Convert.ToInt32(Console.ReadLine());
            TimeSpan toAdd = new TimeSpan(hours, 0, 0);
            DateTime future = now.Add(toAdd);
            Console.WriteLine("In " + hours + " hours it will be " + future + ".");
            Console.ReadLine();
        }
    }
}
