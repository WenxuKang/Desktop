using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise2
{
    class GirlScout:Salesperson
    {
        private int numberOfBox = 0;
        //property
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
        //constructor
        public GirlScout(string firstName, string lastName, int numberOfBox) : base(firstName, lastName)
        {
            NumberOfBox = numberOfBox;
            
        }
        //method
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
