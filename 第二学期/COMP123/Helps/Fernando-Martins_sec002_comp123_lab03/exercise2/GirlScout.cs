using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class GirlScout : Salesperson
    {
        double boxesSold;
        double totalSold;
        public GirlScout(string fName, string lName, double boxesSold) :
            base(fName, lName)
        {
            BoxesSold = boxesSold;
            TotalSold = totalSold;
        }

        public double BoxesSold
        {
            get { return boxesSold; }
            set
            {
                if (value > 0)
                    boxesSold = value;
                else
                    boxesSold = 0;
            }
        }

        public double TotalSold
        {
            get { return totalSold; }
            set
            {
                //if (value > 0)
                //    totalSold = value;
                //else
                //    totalSold = 0;
                totalSold = value;
            }
        }
        public override double MakeSale()
        {
            return TotalSold = TotalSold + BoxesSold;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nBoxes sold: {0}\nTotal sold: {1}\n  ", BoxesSold, TotalSold);
        }
    }
}
