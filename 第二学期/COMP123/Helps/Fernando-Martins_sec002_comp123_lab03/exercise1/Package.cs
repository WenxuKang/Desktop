using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    abstract class Package//create abstract class
    {
        //Initialize data members
        int packageId;
        string senderName;
        string senderAddress;
        double weightPackage;
        double ratePerGram;
        public Package() { }
        public Package(int Id, string sName, string sAddress, double weight, double rate)
        {
            PackageId = Id;
            SenderName = sName;
            SenderAddress = sAddress;
            WeightPackage = weight;
            RatePerGram = rate;
        }
        public int PackageId
        {
            get { return packageId; }
            set { packageId = value; }
        }
        public string SenderName
        {
            get { return senderName; }
            set { senderName = value; }
        }
        public string SenderAddress
        {
            get { return senderAddress; }
            set { senderAddress = value; }
        }
        public double WeightPackage
        {
            get { return weightPackage; }
            set
            {
                if (value > 0)
                    weightPackage = value;
                else
                    weightPackage = 0;
            }
        }
        public virtual double RatePerGram
        {
            get { return ratePerGram; }
            set
            {
                if (value > 0)
                    ratePerGram = value;
                else
                    ratePerGram = 0;
            }
        }
        public abstract double CaculatePackageCost();
        public override string ToString()
        {
            return String.Format("ID: {0}\tSender's name: {1}\nSender's address:{2}\nRate: " +
                "{3} per gram\nWeight: {4}", PackageId, SenderName, SenderAddress, RatePerGram, WeightPackage);
        }
    }
}
