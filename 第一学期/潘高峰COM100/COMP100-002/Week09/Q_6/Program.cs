using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.	In your main method use the method in question 2 to display the numbers array, 
 * then use the Array.Binarysearch() method to try to find the position of 3 in the numbers array. 
 * What is your answer?
 * Now repeat the same steps after you have sorted the array and printed the sorted array
 */

namespace Q_6
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
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(numbers, 3));

            Array.Sort(numbers);
            i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(numbers, 3));
        }
    }    
}
