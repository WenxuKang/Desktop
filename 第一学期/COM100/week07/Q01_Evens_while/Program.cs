using System;
/*
 * 1.	Write a program to print the numbers 2 to 10 in 
 * increments of two on the same line. The output of your 
 * program should be 2 4 6 8 10 
 */

namespace Q01_Evens_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2, stop = 10, step = 2;
            while (number <= stop) 
            {
                Console.Write($"{number} ");
                number = number + step;
            } 
            Console.WriteLine();
        }
    }
}
