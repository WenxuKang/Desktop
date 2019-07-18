using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10.	A conversion table of Celsius to Fahrenheit temperature. 
 * The table must start with 0 Celsius and end at 100 Celsius with 
 * increments of 10. (Fahrenheit = Celsius * 9/5 + 32)
 */
namespace Q10_ConversionTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = 0;
            double F = 0;
            do
            {
                Console.Write("C: " + C);
                F = C * 9 / 5 + 32;
                Console.WriteLine(" F: " + F);
                C=C+10;
            } while (C<=100);
        }
    }
}
