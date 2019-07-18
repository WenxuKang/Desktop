using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class CheckingAccountTest
    {
        static void Main(string[] args)
        {
            CheckingAccount customer1 = new CheckingAccount(1023, "Fernando", 5000.00);
            Console.WriteLine(customer1.ToString());//Show the initial balance
            customer1.AccountBalance=customer1.Withdraw(2500.00);// First withdraw
            Console.WriteLine(customer1.ToString());//Show the new balance
            customer1.AccountBalance = customer1.Withdraw(2500.00);//Second withdraw
            Console.WriteLine(customer1.ToString());//Show the new balance
        }
    }
}
