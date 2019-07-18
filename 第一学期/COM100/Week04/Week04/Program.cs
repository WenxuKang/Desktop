using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	If money is left in a particular bank for more than 5 years, 
    *the interest rate given by the bank is 7.5%, else the interest rate is 5.4%.
    *Write a program that prompt the user for the number of years that the money was
    *left in the bank and display the appropriate interest
    *rate depending on the value input.
    *How many runs should you make to very that it works correctly?
    */
namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the left years:");
            double years = Convert.ToDouble(Console.ReadLine());
            if (years <= 5)
                Console.WriteLine("you can get 5.4% from bank");
            else
                Console.WriteLine("you can get 7.5% from bank");
        }
    }
}
