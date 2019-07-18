using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.	Write a console-based program that prompts the user for an hourly pay rate and hours worked. 
 * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax). 
 * Withholding tax is computed as a percentage of gross pay based on the following:
Gross Pay	Withholding Percentage
Up to and including 300.00	10%
More than300.00	12%

 */

namespace Q6_hourly_pay_rate_and_hours_worked
{
    class Program
    {
        static void Main(string[] args)
        {
            double workHour;
            double hourlyPay;
            double grossPay;
            double netPay;
            Console.Write("Enter your work hours: ");
            workHour = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your hourly pay: ");
            hourlyPay = Convert.ToDouble(Console.ReadLine());
            grossPay = workHour * hourlyPay;
            if (grossPay <= 300)
            {
                netPay = grossPay * 0.9;
                Console.WriteLine("Your gross pay is {0:C}, netPay is {1:C}", grossPay, netPay);
            }
            else
            {
                netPay = grossPay - 30 - (grossPay - 300) * 0.12;
                Console.WriteLine("Your gross pay is {0:C}, netPay is {1:C}", grossPay, netPay);
            }
        }
    }
}
