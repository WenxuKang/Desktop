using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class exercise3
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine("The original numbers are x = {0}, y = {1}", x, y);
            Console.WriteLine();

            Swap(ref x, ref y);
            Console.WriteLine("The exchanged numbers are x = {0}, y = {1}", x, y);
            Console.WriteLine();

            Initialize(out x, out y);
            int Average = (x + y) / 2;
            Console.WriteLine("When x = {0}, y = {1}, the Average number is {2}: ", x, y, Average);
            Console.WriteLine();
        }
        private static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;       
        }
        private static void Initialize(out int x, out int y)
        {
            x = 10;
            y = 20;
        }
    }
}
