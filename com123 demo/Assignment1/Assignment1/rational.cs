using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
      

        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

        public void IncreaseBy(Rational other)
        {
          
            Numerator = other.Numerator + Numerator;
            Denominator = other.Denominator + Denominator;

        }
        public void DecreaseBy(Rational other)
        {
            Numerator = Numerator - other.Numerator;
            Denominator = Denominator - other.Denominator;
        }
    }
}