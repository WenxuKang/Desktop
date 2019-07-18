using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Write a program that allows the user to enter two integers and a character
 * If the character is A, add the two integers If it is S, 
 * subtract the second integer from the first else multiply the integers 
 * Display the results of the arithmetic
 */

namespace Q2_calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 X;
            Int32 Y;
            Int32 Z;
            char letter;
            Console.Write("Enter the first integer: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character: ");
            letter = Convert.ToChar(Console.ReadLine());
            switch (letter)
            {
                case 'A':
                    Z = X + Y;
                    Console.WriteLine(Z);
                    break;
                case 'S':
                    Z = X - Y;
                    Console.WriteLine(Z);
                    break;
                default:
                    Z = X * Y;
                    Console.WriteLine(Z);
                    break;


            }
        }
    }
}
