using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	Write a program that prompts the user for a day of the week. The program will display a message based on the following table:
Choice	Message
Sun	"Home"
Mon	"Work"
Tue	"Work"
Wed	"Home"
Thu	"Work"
Fri	"Work"
Sat	"Work"

 *
 */
namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter today is: ");
            string day = Console.ReadLine();

            switch(day)
                {
                case "Sun":
                case "Wed":
                    Console.WriteLine("Home");
                    break;
                case "Mon":
                case "Tue":
                case "Thu":
                case "Fri":
                case "Sat":
                    Console.WriteLine("Work");
                    break;


            }
        }
    }
}
