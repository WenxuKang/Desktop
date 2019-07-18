using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Meter;

            for (int Feet = 3; Feet <= 30; Feet = Feet + 3)
            {
                Console.Write("feet: " + Feet);
                Meter = Feet / 3.28;
                Console.WriteLine(" meter: " + Meter);
            }
        }
    }
}
