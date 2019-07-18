﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.	A machine purchased for $28,000 is depreciated at a rate of $4,000 a year for seven years.
 * Write and run a C# program that computes and displays a depreciation table for seven years,
 * The table should have the form: 
                           END-OF-YEAR         ACCUMULATED
YEAR      DEPRECIATION        VALUE           DEPRECIATION
----      ------------      ------------      ------------
 1            4000            24000               4000
 2            4000            20000               8000
 3            4000            16000              12000
 4            4000            12000              16000
 5            4000             8000              20000
 6            4000             4000              24000
 7            4000                0              28000

 *
 */
namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int despreciation = 4000;
            Console.WriteLine("                           END-OF-YEAR         ACCUMULATED");
            Console.WriteLine("YEAR      DEPRECIATION        VALUE           DEPRECIATION");
            Console.WriteLine("----      ------------      ------------      ------------");
            int year = 1, stop = 7,endofyearvalue = 24000;
            do
            {
                Console.WriteLine($"{year,2}{despreciation,16}");
                year++;
            } while (year <= stop);
        }
    }
}
