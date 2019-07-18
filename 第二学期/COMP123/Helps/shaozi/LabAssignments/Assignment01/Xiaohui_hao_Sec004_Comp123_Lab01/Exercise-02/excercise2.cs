using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class excercise2
    {
        static void Main(string[] args)
        {
            Addition(1, 2, 3);
            Addition(1, 2, 3, 4);
            Addition(1, 2, 3, 4, 5);
        }
        private static void Addition(params int[] numbers)
        {
            Console.Write("The number list is ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ",");                
            }

            Console.WriteLine();
            
            var SumOfNumbers = numbers.Sum();
            Console.WriteLine("The Sum of three different numbers is:{0}", SumOfNumbers);
            Console.WriteLine();

        }
    }
}
