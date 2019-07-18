using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Write a console-based program that prompts the user for an hourly pay rate. 
 * If the value entered is less than $14.00, display an error message
 */

namespace Q1_PayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double payment;
            Console.Write("Enter your hourly rate: ");
            payment = Convert.ToDouble(Console.ReadLine());
            if (payment < 14)
                {
                Console.WriteLine("ERROR: Rate is below logal value.");
                 }
        }
    }
}
