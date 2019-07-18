using System;
/*
 * Display the following:
 * 
 * A B C D E F G I J
 */

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char letter = 'A'; letter <= 'J'; letter++)
            {
                Console.Write($"{letter} ");
            }
        }
    }
}
