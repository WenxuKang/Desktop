using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations & Initializations
            int firstVal=1, secondVal=5;
            //Before Swap
            Console.WriteLine($"Before Swap(): {firstVal}, {secondVal}");
            //Invoke Method Swap()
            Swap(ref firstVal, ref secondVal);
            //After Swap() Invoked
            Console.WriteLine($"After Swap(): {firstVal}, {secondVal}");
            //Invoke Initialize Method
            Initialize(out firstVal, out secondVal);
            //Caculate average
            double average = (firstVal + secondVal) / 2.0;
            Console.WriteLine($"Average of {firstVal} & {secondVal} is: {average}");//Print average
        }
        private static void Swap(ref int firstNum, ref int secondNum)
        {
            int temp = 0; // temporary variable
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
        }
        private static void Initialize(out int firstNum, out int secondNum)
        {
            //Prompt user enter new value
            Console.WriteLine("Enter new first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
        }
    }
}
