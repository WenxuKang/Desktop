using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a console application named Sum100 that sums the integers from 1 through 100. */
namespace Sum100
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0, end = 0, sum = 0;

            Console.WriteLine("Enter The First Integer");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Integer");
            end = int.Parse(Console.ReadLine());

            if (start < end)
            {
                for (int i = start; i <= end; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum Of The Numbers Between The {0} and {1} is {2} ", start, end, sum);
            }
            else
            {
                Console.WriteLine("Second Number Must Be Bigger Than The First Number");
            }

            Console.ReadLine();
        }
    }
}
