using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class PackageTest
    {
        static void Main(string[] args)
        {
            TwoDayPackage customer1 = new TwoDayPackage(101, "Mickey", "100 Finch Avenue West, Toronto", 80, 0.1, 10);
            Console.WriteLine(customer1.ToString());
            Console.WriteLine("Total cost: {0}\n\n", customer1.CaculatePackageCost());
            OverNightPackage customer2 = new OverNightPackage(102, "Adrian", "500 Dufferin Avenue East, Toronto", 120, 0.1, 10);
            Console.WriteLine(customer2.ToString());
            Console.WriteLine("Total cost: {0}\n\n", customer2.CaculatePackageCost());
        }
    }
}
