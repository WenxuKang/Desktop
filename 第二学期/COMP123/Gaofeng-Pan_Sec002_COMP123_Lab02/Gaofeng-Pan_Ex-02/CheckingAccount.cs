using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Ex_02
{
    class CheckingAccount
    {
        private int AccNum { get; }
        private string CustomerName { get; }
        private double accBalance;

        public double AccBalance
        {
            get
            {
                return accBalance;
            }
            set
            {
                if (value < 50.0)
                    Console.WriteLine("Balance should be positive and minimum 50.00 dollars all the time.");
                else
                    accBalance = value;
            }
        }

        public CheckingAccount(int aNumber, string cName, double aBalance)
        {
            if (aNumber > 0)
                AccNum = aNumber;
            else
                Console.WriteLine("Provide positive value for account number.");


            if (cName != null)
                CustomerName = cName;
            else
                Console.WriteLine("Provide appropriate value for customer name.");


            AccBalance = aBalance;
        }

        public double Withdraw(double amount)
        {
            Console.WriteLine($"You are trying to withdraw {amount:c}.\n(Here is a reminder: With every withdrawal, there is transaction fee of 3.00 dollars.)");
            return AccBalance - amount - 3;
        }

        public override string ToString()
        {
            return string.Format($"Account Number: {AccNum}\nCustomer Name: {CustomerName}\nAccount Balance: {AccBalance}");
        }
    }
}
