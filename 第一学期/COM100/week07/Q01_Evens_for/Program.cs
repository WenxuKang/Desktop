using System;
/*
 * 1.	Write a program to print the numbers 2 to 10 in 
 * increments of two on the same line. The output of your 
 * program should be 2 4 6 8 10 
 */

namespace Q01_Evens_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, stop = 10, step = 2;

            for (int number = 2; number <= stop; number += step)
            {
                Console.Write($"{number} ");
                sum += number;
            }

            Console.WriteLine($"\n\n{sum}");
            Console.WriteLine();
        }
    }
}
