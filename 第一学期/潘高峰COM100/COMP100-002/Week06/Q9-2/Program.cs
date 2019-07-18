using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double inPut = 0;
            double Total = 0;
            double Average = 0;
            int Counter = 0;
            for( ; ; )
            {
                Console.Write("Please enter a grade: ");
                inPut = Convert.ToDouble(Console.ReadLine());
                if (inPut == 999)
                    break;
                if (inPut < 0 || inPut > 100)
                {
                    Console.Write("This is an invalid grade.");
                }
                else
                {
                    Total = Total + inPut;
                    Counter++;
                }
            }
            Average = Total / Counter;
            Console.Write("The average of input is: " + Average);
        }
    }
}
