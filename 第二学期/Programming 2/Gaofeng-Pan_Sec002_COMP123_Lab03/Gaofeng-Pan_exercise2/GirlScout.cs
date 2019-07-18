using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_exercise2
{
    class GirlScout : Salesperson
    {
        private int numberOfBox = 0;

        public int NumberOfBox
        {
            get
            {
                return numberOfBox;
            }
            set
            {
                numberOfBox = value;
            }
        }
        
        public GirlScout(string firstName, string lastName, int numberOfBox) : base(firstName, lastName)
        {
            NumberOfBox = numberOfBox;

        }
        
        public override string SalesSpeech()
        {
            return "I am Girl Scout.";
        }
        public override double MakeSale()
        {
            return NumberOfBox;
        }
        public override string ToString()
        {
            return String.Format("\n{0} \nThe number of boxes: {1}",
                                 base.ToString(), NumberOfBox);
        }
    }
}
