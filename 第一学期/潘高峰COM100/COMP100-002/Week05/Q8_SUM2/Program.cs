using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Same as the previous question but additionally displays the average 
 * of the numbers at the end of the loop. 
 * You will need a counter but not as a loop terminator.
 */
namespace Q8_SUM2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            int counter = 0;
            do
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
                counter++;
            }
            while (sum <= 100);
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + sum / counter);
        }
    }
}
