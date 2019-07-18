using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            double Number = 0;
            for (int Counter=0;Counter < 8;Counter++)
            {
                Console.Write("Enter a number: ");
                Number = Convert.ToDouble(Console.ReadLine());
                Sum = Sum + Number;
            }
            Console.Write("Sum is:" + Sum);
        }
    }
}
