using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaohui_Hao_Sec004_COMP123_Mid_term
{
    class BusinessMortgage:Mortgage
    {
        private double insuranceAmount;
        

        //properties
        public double InsuranceAmount
        {
            get
            {
                return insuranceAmount;
            }
            set
            {
                if (value > 0.00)
                    insuranceAmount = value;
            }
        }
        
        // Constructor
        public BusinessMortgage(int mortageNumber, string customerName, string customerAddress,
                            double mortgageAmount, double interestRate, double insuranceAmount) :
                            base(mortageNumber, customerName, customerAddress, mortgageAmount, interestRate)
        {
            InsuranceAmount = insuranceAmount;
           
        }

        //Method definition
        public override double CalculateMonthlyMortgageInstallment()
        {
            return base.CalculateMonthlyMortgageInstallment() + InsuranceAmount;
        }

        public override string ToString()
        {
            return string.Format("{0}\nInsurance Amount: {1}\n", base.ToString(), InsuranceAmount);
        }
    }
}
