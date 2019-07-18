using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	The average cost of a college textbook is $125. 
 * There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. 
 * Write a program to prompt the user for the appropriate inputs and compute 
 * and display the before-tax cost of the textbooks.
Sample calculation: 
price of 10 hardcover text = 10 * 125 + premium –discount
price = 1250 + 20% of 1250 – 5% of 1250
price = $1437.50

price of 8 softcover text = 8 * 125 –discount
price = 1000  – 5% of 1000
price = $950

price of 2 softcover text = 2 * 125
price = $250

 */

namespace Q7_cost_of_textbooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int hardAmount;
            int softAmount;
            int totalAmount;
            double discountPrice;
            double premiumPrice;
            double finalPrice;
            
            Console.Write("Enter how many hardcover textbooks you want to buy: ");
            hardAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter how many softcover textbooks you want to buy: ");
            softAmount = Convert.ToInt32(Console.ReadLine());
            totalAmount = softAmount + hardAmount;
            if (totalAmount > 4)
            {
                discountPrice = 125 * totalAmount * 0.95;
            }
            else
            {
                discountPrice = 125 * totalAmount;
            }                
            premiumPrice = 0.2 * 125 * hardAmount;
            finalPrice = premiumPrice + discountPrice;
            Console.WriteLine("The before - tax cost of the textbooks is $" + finalPrice);
        }
    }
}
