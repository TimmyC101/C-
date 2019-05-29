using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Tim", "Calhoun", "Willie", "Marquez", "Andy", "Calhoun" };
            Console.WriteLine("Select index of string array to be returned");
            int strIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strArray[strIndex]);
            int[] primeArray = { 1, 2, 3, 5, 7, 11, 13, 17, 19 };
            Console.WriteLine("Select the Xth prime number to be returned (less than 10)");
            int intIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (intIndex >= 9)
            {
                Console.WriteLine("That index does not exist");
            }
            else
            {
                Console.WriteLine(primeArray[intIndex]);
            }
            List<string> strList = new List<string> { "Link", "Zelda", "Ganon", "Epona", "Bombchu", "Deku Tree" };
            Console.WriteLine("Select index of list to be returned");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strList[listIndex]);
            Console.Read();
        }
    }
}
