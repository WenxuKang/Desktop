using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Write a program to produce a table of numbers from 10 to 1, with their squares and cubes.
 *
 */
namespace Q8.@for
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int c;
            for (int a = 10; a >= 0; a--)
            {
                b = a * a;
                c = a * a * a;
                Console.WriteLine("{0,2}{1,10}{2,10}", a, b, c);
            }
        }
    }
}
