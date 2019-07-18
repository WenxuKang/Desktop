using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursandMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertMintoH(197);
            void ConvertMintoH(double min)
            {
                double h;
                double remainder;

                h = (int)min / 60;
                remainder = min % 100;
                Console.WriteLine("Input      Result");
                Console.WriteLine($"{min,3}mins     {h}H {remainder}mins");
                Console.WriteLine();
            }
        }
    }
}
