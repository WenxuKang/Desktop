using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Exercise01
{
    class HomeMortgage:Mortgage
    {
        private double propertyTax;
        private double infrastructureTax = 100.00;

        public double PropertyTax
        {
            get
            {
                return propertyTax;
            }
            set
            {
                if (value > 0)
                    propertyTax = value;
            }
        }
        public double InfrastructureTax
        {
            get
            {
                return infrastructureTax;
            }
            set
            {
                if (value > 0)
                    infrastructureTax = value;
            }
        }

        public HomeMortgage(int mortgageNumber, string customerName, string customerAddress,
            double mortgageAmount, double interestRate, double propertyTax, double infrastructureTax):
            base(mortgageNumber, customerName, customerAddress, mortgageAmount, interestRate)
        {
            PropertyTax = propertyTax;
            InfrastructureTax = infrastructureTax;
        }

        public override double CalculateYearlyMortgage()
        {
            return base.CalculateYearlyMortgage() + PropertyTax + InfrastructureTax;
        }
        public override string ToString()
        {
            return string.Format("{0}\nProperty Tax: {1}\nInfrastructure Tax: {2}", base.ToString(), PropertyTax, InfrastructureTax);
        }

    }
}
