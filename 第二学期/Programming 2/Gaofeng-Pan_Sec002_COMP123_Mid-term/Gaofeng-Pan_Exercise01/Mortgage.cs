using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Exercise01
{
    class Mortgage
    {
        private int mortgageNumber;
        private string customerName;
        private string customerAddress;
        double mortgageAmount;
        double interestRate;

        public int MortgageNumber
        {
            get
            {
                return mortgageNumber;
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }
        public double MortgageAmount
        {
            get
            {
                return mortgageAmount;
            }
            set
            {
                if (value > 0)
                    mortgageAmount = value;            
            }
        }
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value > 2 & value < 5)
                    interestRate = value;
            }
        }

        public Mortgage(int mortgageNumber, string customerName, string customerAddress,
            double mortgageAmount, double interestRate)
        {
            this.mortgageNumber = mortgageNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            MortgageAmount = mortgageAmount;
            InterestRate = interestRate;
        }
        public Mortgage(int mortgageNumber, string customerName, string customerAddress)
        {
            this.mortgageNumber = mortgageNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
        }

        public virtual double CalculateYearlyMortgage()
        {
            return MortgageAmount * InterestRate / 100;
        }
        public override string ToString()
        {
            return string.Format("Mortgage number: {0}\nCustomer name: {1}\nCustomer address: {2}" +
                "\nMortgage amount: {3:c}\nYearly rate of interest: {4}"
                , MortgageNumber, CustomerName, CustomerAddress, MortgageAmount, InterestRate);
        }


    }
}
