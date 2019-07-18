using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_exercise1
{
    public abstract class Package
    {
        private int packageId;
        private string senderName;
        private string senderAddress;
        private double weightOfPackage;
        private double ratePerGram;

        public int PackageId
        {
            get
            {
                return packageId;
            }
            set
            {
                packageId = value;
            }
        }
        public string SenderName
        {
            get
            {
                return senderName;
            }
            set
            {
                senderName = value;
            }
        }
        public string SenderAddress
        {
            get
            {
                return senderAddress;
            }
            set
            {
                senderAddress = value;
            }
        }
        public double WeightOfPackage
        {
            get
            {
                return weightOfPackage;
            }
            set
            {
                if (value > 0.0)
                    weightOfPackage = value;
                else
                    Console.WriteLine("Value for Weight Of Package should be positiv");
            }
        }
        public double RatePerGram
        {
            get
            {
                return ratePerGram;
            }
            set
            {
                if (value > 0.0)
                    ratePerGram = value;
                else
                    Console.WriteLine("Value for Rate per Gram should be positiv");
            }
        }

        public Package(int packageId, string senderName, string senderAddress,
                       double weightOfPackage, double ratePerGram)
        {
            PackageId = packageId;
            SenderName = senderName;
            SenderAddress = senderAddress;
            WeightOfPackage = weightOfPackage;
            RatePerGram = ratePerGram;
        }

        public abstract double CalculatePackageCost();

        public override string ToString()
        {
            return String.Format("\nPackage id: {0}, \nSender's Name: {1}, \nSender's Address: {2}, " +
                                   "\nWeight of Package: {3} Grams, \nRate per Gram: {4}",
                                 PackageId, SenderName, SenderAddress, WeightOfPackage, RatePerGram);
        }
    }
}
