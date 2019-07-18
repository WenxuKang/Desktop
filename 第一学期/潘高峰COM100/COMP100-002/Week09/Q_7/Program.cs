using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	Write a method that creates and return an array of ints. 
 * The method takes a single argument that represents the number of items in the resulting array and does the following:
 * •	Declare an array of the required type
 * •	Allocate memory for the intended number of items
 * •	Using any looping structure, prompt the user for a number and then assign to each element. 
 * assign the resulting value to at suitable variable and then display this variable.
 */

namespace Q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of numbers in array: ");
            InputNumbers(Convert.ToInt32(Console.ReadLine()));
        }
        static void InputNumbers(int a)
        {
            int[] inputNumbers = new int[a];
            for (int x = 0; x < inputNumbers.Length; x++)
            {
                Console.Write($"Please input the #{x + 1} number: ");
                inputNumbers[x] = Convert.ToInt32(Console.ReadLine());
            }
            /*foreach(int x in inputNumbers)
            {
                Console.Write($"Please input the #{x + 1} number: ");
                x = Convert.ToInt32(Console.ReadLine());
            }*/                                                   //error
            foreach (int x in inputNumbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}
