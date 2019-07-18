using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaohui_Hao_Sec004_COMP123_Mid_term
{
    class Mortgage
    {
        //define variables
        private int mortageNumber;
        private string customerName;
        private string customerAddress;
        double mortgageAmount;
        double interestRate;


        //properties
        public int MortageNumber
        {
            get
            {
                return mortageNumber;
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
        public double MortageAmount
        {
            get
            {
                return mortgageAmount;
            }
            set
            {
                if (value > 0.00)
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
                if (value > 0.0 & value < 5.0)
                    interestRate = value;
            }
        }

        //constractors
        public Mortgage(int mortageNumber, string customerName, string customerAddress,
                            double mortgageAmount, double interestRate)
        {
            this.mortageNumber = mortageNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            MortageAmount = mortgageAmount;
            InterestRate = interestRate;
        }
        public Mortgage(int mortageNumber, string customerName, string customerAddress)
        {
            this.mortageNumber = mortageNumber;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
        }

        //methods:
        public virtual double CalculateMonthlyMortgageInstallment()
        {
            return MortageAmount * InterestRate / 100 / 12;
        }
        public override string ToString()
        {

            return string.Format("Mortage number:{0} \nCustomer name:{1} \nCustomer address:{2} " +
                                    "\nMortage amount:{3:c} \nYearly rate of interest:{4}", +
                               MortageAmount, CustomerName, CustomerAddress, MortageAmount, InterestRate);
        }


    }
}
