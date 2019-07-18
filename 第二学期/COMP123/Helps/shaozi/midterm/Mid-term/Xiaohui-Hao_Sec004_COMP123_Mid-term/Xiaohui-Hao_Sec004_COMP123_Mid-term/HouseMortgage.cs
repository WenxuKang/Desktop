using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiaohui_Hao_Sec004_COMP123_Mid_term
{
    class HouseMortgage:Mortgage
    {

        private double propertyTax;
        private double infrastructureTax = 100.00;
        
        //properties
        public double PropertyTax
        {
            get
            {
                return propertyTax;
            } 
            set
            {
                if (value > 0.00)
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
                if (value > 0.00)
                    infrastructureTax = value;
            }
        }
        // Constructor
        public HouseMortgage(int mortageNumber, string customerName, string customerAddress,
                            double mortgageAmount, double interestRate, double propertyTax, double infrastructureTax) : 
                            base(mortageNumber, customerName, customerAddress, mortgageAmount, interestRate)
        {
            PropertyTax = propertyTax;
            InfrastructureTax = infrastructureTax;
        } 

        //Method definition
        public override double CalculateMonthlyMortgageInstallment()
        {
            return base.CalculateMonthlyMortgageInstallment() + PropertyTax + InfrastructureTax;
        } 

        public override string ToString()
        {
            return string.Format("{0}\nProperty Tax: {1}\nInfrastructure Tax:{2}", base.ToString(), PropertyTax, InfrastructureTax);
        }
    }
}
