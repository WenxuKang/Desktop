using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Ex_02
{
    class CheckingAccountTest
    {
        static void Main(string[] args)
        {
            CheckingAccount customer001 = new CheckingAccount(33, "Wayne Pan", 20000.00);
            Console.WriteLine(customer001.ToString());
            Console.WriteLine();
            customer001.AccBalance = customer001.Withdraw(1500.00);
            Console.WriteLine(customer001.ToString());
            Console.WriteLine();
            customer001.AccBalance = customer001.Withdraw(15000.00);
            Console.WriteLine(customer001.ToString());
            Console.WriteLine();

            CheckingAccount customer002 = new CheckingAccount(-3, null, 49.00);
            Console.WriteLine(customer002.ToString());
        }
    }
}
