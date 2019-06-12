using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Tim Calhoun";
            Console.WriteLine("My constant name is " + name + ".");
            Console.ReadLine();
            var list = new List<string> { "Tim", "Calhoun", "is", "dope", "." };
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.ReadLine();
            WoW char1 = new WoW("Gnome");
            WoW char2 = new WoW("Orc", "Warlock");
            Console.WriteLine("Character 1 is a(n) " + char1.Race + " " + char1.Clas + ".");
            Console.WriteLine("Character 2 is a(n) " + char2.Race + " " + char2.Clas + ".");
            Console.ReadLine();

        }
    }
}
