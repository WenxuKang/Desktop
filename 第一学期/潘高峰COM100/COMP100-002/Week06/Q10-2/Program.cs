using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money = 1000;
            Console.WriteLine("Year       Balance");
            for (int Counter=1; Counter<=10; Counter++)
            {
                Money = Money * 1.08;
                Console.WriteLine("{0,2}{1,17:c}", Counter, Money);
            }
        }
    }
}
