using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class RealEstateSalesperson : Salesperson //create a child class
    {
        double totalSold;
        double totalComm;
        public RealEstateSalesperson(string fName, string lName, double totalSold, double totalComm) :
            base(fName, lName)
        {
            TotalSold = totalSold;
            TotalComm = totalComm;
        }

        public double TotalSold
        {
            get { return totalSold; }
            set
            {
                if (value > 0 )
                    totalSold = value;
                else
                    totalSold = 0;
            }
        }
        public double TotalComm
        {
            get { return totalComm; }
            set
            {
                if (value > 0)
                    totalComm = value;
                else
                    totalComm = 0;
            }
        }
        public override double MakeSale()
        {
            return TotalSold * totalComm /100;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("\nTotal sold: {0}", TotalSold);
        }
    }
}
