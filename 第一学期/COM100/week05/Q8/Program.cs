using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.Same as the previous question but additionally
 * displays the average of the numbers at the end of the loop.
 * You will need a counter but not as a loop terminator.
 *
 */
namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            do
            {
                Console.Write("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                sum = sum + num;
                count++ ;

            } while (sum <= 100);

            Console.WriteLine(sum);
            Console.WriteLine(sum / count);
        }
    }
}
