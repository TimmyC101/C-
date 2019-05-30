using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "String 1", "String 2", "String 3", "String 4", "String 5" };
            Console.WriteLine("Type string value to add to existing string array");
            string addString = Console.ReadLine();
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i] + addString;
            }
            foreach (string item in strArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine("Tim is the most awesomest");
                k++; //This line was added to stop infinite loop
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            List<string> wowRaces = new List<string> { "Orc", "Tauren", "Troll", "Undead", "Night Elf", "Human", "Dwarf", "Gnome" };
            Console.WriteLine("Please enter a classic WoW race. (Capitalized please... Let's show some respect.)");
            string search = Console.ReadLine();
            Boolean stringSearch = false;
            for (int i = 0; i < wowRaces.Count; i++)
                if (wowRaces[i] == search)
                {
                    Console.WriteLine("The search text entered is contained in the list index of " + i);
                    stringSearch = true;
                    break;
                }
            if (!stringSearch)
            {
                Console.WriteLine("There are no classic races containing the string " + search + ".  Do you even game, bro?");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            List<string> names = new List<string> { "Tim", "Calhoun", "Matt", "Marquez", "Andy", "Calhoun", "Andy", "Marquez" };
            List<int> matching = new List<int>();
            Console.WriteLine("Please enter a first or last name to search for:");
            string search2 = Console.ReadLine();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == search2)
                {
                    matching.Add(i);
                }
            }
            if (matching.Count > 0)
            {
                Console.WriteLine("The following list indeces contain the value of " + search2);
                foreach (int i in matching)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("There are no first or last names containig the string " + search2);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();
            List<string> moreNames = new List<string> { "Tim", "Calhoun", "Matt", "Marquez", "Andy", "Calhoun", "Andy", "Marquez", "Garyt", "Walker", "Tim", "Walker" };
            List<string> check = new List<string>();
            foreach (string item in moreNames)
            {
                if (check.Contains(item))
                {
                    Console.WriteLine(item + " has already occurred in the list at index " + moreNames.IndexOf(item));
                }
                else
                {
                    check.Add(item);
                }
            }

            Console.ReadLine();
        }
    }
}
