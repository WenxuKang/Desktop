using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	Write a C# program that displays a conversion table from gallons to liters. 
 * The program should display gallons from 10 to 20 in one-gallon increments 
 * and the corresponding liter equivalents. Use the relationship that 1 gallon contains 3.785 liters.
 */
namespace Q4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Gal = 10;
            double Lit;
            do
            {
                Console.Write("gallons: "+Gal);
                Lit = 3.785 * Gal;
                Console.WriteLine(" liters: "+Lit);
                Gal++;
            } while (Gal<=20);
        }
    }
}
