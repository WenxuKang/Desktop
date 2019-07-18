using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write an app which contains the following functions which make use of ref and out parameters:
a) private static void Swap(ref int, ref int) which exchanges the contents of two variables
b) private static void Initialize(out int, out int) which initializes two numbers 
   and then you need to find their average in Main() and print the result.
 */

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Please enter two integer number(first one): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter two integer number(second one): ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap, the first number is {0}, the second number is {1}.", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("After swap, the first number is {0}, the second number is {1}.", x, y);
            Console.WriteLine();

            int m, n;
            Initialize(out m, out n);
            double ave = (m + n) / 2.0;
            Console.WriteLine("Average: " + ave);
        }

        private static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        private static void Initialize(out int a, out int b)
        {
            Console.WriteLine("Please enter two integer numbers(first one): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter two integer numbers(second one): ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
}
