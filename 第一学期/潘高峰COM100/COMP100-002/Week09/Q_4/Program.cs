using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	In your main method use the method in question 1 to display the letters array, 
 * then use the Array.Reverse() method to reverse the letters array and then again call the appropriate method to print it
 */

namespace Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();

            for (int counter = 0; counter < letters.Length; counter++)
            {
                Console.Write(letters[counter] + " ");
            }
            Console.WriteLine();

            Array.Reverse(letters);

            for (int counter = 0; counter < letters.Length; counter++)
            {
                Console.Write(letters[counter] + " ");
            }
        }
    }
}
