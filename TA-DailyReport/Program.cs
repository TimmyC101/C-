using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine(" ");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number of " + course + " are you on?");
            string pageStr = Console.ReadLine();
            byte page = Convert.ToByte(pageStr);
            Console.WriteLine("Do you need help with anything? Answer \"true or \"false.");
            string helpStr = Console.ReadLine();
            bool help = Convert.ToBoolean(helpStr);
            Console.WriteLine("Were there any positive experiences you would like to share?");
            string expStr = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide?");
            string feedbackStr = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStr = Console.ReadLine();
            byte hours = Convert.ToByte(hoursStr);
            Console.WriteLine("Thank you for your answers.  An instructor will respond shortly.  Have a great day.");
            Console.WriteLine(" ");
            Console.WriteLine("Summary...");
            Console.WriteLine("Current course: " + course);
            Console.WriteLine("Current page: " + page);
            Console.WriteLine("Needs help? " + help);
            Console.WriteLine("Positive Experiences: " + expStr);
            Console.WriteLine("Feedback: " + feedbackStr);
            Console.WriteLine("Hours studied: " + hours);
            Console.Read();



        }
    }
}
