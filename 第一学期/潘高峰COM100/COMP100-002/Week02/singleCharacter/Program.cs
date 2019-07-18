using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	Write a program to prompt the user to enter a single character. 
 * The program should display a message like “Your response was y”. 
 * For this question, you must use a variable of type char.
 */

namespace singleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.Write("Enter a single character:");
            character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your response was: "+character);
        }
    }
}
