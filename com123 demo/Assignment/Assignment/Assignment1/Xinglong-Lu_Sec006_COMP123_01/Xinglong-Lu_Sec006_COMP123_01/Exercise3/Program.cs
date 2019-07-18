using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1, numberTwo = 2;
            Console.WriteLine($"The first number is {numberOne}, and the second number is {numberTwo}");
            Swap(ref numberOne, ref numberTwo);
            Console.WriteLine($"After Swap method, the first number is {numberOne}, and the second number is {numberTwo}");
            Console.WriteLine();
            int numberThree, numberFour;
            Initialize(out numberThree, out numberFour);
            double average = (numberThree + numberFour) / 2.0;
            Console.WriteLine($"The average of two numbers is {average}");
        }
        private static void Swap(ref int firstNumber, ref int secondNumber)
        {
            int thirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
        }
        private static void Initialize(out int firstNumber, out int secondNumber)
        {
            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
