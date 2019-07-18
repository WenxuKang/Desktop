using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	Write a program that prompts the user for a day of the week. 
 * The program will display a message based on the following table:
Choice	Message
Sun	"Home"
Mon	"Work"
Tue	"Work"
Wed	"Home"
Thu	"Work"
Fri	"Work"
Sat	"Work"
 */

namespace Q4_weekPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a day of the week: ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    Console.WriteLine("Work");
                    break;
                case "Sunday":
                case "Wednesday":
                    Console.WriteLine("Home");
                    break;

            }

        }
    }
}
