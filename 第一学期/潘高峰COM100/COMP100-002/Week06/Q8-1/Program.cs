using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Write a program to produce a table of numbers from 10 to 1, with their squares and cubes.
 */

namespace Q8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b;
            int c;
            while (a >= 1)
            {
                b = a * a;
                c = a * a * a;
                Console.WriteLine("{0,2}{1,10}{2,10}", a, b, c);
                a--;
            }
        }
    }
}
