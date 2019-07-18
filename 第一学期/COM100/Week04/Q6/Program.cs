using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.	Write a console-based program that prompts 
 * the user for an hourly pay rate and hours worked.
 * Compute gross pay (hours times pay rate), withholding tax, 
 * and net pay (gross pay minus withholding tax).
 * Withholding tax is computed as a percentage of gross pay based on the following:
 * Gross Pay	Withholding Percentage
 * Up to and including 300.00	10%
 * More than300.00	12%
 *
 */
namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your hourly pay rate:");
            double hourlypayrate = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter your hours worked:");
            double hourworked = Convert.ToDouble(Console.ReadLine());

            double grosspay = hourlypayrate * hourworked;

            Console.WriteLine("your gross pay is:{0:c}",grosspay);
            if (grosspay>300)
            {
                Console.WriteLine("your withholding tax amount is:{0:c}",grosspay * 0.12);
                Console.WriteLine("your net pay is :{0:c}", grosspay - grosspay * 0.12);
            }
            else
            {
                Console.WriteLine("your withholding tax is:{0:c} ",grosspay * 0.10);
                Console.WriteLine("your net pay is：{0:c} ", grosspay - grosspay * 0.10);
            }



            }
        }
    }

