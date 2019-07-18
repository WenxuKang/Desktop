using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #2 Winter 2018      =========================
 * 
 * Name:Gaofeng Pan
 * Student ID:300973143
 *
 * Question 3c.
 * 10 Marks.
 *
 * Write a program that displays a conversion table of liters to gallon. The program
 * prompts the user for the start liter and the end liter value. The table must be in
 * 21 increments. You must match the format exactly.
 * 
 * Type of loop-> while
 * 1 liter = 0.26 gallon
 * [Solution: Question3C]
 -------------------------------------------------------------------------------- */

namespace Q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start value: ");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter end value: ");
            double end = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("liter      gallon");
            while (start<=end)
            {
                Console.WriteLine($"{start,3}{start*0.26,12:f1}");
                start = start + 2;
            }
        }
    }
}
