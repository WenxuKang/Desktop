using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_exercise1
{
    class OverNightPackage : Package
    {
        private double expressCharge;
        
        public double ExpressCharge
        {
            get
            {
                return expressCharge;
            }
            set
            {
                if (value > 0.00)
                    expressCharge = value;
                else
                    Console.WriteLine("Value for express charges should be positive");
            }
        }
        
        public OverNightPackage(int packageId, string senderName, string senderAddress,
                             double weightOfPackage, double ratePerGram, double expressCharge) : base(packageId,
                             senderName, senderAddress, weightOfPackage, ratePerGram)
        {
            ExpressCharge = expressCharge;
        }
        
        public override double CalculatePackageCost()
        {
            return (WeightOfPackage * (RatePerGram / 100 + 0.1) + ExpressCharge);
        }

        public override string ToString()
        {
            return String.Format("\n{0}, Express Charge: {1}", base.ToString(), ExpressCharge);
        }
    }
}
