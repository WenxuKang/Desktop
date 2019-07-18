using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class CheckingAccount
    {
        //Initialize data members
        private int accountNumber;
        private string customerName;
        private double accountBalance;

        //Define propoerties
        public int AccountNumber//Read-only
        {
            get
            {
                return accountNumber;
            }
        }
        public string CustomerName//Read-only
        {
            get
            {
                return customerName;
            }
        }

        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                if (value < 50)
                {
                    Console.WriteLine("You don't have money enough. You need have at least in your account $50.00.\n");
                }
                else
                    accountBalance = value;
            }
        }
        //Constructor
        public CheckingAccount(int aNumber, string cName, double aBal)
        {
            this.accountNumber = aNumber;
            this.customerName = cName;
            this.accountBalance = aBal;
        }

        public double Withdraw(double amount)//Create method Withdraw
        {
            Console.WriteLine("You are trying to withdraw ${0}", amount);
            return accountBalance - amount - 3.00;//Calculating the new balance
        }
        public override string ToString()//Create method ToString
        {
            return string.Format("Account number: {0}\n Customer: {1}\n The balance is {2}\n",
                accountNumber, customerName, accountBalance);
        }
    }
}
