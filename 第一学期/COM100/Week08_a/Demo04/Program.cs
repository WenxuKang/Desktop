using System;
/*
 * Display the following:
 * 
 * 00 01 02 03 04 05 06 07 08 09
 * 10 11 12 13 14 15 16 17 18 19
 * 20 21 22 23 24 25 26 27 28 29
 *  
 * 90 91 92 93 94 95 96 97 98 99
 */
namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 10;
            const int ROWS = 10;
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    Console.Write($"{r}{c} ");
                }
                Console.WriteLine();
            }
        }
    }
}
