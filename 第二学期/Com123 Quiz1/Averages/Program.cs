using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program named Averages that includes a method that accepts any number of numeric parameters,
 * displays them, and displays their average. Your method should work 
 * with any number of numeric parameters or an array. */
namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, average, counter = 0, num = 999, grade = 0;
            while (grade != num)
            {
                Console.Write("Please enter your grade:");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade > 100 || grade < 0 && grade != 999)
                {
                    Console.WriteLine("Invalide value");
                    continue;
                }
                sum = sum + grade;
                counter = counter + 1;

            }

            average = sum / counter;
            Console.WriteLine("The average is:{0}", average);
        }
    }
}
