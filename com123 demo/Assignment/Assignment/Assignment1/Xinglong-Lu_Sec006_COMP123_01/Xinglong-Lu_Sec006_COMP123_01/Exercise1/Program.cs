using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, numberThree, numberFour;
            double numberFive;
            Console.Write("Enter the first number: ");
           numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Maximum value is {Maximum( numberOne,  numberTwo)}");
            Console.WriteLine();
            Console.Write("Enter the first number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            numberThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Maximum value is {Maximum(numberOne, numberTwo,numberThree)}");
            Console.WriteLine();
            Console.Write("Enter the fourth number: ");
            numberFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The square of the number is {Square(numberFour)}");
            Console.WriteLine();
            Console.Write("Enter the fifth number: ");
            numberFive = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The square of the number is {Square(numberFive)}");
        }
        private static int Maximum( int firstNumber,  int secondNumber)
        {            
            int maxNumber=Math.Max(firstNumber, secondNumber);
            return maxNumber;
        }
        private static int Maximum(int firstNumber, int secondNumber,int thirdNumber)
        {
            int maxNumber;
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                maxNumber = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                maxNumber = secondNumber;
            }
            else
            {
                maxNumber = thirdNumber;
            }
            return maxNumber;
        }
        private static int Square(int number)
        {
            return number * number;
        }
        private static double Square(double number)
        {
            return number * number;
        }
    }
 
}
