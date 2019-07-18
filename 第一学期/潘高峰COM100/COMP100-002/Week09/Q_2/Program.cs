using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Write a method that takes an argument (an int array) and print each item on a single line separated by a space. 
 * From your main, call this method with numbers as argument
 */

namespace Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
        }
    }
}
