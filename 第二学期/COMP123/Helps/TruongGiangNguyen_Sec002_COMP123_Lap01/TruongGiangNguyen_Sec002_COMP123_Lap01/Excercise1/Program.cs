using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations & Initializations
            int result;
            //Maximum of two Invoke 
            result = Maximum(3, 5);
            Console.WriteLine($"First Maximum Method:\t {result}");
            //Overloading Maximum method of three
            result = Maximum(3, 7, 5);
            Console.WriteLine($"Second Maximum Method:\t {result}");
            //Square method of integer Invoke
            result = Square(2);
            Console.WriteLine($"Intiger Square Method:\t {result}");
            //Overloading Square method of double
            double doubleResult = Square(0.5);
            Console.WriteLine($"Double Square Method:\t {doubleResult}");

        }
        private static int Maximum(int firstNum, int secondNum)
        {
            int maxVal = 0;
            if (secondNum > firstNum)
                maxVal = secondNum;
            else
                maxVal = firstNum;
            return maxVal;
        }
        private static int Maximum(int firstNum, int secondNum, int thirdNum)
        {
            int maxVal = firstNum;
            if (secondNum > firstNum)
                maxVal = secondNum;
            if (thirdNum > maxVal)
                maxVal = thirdNum;
            return maxVal;
        }
        private static int Square(int iNum)
        {
            return iNum * iNum;
        }
        private static double Square(double iNum)
        {
            return iNum * iNum;
        }
    }
}
