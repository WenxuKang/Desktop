using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaohui_Hao_Sec004_COMP123_Mid_term
{
    class MortgageTest
    {
        static void Main(string[] args)
        {
            Mortgage customer1 = new Mortgage(12345, "Xiaohui Hao", "12 Angus Drive",
               5000.00, 2.0);
            Console.WriteLine(customer1.ToString());
            Console.WriteLine();

            double monthlyMortage = customer1.CalculateMonthlyMortgageInstallment();
            Console.WriteLine("Monthly Mortage Installment:{0:c}", monthlyMortage);
            Console.WriteLine();

            Mortgage customer2 = new Mortgage(12346, "Agnes Fang", "34 Bent");
            Console.WriteLine(customer2.ToString());
            Console.WriteLine();

            //Console.WriteLine(customer1);
            double houseMortage = customer1.CalculateMonthlyMortgageInstallment());
            Console.WriteLine("House Mortage: {0}", houseMortage);


        }
    }
}
