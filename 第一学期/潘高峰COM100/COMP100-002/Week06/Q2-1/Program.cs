using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Write a Program to compute the sum of eight numbers that will be provided by the user.
 */
namespace Q2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            double Number = 0;
            int Counter = 0;
            do
            {
                Console.Write("Enter a number: ");
                Number = Convert.ToDouble(Console.ReadLine());
                Sum = Sum + Number;
                Counter++;
            } while (Counter<8);
            Console.Write("Sum is:"+Sum);
        }
    }
}
