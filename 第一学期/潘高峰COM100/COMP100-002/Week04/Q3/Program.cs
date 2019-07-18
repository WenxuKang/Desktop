using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  * Question 3a -> 6 marks
  * Solution   -> Question3a.exe
  * 
  * Name: Narendra Pershad
  * Date: 
  * 
  * Purpose: Write a program that prompts the user for the cost of 
  *          a purchase. If the cost is more than $100.00, a discount of 10% 
  *          is applied to the cost. The program will display the amount that the customer
  *          pays.
  * 
  * selling price = cost price - discount(if any)
 */

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much is your cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            double pay;
            double discount = 0.1;              
            if (cost > 100)
            {
                pay = cost * (1-discount);
            }
            else
            {
                pay = cost;
            }
            Console.WriteLine("You need to pay {0:c}",pay);
        }
    }
}
