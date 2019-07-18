using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_exercise1
{
    class TwoDayPackage : Package
    {
        private double adminCharge;
        
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
        
        public TwoDayPackage(int packageId, string senderName, string senderAddress,
                             double weightOfPackage, double ratePerGram, double adminCharge) : base(packageId,
                             senderName, senderAddress, weightOfPackage, ratePerGram)
        {
            AdminCharge = adminCharge;
        }
        
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
