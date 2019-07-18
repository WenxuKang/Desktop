using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    public class TwoDayPackage:Package
    {
        //variable admin charges
        private double adminCharge;
        //property
        public double AdminCharge
        {
            get
            {
                return adminCharge;
            }
            set
            {
                if (value > 0.00)
                    adminCharge = value;
                else
                    Console.WriteLine("Value of Admin Charges should be positive");
            }
        }
        //constractor
        public TwoDayPackage(int packageId, string senderName, string senderAddress, 
                             double weightOfPackage, double ratePerGram, double adminCharge):base(packageId, 
                             senderName, senderAddress, weightOfPackage, ratePerGram)
        {
            AdminCharge = adminCharge;
        }
        //method
        public override double CalculatePackageCost()
        {
            return (WeightOfPackage * RatePerGram / 100) + AdminCharge;
        }

        public override string ToString()
        {
            return String.Format("\n{0}, Admin Charge: {1}", base.ToString(), AdminCharge);
        }

    }
}
