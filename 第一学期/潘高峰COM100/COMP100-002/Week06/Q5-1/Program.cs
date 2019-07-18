using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	Write a C# program that converts feet to meters.
 * The program should display feet from 3 to 30 in three-foot increments and the corresponding meter equivalents.
 * Use the relationship that 1 meter is equivalent to 3.28 feet. 
 */

namespace Q5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Feet = 3;
            double Meter;
            do
            {
                Console.Write("feet: " + Feet);
                Meter = Feet/3.28;
                Console.WriteLine(" meter: " + Meter);
                Feet = Feet+3;
            } while (Feet  <= 30);
        }
    }
}
