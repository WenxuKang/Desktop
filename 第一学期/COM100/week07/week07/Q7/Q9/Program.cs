using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.	Write a C program that continuously requests a grade to be entered. If the grade is less than 
 * 0 or greater than 100, your program should print an appropriate message 
 * informing the user that an invalid grade has been entered, else the grade should be added to a total.
 * When a grade of 999 is entered the program should exit the repetition loop and compute and display the average of the valid grades entered.
*/
namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            double inPut = 0;
            double Total = 0;
            double Average = 0;
            int Counter = 0;
            while (true)
            {
                Console.Write("Please enter a grade: ");
                inPut = Convert.ToDouble(Console.ReadLine());
                if (inPut == 999)
                    break;
                if (inPut < 0 || inPut > 100)
                {
                    Console.Write("This is an invalid grade.");
                }
                else
                {
                    Total = Total + inPut;
                    Counter++;
                }
            }
            Average = Total / Counter;
            Console.Write($"The average of input is:{Average}");

        }
    }
}
