using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Tim\Documents\Github\C#\FileIO\log.txt", num);
            string read = File.ReadAllText(@"C:\Users\Tim\Documents\Github\C#\FileIO\log.txt");
            Console.WriteLine("The number " + read + " has been logged and read back to the user.");
            Console.ReadLine();
        }
    }
}
