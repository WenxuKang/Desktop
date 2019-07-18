using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.	A machine purchased for $28,000 is depreciated at a rate of $4,000
 * a year for seven years. Write and run a 
 * C# program that computes and displays a depreciation table for seven years,
 * The table should have the form: 
 *
 */
namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 28000;
            int depreciation = 4000;
            int year = 1;
            int endYearValue = price - depreciation;
            int accumulateddepreciation = depreciation * year;

            Console.WriteLine("                           END-OF-YEAR         ACCUMULATED");
            Console.WriteLine("YEAR      DEPRECIATION        VALUE           DEPRECIATION");
            Console.WriteLine("----      ------------      ------------      ------------");
            do
            {
                Console.WriteLine("{0,3}{1,15}{2,15}{3,15}", year,   depreciation,   endYearValue,   accumulateddepreciation);
                year ++;
                endYearValue = endYearValue - depreciation;
                accumulateddepreciation = depreciation * year;

            } while (year <= 7);


        }
    }
}
