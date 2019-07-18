using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.Write a program that prompts the user for the number of courses and residency status 
 * (domestic or international) and calculates tuition cost. Cost is calculated based on the table below.
 *Domestic	$325 per course
 *International	$1375 per course
 *You decide how you want the user to enter her/his residency status and prompt accordingly, also you should use named constants for the cost per course
 */
namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many course you have: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your residecy status:D/I: ");
            string status = Console.ReadLine();
            int domesticpercourse = 325 * number;
            int internationalpercourse = 1375 * number;
            switch(status)
            {
                case "D":
                    Console.WriteLine($"your tuition fee is {domesticpercourse:c}");
                    break;
                case "I":
                    Console.WriteLine($"your tuition fee is {internationalpercourse:c}");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
                
            }
        }
    }
}
