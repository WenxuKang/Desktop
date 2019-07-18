using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	If money is left in a particular bank for more than 5 years, 
 * the interest rate given by the bank is 7.5%, else the interest rate is 5.4%.
 *  Write a program that prompt the user for the number of years 
 *  that the money was left in the bank and display the appropriate 
 *  interest rate depending on the value input. How many runs should 
 *  you make to very that it works correctly?
 */
namespace Q3_moneyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double year;
            Console.Write("Enter how many years do you want to put your money in bank: ");
            year = Convert.ToDouble(Console.ReadLine());
            if (year >= 5)
            {
                Console.WriteLine("The rate is 7.5%.");
            }
            else
                if (year >= 0)
            {
                Console.WriteLine("The rate is 5.4%");
            }
            else
            { Console.WriteLine("Years can't be negative.");
            }
        }
    }
}
