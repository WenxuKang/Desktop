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
 * Question 4c.
 * 12 Marks.
 *
 * Write a program that displays the table show in the sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = 6x^2 - 5x + 1
 *             
 * Type of loop-> your favorite (your MUST use a loop)
 * Hints:
 *  1) Generate the first column using a place holder (increment = 0.015)
 *  2) Generate successive columns one at a time by adding another placeholder
 *  3) Format using column specifier (do not use tabs)
 *     
 * [Solution: Question4C]
 -------------------------------------------------------------------------------- */

namespace Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   x   6x^2    -5x     +1      y");
            Console.WriteLine("----   ----   ----   ----   ----");
            for (double i=0.3; i<=0.55; i=i+0.015)
            {
                Console.WriteLine($"{i,4:f}{6 * i * i,7:f}{-5*i,7:f}{1,7:f}{6*i*i-5*i+1,7:f}");
            }
        }
    }
}
