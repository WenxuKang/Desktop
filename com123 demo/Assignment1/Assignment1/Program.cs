using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {

                Console.Write("Choose a numberator: ");
                int myNumerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose a denominator: ");
                int myDenominator = Convert.ToInt32(Console.ReadLine());
                Rational original = new Rational(myNumerator, myDenominator);
                Rational zero =  new Rational(4, 6);
                Rational one = new Rational(3, 10);
                Rational two = new Rational(5, 13);




                Console.WriteLine(original.ToString());
                Console.WriteLine(zero.ToString());
                Console.WriteLine(one.ToString());
                Console.WriteLine(two.ToString());

                Console.WriteLine();
                original.IncreaseBy(original);
                Console.WriteLine(original.ToString());
                original.DecreaseBy(zero);
                
                Console.WriteLine(original.ToString());
                Console.WriteLine();
                zero.IncreaseBy(zero);
                Console.WriteLine(zero.ToString());
                zero.DecreaseBy(one);
                
                Console.WriteLine(zero.ToString());
                Console.WriteLine();
                one.IncreaseBy(one);
                Console.WriteLine(one.ToString());
                one.DecreaseBy(two);
              
                Console.WriteLine(one.ToString());
            }

        }
    }
}