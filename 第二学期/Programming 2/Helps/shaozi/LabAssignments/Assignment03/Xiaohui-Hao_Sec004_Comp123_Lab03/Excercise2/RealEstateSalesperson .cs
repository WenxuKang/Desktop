using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise2
{
    class RealEstateSalesperson: Salesperson
    {
        private int totalValueSold = 0;
        //private double totalCommission = 0.00;
        private double commissionRate;
       
        //property
        public int TotalValueSold
        {
            get
            {
                return totalValueSold;
            }
            set
            {
                totalValueSold = value;
            }
        }
        //public double TotalCommission
        //{
        //    get
        //    {
        //        return totalCommission;
        //    }
        //    set
        //    {
        //        totalCommission = value;
        //    }
        //}
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0.0)
                    commissionRate = value;
                else
                    Console.WriteLine("Commission Rate should be positive.");
            }
        }
        //constructor
        public RealEstateSalesperson(string firstName, string lastName, int totalValueSold, 
                                     double commissionRate):base(firstName, lastName)
        {
            TotalValueSold = totalValueSold;
            CommissionRate = commissionRate;
        }
        public override string SalesSpeech()
        {
            return "I am Real Estate Sales.";
        }
        public override double MakeSale()
        {
            return (TotalValueSold * commissionRate / 100); 
        }
        public override string ToString()
        {
            return String.Format("\n{0} \nHouse Value: {1} \nCommission Rate: {2}",
                                 base.ToString(), TotalValueSold, CommissionRate);
        }
        
    }
}
