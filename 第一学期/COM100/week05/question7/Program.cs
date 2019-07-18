﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	To repeatedly prompt for a number and sum it.
 * When the sum just exceeds 100, stop the prompting and display the sum at the end.
 * You must not display the sum while the user in typing in numbers.
 * (You do not need a counter but you will need some way of terminating the loop)
 *
 */
namespace question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            do
            {
                Console.Write("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                sum = sum + num;

            } while (sum <= 100);
            Console.WriteLine(sum);
        }
    }
}
