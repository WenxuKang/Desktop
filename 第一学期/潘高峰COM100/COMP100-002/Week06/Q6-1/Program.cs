using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.	Write a program that displays a conversion table from Fahrenheit to Celsius. 
 * The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment.
 * Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value
 */

namespace Q6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Cel;
            double Start;
            double End;
            double Counter;
            Console.Write("Please Enter the starting Fahrenheit value: ");
            Start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter the ending Fahrenheit value: ");
            End = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter the increment of Fahrenheit value: ");
            Counter = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Fahrenheit: "+Start);
                Cel = (Start - 32) * 5 / 9;
                Console.WriteLine(" Celsius: " + Cel);
                Start = Start + Counter;
            } while (Start<=End);
        }
    }
}
