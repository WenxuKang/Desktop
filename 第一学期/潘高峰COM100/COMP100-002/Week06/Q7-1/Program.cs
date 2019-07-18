using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	Write a program to produce a table of the numbers 0 through 20 in increments of 2, with their squares and cubes.
 */

namespace Q7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b;
            int c;
            while(a<=20)
            {
                b = a * a;
                c = a * a * a;
                Console.WriteLine("{0,2}{1,10}{2,10}",a,b,c);
                a=a+2;
            }
        }
    }
}
