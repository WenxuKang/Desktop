using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class TwoDayPackage : Package
    {
        double adminCharges;
        public TwoDayPackage(int Id, string sName, string sAddress, double weight, double rate, double adminCharges) :
            base(Id, sName, sAddress, weight, rate)
        {
            AdminCharges = adminCharges;
        }
        public double AdminCharges
        {
            get { return adminCharges; }
            set
            {
                if (value > 0)
                    adminCharges = value;
                else
                    adminCharges = 0;
            }
        }
        public override double CaculatePackageCost()
        {
            return WeightPackage * RatePerGram + AdminCharges;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("\nAdmin charges: {0}", AdminCharges);
        }
    }
}
