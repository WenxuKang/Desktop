using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week04
{

 
    class Complex
    {

        public int Real { get; private set; }

        public int Imaginary { get; private set; }

        public double Argument;

        public double Modulus;

        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            return $"<{Real},{Imaginary}>";
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static bool operator == (Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary;
        }

        public static Complex operator -(Complex complex)
        {
            return new Complex(-complex.Real, -complex.Imaginary);
        }
    }
}
