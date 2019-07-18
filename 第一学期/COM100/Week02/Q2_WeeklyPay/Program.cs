using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sarah Martin has been working for Quality Builders for 
 * four years. Last year, Sarah received a 4% raise, 
 * which brought her current weekly pay to $250. 
 * Sarah is schedule to receive a 3% raise next 
 * week. She wants you to write a program that 
 * will display, on the computer screen, the 
 * amount of her new weekly pay
 */
namespace Q2_WeeklyPay
{
    class Program
    {
        static void Main(string[] args)
        {
            //output
            double newWeeklyPay;
            //input
            double currentWeeklyPay, rateIncrease;
            //processing
            //algorithm
            Console.Write("Enter current pay: ");
            currentWeeklyPay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter percent increase: ");
            rateIncrease = Convert.ToDouble(Console.ReadLine());
            newWeeklyPay = currentWeeklyPay + (currentWeeklyPay * rateIncrease);
            Console.WriteLine(newWeeklyPay);
        }
    }
}
