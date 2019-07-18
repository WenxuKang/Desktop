using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Exercise01
{
    class CommercialMortgage:Mortgage
    {
        private double insuranceAmount;

        public double InsuranceAmount
        {
            get
            {
                return insuranceAmount;
            }
            set
            {
                if (value > 0)
                    insuranceAmount = value;
            }
        }

        public CommercialMortgage(int mortgageNumber, string customerName, string customerAddress,
            double mortgageAmount, double interestRate, double insuranceAmount):
            base(mortgageNumber, customerName, customerAddress, mortgageAmount, interestRate)
        {
            InsuranceAmount = insuranceAmount;
        }

        public override double CalculateYearlyMortgage()
        {
            return base.CalculateYearlyMortgage() + InsuranceAmount;
        }

        public override string ToString()
        {
            return string.Format("{0}\nInsurance Amount: {1}", base.ToString(), InsuranceAmount);
        }
    }
}
