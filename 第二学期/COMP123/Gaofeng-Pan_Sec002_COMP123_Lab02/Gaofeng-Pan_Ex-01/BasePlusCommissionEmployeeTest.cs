using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Ex_01
{
    class BasePlusCommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            BasePlusCommissionEmployee employee001 = new BasePlusCommissionEmployee(50, "Gaofeng", "Pan", 1000.00, 2000.00, 0.3);
            Console.WriteLine(employee001.ToString());
            Console.WriteLine($"Earnings: {employee001.Earnings()}");
            Console.WriteLine();

            BasePlusCommissionEmployee employee002 = new BasePlusCommissionEmployee(52, "Wayne", "Pan", 1000.00);
            Console.WriteLine(employee002.ToString());
            Console.WriteLine($"Earnings: {employee002.Earnings()}");
            Console.WriteLine();

            BasePlusCommissionEmployee employee003 = new BasePlusCommissionEmployee(-10, null, null, -100.00, -200.00, -0.5);
            Console.WriteLine(employee003.ToString());
            Console.WriteLine($"Earnings: {employee003.Earnings()}");
        }
    }
}
