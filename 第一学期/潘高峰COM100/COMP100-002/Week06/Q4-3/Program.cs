using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lit;
            for (int Gal = 10; Gal <= 20; Gal++)
            {
                Console.Write("gallons: " + Gal);
                Lit = 3.785 * Gal;
                Console.WriteLine(" liters: " + Lit);
            }
        }
    }
}
