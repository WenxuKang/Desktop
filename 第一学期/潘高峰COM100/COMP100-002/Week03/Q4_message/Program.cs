using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	Write a console-based program that accepts a user’s message and determines whether 
 * it is short enough for a social networking service that does not accept messages of more than 
 * 140 characters. [Hint: if the user’s input is assigned to the variable message then message.
 * Length with give the number of characters in the input]
 */
namespace Q4_message
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int length;
            Console.WriteLine("Enter your message: ");
            message =Console.ReadLine();
            length = message.Length;
            if (length <= 140)
            {
                Console.WriteLine("Short enough for a social networking service.");
            }
            else

            {    Console.WriteLine("Not short enough for a social networking service.");
            }

        }
    }
}
