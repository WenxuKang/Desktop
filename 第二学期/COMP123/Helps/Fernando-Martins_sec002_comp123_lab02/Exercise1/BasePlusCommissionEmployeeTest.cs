using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class BasePlusCommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            // create an object of BasePlusCommissionEmployee class
            BasePlusCommissionEmployee e1 = new BasePlusCommissionEmployee(100, "John", "Wayne", 1000.00, 400.00, 0.5);
            // Print results using methods ToString and Earnings
            Console.WriteLine(e1.ToString() + "\n");
            // create an object of BasePlusCommissionEmployee class
            BasePlusCommissionEmployee e2 = new BasePlusCommissionEmployee(101, "Meryl", "Streep", 2000.00);
            // Print results using methods ToString and Earnings
            Console.WriteLine(e2.ToString() + "\n");
            // create an object of BasePlusCommissionEmployee class
            BasePlusCommissionEmployee e3 = new BasePlusCommissionEmployee(101, "Kevin", "Costner", -2000.00,-500.00, 1.5);
            // Print results using methods ToString and Earnings
            Console.WriteLine(e3.ToString() + "\n");
        }
    }
}
