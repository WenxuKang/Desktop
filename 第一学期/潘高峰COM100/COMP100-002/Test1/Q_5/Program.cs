using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #2 Winter 2018        =========================
 * 
 * Name:Gaofeng Pan
 * Student ID:300973143
 *
 * Question 5c.
 * 14 Marks.
 *
 * Write a program that displays the pattern show in the sample executable.
 * 
 * Type of loop-> your favorite (your must use a pair of nested loops)
 * Hints:
 *  1) Use counters that increments
 *  2) For columns use values between 61 and 76
 *  3) For rows use values between 16 and 21
 *  4) Start with a diagonal line of "-" then repeat it as necessary (use the % operator)
 *  
 * [Solution: Question5C]
 -------------------------------------------------------------------------------- */

namespace Q_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int m = 0;           
            while(m < row)
            {
                int n = 0;
                while (n < col)
                {
                    int s = m % 7;
                    if (s+(n % 7) == 0|| s + (n % 7)==7)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }

                    n++;
                }
                Console.WriteLine();
                m++;
            }
        }
    }
}
