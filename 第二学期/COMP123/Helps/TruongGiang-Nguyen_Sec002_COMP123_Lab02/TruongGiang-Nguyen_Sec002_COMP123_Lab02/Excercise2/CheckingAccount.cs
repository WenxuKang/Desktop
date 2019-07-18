using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class CheckingAccount
    {
        //Declarations & Initialization
        int accNum;
        string custName;
        double accBalance;
        public CheckingAccount() { } //default constructor
        public CheckingAccount(int accNum, string custName, double accBalance) //overload constructor
        {
            if (accNum > 0)
                this.accNum = accNum;
            else
                Console.WriteLine("Account Number must be positive!");
            if (custName != null)
                this.custName = custName;
            else
                Console.WriteLine("Customers Name should be filled");
            AccBalance = accBalance;
        }
        public int AccNum //read only property
        {
            get
            {
                return accNum;
            }
        }
        public string CustName //read only property
        {
            get
            {
                return custName;
            }
        } 
        public double AccBalance
        {
            get
            {
                return accBalance;
            }
            set
            {
                if(value >50.00)
                {
                    accBalance = value;
                }
                else
                {
                    Console.WriteLine("Your account need to have at least 50.00$");
                }
            }
        }
        public double WithDraw(double amount) //WithDraw Method
        {
            Console.WriteLine("Transaction fee is 3.00$");
            if (amount >= this.accBalance)
            {
                Console.WriteLine("Your account doesnt have enough money!");
                return 0;
            }
            else
                return amount-3.00;
        }
        public override string ToString()
        {
            return String.Format($"Account Number: {AccNum}\nCustomer Name: {CustName}\nAccount Balance: {AccBalance}");
        }
    }
}
