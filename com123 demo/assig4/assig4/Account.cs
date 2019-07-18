using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    class Account
    {
        public double balance;
        public string accountNumber;
        public double Transactions { get; set; }

        public Account(string AccountNumber)
        {
            accountNumber = AccountNumber;
        }
    }
}
