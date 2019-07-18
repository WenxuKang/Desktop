using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration & Initialization
            BasePlusCommissionEmployee emp1 = new BasePlusCommissionEmployee(01, "Truong", "Nguyen", 5000, 1200, 0.08);
            Console.WriteLine(emp1.ToString());//Display
            Console.WriteLine($"Earnings: {emp1.Earnings()}"); //Invoke Earning() 
            Console.WriteLine();
            BasePlusCommissionEmployee emp2 = new BasePlusCommissionEmployee(02, "Fernando", "Martin", 3000);
            Console.WriteLine(emp2.ToString());//Display
            Console.WriteLine($"Earnings: {emp2.Earnings()}"); //Invoke Earning()
        }
    }
}
