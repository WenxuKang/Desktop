using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10.	A conversion table of Celsius to Fahrenheit temperature.
 * The table must start with 0 Celsius and end at
 * 100 Celsius with increments of 10. (Fahrenheit = Celsius * 9/5 + 32)
 *
 */
namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = 0;
            int fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Celcius Fahrenheit");
            do
            {
                
                Console.WriteLine("{0,1} {1,9}", celsius, fahrenheit);
                celsius = celsius + 10;
                fahrenheit = celsius * 9 / 5 + 32;
            } while (celsius <= 100);
        }
    }
}
