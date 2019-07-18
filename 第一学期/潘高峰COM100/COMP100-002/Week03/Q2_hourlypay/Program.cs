using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Write a console-based program that prompts a user for an hourly pay rate. 
 * If the value entered is less than $14.00 or greater than $49.99, display an error message; 
 * otherwise, display a message indicating that the rate is okay.
 */
namespace Q2_hourlypay
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;
            Console.Write("Enter your hourly pay rate: ");
            payRate = Convert.ToDouble(Console.ReadLine());
            if (payRate >=14)
            {if (payRate <= 49.99)
                {
                    Console.WriteLine("The rate is okay.");
                }
                else
                {
                    Console.WriteLine("Error: Rate is too hige.");
                 }
        
            }
            else
                {
                Console.WriteLine("ERROR: Rate is below logal value.");
                 }
        }
    }
}
