using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Gal = 10;
            double Lit;
            while (Gal <= 20)
            {
                Console.Write("gallons: " + Gal);
                Lit = 3.785 * Gal;
                Console.WriteLine(" liters: " + Lit);
                Gal++;
            } 
        }
    }
}
