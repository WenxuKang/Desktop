using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	Write a Program to compute the average of ten numbers which will be entered by the user.
 */

namespace Q3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            double Number = 0;
            int Counter = 0;
            double Average = 0;
            do
            {
                Console.Write("Enter a number: ");
                Number = Convert.ToDouble(Console.ReadLine());
                Sum = Sum + Number;
                Counter++;
            } while (Counter < 10);
            Average = Sum / 10;
            Console.Write("Average is:" + Average);
        }
    }
}
