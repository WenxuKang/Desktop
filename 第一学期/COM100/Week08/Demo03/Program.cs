using System;
/*
 * Display the following:
 * 
 * 0A 0B 0C 0D 0E 0F 0G 0H 0I 0J
 * 1A 1B 1C 1D 1E 1F 1G 1H 1I 1J
 * 2A 2B 2C 2D 2E 2F 2G 2H 2I 2J
 * 
 * 9A 9B 9C 9D 9E 9F 9G 9H 9I 9J 
 */

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (char letter = 'A'; letter <= 'J'; letter++)
                {
                    Console.Write($"{i}{letter} ");
                }
                Console.WriteLine();
            }
        }
    }
}


 


