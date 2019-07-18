using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class PackageTest
    {
        static void Main(string[] args)
        {
            Package package1;

            // an object of TwoDayPackage class
            TwoDayPackage twodaypackage1 = new TwoDayPackage(1234, "hao", "42 Angus Drive", 20, 2, 10);
            Console.WriteLine("Two Day Package:  ");
            Console.WriteLine(twodaypackage1);
            Console.WriteLine("Amount of Two Day Package: " + twodaypackage1.CalculatePackageCost());

            // an object of OverNightPackage class
            OverNightPackage overnightpackage1 = new OverNightPackage(2234, "Anton", "Centennial", 10, 4, 20);
            Console.WriteLine("\nOver Night Package:  ");
            Console.WriteLine(overnightpackage1);
            Console.WriteLine("Amount of Over Night Package: " + overnightpackage1.CalculatePackageCost());

            //objects polymorphically
            Console.WriteLine("\nThe objects polymorpically:");
            Console.WriteLine("\nTwo Day Package:  ");
            package1 = twodaypackage1;
            Console.WriteLine(package1);
            Console.WriteLine("Amount of Two Day Package: " + package1.CalculatePackageCost());

            Console.WriteLine("\nOver Night Package:  ");
            package1 = overnightpackage1;
            Console.WriteLine(package1);
            Console.WriteLine("Amount of Over Night Package: " + package1.CalculatePackageCost());
        }           
    }
}
