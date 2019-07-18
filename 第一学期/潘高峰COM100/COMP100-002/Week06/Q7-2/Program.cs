using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int c;
            for (int a = 0; a <= 20; a = a + 2)
            {
                b = a * a;
                c = a * a * a;
                Console.WriteLine("{0,2}{1,10}{2,10}", a, b, c);
            }
        }
    }
}
