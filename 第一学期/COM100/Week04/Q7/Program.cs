using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	The average cost of a college textbook is $125.
 * There is a premium of 20% on hardcover text and a discount of 
 * 5% on sales of more than 4 textbooks. 
 * Write a program to prompt the user for the appropriate
 * inputs and compute and display the before-tax cost of the textbooks.
 *Sample calculation: price of 10 hardcover text = 10 * 125 + premium –discount
 *price = 1250 + 20% of 1250 – 5% of 1250
 *price = $1437.50
 *price of 8 softcover text = 8 * 125 –discount
 *
 */
namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the total number of hardcover textbook you need:");
            int hardcover = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter the total number of textbook you need：");
            int totaltextbook = Convert.ToInt32(Console.ReadLine());

            double cost = 125 * totaltextbook;
            double premium = 0.2 * hardcover * 125;

            if (totaltextbook>4)
            {
                Console.WriteLine("your before-tax cost of textbook would be:{0:c}",cost + premium - 0.05 * cost);

            }
            else
            {
                Console.WriteLine("your before-tax cost of textbooks would be{0:c}",cost + premium);
            }
        }
    }
}
