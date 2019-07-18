using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Feet = 3;
            double Meter;
            while (Feet <= 30) 
            {
                Console.Write("feet: " + Feet);
                Meter = Feet / 3.28;
                Console.WriteLine(" meter: " + Meter);
                Feet = Feet + 3;
            } 
        }
    }
}
