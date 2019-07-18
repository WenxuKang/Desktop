using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_CalculateAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int first;
            int second;
            int third;

            //Processing
            int sum;

            //Output
            int average;

            //Algorithm
            Console.WriteLine("Enter the first number");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            third = Convert.ToInt32(Console.ReadLine());
            sum = first + second + third;
            average = sum / 3;
            Console.WriteLine(average);

        }
    }
}
