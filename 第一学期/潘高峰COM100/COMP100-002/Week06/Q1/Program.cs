using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Write a program to print the numbers 2 to 10 in increments of two on the same line.
 * The output of your program should be 2 4 6 8 10 
 */

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Counter = 2;
            int Start = 2;
            do
            {
                Console.Write(Start+" ");
                Start += Counter;
            } while (Start <=10);
           
        }
    }
}
