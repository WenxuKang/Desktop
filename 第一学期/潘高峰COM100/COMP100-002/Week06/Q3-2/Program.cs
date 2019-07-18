using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            double Number = 0;
            int Counter = 0;
            double Average = 0;
            while (Counter < 10)
            {
                Console.Write("Enter a number: ");
                Number = Convert.ToDouble(Console.ReadLine());
                Sum = Sum + Number;
                Counter++;
            } 
            Average = Sum / 10;
            Console.Write("Average is:" + Average);
        }
    }
}
