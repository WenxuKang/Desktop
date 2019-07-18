using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class OverNightPackage : Package
    {
        double expressCharges;
        public OverNightPackage(int Id, string sName, string sAddress, double weight, double rate, double expressCharges) :
            base(Id, sName, sAddress, weight, rate)
        {
            ExpressCharges = expressCharges;
        }
        public override double RatePerGram
        { get => base.RatePerGram * 1.1; set => base.RatePerGram = value; }
        public double ExpressCharges
        {
            get { return expressCharges; }
            set
            {
                if (value > 0)
                    expressCharges = value;
                else
                    expressCharges = 0;
            }
        }
        public override double CaculatePackageCost()
        {
            return RatePerGram * WeightPackage + ExpressCharges;
        }
        public override string ToString()
        {
            return String.Format("ID: {0}\tSender's name: {1}\nSender's address:{2}\nFinal Rate(+10%): {3}\nWeight: {4}\nExpress Charges: {5}",
                PackageId,SenderName,SenderAddress,RatePerGram, WeightPackage,ExpressCharges );
        }
    }
}
