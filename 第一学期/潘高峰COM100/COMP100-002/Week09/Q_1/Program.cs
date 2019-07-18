using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Write a method that takes an argument (a char array) and print each item on a single line separated by a space. 
 * From your main, call this method with letters as argument
 */

namespace Q_1
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
        }
    }
}
