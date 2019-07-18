using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Exercise01
{
    class MortgageTest
    {
        static void Main(string[] args)
        {
            Mortgage customer01 = new Mortgage(123, "Wayne", "937 Progress Ave", 3000.00, 3.0);
            Console.WriteLine(customer01.ToString());
            Console.WriteLine();

            double yearlyMortgage = customer01.CalculateYearlyMortgage();
            Console.WriteLine("Yearly Mortgage amount: " + yearlyMortgage);
            Console.WriteLine();

            Mortgage customer02 = new Mortgage(456, "Peter", "939 Progress Ave");
            Console.WriteLine(customer02.ToString());
            Console.WriteLine();

            yearlyMortgage = customer02.CalculateYearlyMortgage();
            Console.WriteLine("Yearly Mortgage amount: " + yearlyMortgage);
            Console.WriteLine();



            double homeMortgage = customer01.CalculateYearlyMortgage();
            Console.WriteLine("Home Mortgage: {0}", homeMortgage);


            double commercialMortgage = customer01.CalculateYearlyMortgage();
            Console.WriteLine("Commercial Mortgage: {0}", commercialMortgage);
        }
    }
}
