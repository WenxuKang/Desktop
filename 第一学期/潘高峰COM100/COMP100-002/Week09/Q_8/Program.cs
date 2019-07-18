using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Write another method that creates and return an array of ints. 
 * The method takes a single argument that represents the number of items in the resulting array and does the following:
 * •	Declare an array of the required type
 * •	Allocate memory for the intended number of items
 * •	Using any looping structure, assign to each element a random integer in the range 100 to 200. 
 * Exercise this method in a similar fashion as you did for question 7.
 * Radom rand = new Random();
 * rand.Next(100, 200);
 */

namespace Q_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of numbers in array: ");
            RandomNumbers(Convert.ToInt32(Console.ReadLine()));
        }
        static void RandomNumbers(int b)
        {
            int[] RandomNumbers = new int[b];
            Random rand = new Random();
            for (int x = 0; x < RandomNumbers.Length; x++)
            {
                RandomNumbers[x] = rand.Next(100, 200);
            }
            foreach (int x in RandomNumbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}
