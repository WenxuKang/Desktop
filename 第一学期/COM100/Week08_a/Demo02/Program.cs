using System;
/*
 * Display the following:
 * 
 * A B C D E F G I J
 * A B C D E F G I J
 * A B C D E F G I J
 * A B C D E F G I J
 * 
 * 
 * A B C D E F G I J
 */

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (char letter = 'A'; letter <= 'J'; letter++)
                {
                    Console.Write($"{letter} ");
                }
                Console.WriteLine();
            }
        }
    }
}
