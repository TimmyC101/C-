using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean boo = false;
            while (!boo)
            {
                try
                {
                    List<int> intList = new List<int> { 5, 10, 12, 20, 50, 1000 };
                    Console.WriteLine("Enter an integer by which we can divide the existing list.");
                    int div = Convert.ToInt32(Console.ReadLine());
                    foreach (int item in intList)
                    {
                        int quotient = item / div;
                        Console.WriteLine(item + " divided by " + div + " equals " + quotient);
                        boo = true;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please do not divide by 0.  What is this, amateur hour?");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please enter an actual whole number with no decimals.  Like 1, 4, 100, etc.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Well Done! Program Executed Successfully.");
            Console.ReadLine();
        }
    }
}
