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
 * Question 1c.
 * 8 Marks.
 *
 * Write a program that prints multiples of 4 in decending order on a single line.
 * The program prompts the user for the start value. 
 * 
 * Type of loop-> for
 * [Solution: Question1C]
 -------------------------------------------------------------------------------- */


namespace Q_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (;a>0 ;a-- )

            {
                if (a % 4 == 0)
                {
                    Console.Write(a+" ");
                }
            }
        }
    }
}