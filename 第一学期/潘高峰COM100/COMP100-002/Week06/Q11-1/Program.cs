using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.	Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user.
 * For example, if the user enters an a and a z, the program should print all the characters between a and z and their respective numerical values. 
 * Make sure that the second character entered by the user occurs later in the alphabet than the first character. 
 * If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
Your output should be formatted as shown below
Letter	Decimal	Octal	Hex
a		97	141	61
b		98	142	62
c		99	143	63
d		100	144	64
e		101	145	65
to obtain an int from a char use an explicit cast
to obtain an octal from an int use Convert.ToString(«number_value», 8)
to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)
 */

namespace Q11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char X;
            char Y;
            Console.Write("Please enter a start character: ");
            X = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a stop character: ");
            Y = Convert.ToChar(Console.ReadLine());
            if (X>Y)
            { while (true)
                {
                    Console.WriteLine("The second character should occur later in the alphabet than the first character.");
                    Console.Write("Please enter a stop character: ");
                    Y = Convert.ToChar(Console.ReadLine());
                    if (X<=Y)
                        break;
                }
            }
            Console.WriteLine("Letter     Decimal     Octal     Hex");
            while (X<=Y)
            {
                Console.WriteLine("{0,3}{1,12}{2,12}{3,9}",X,(int)X,Convert.ToString(X,8),Convert.ToString(X,16));
                X++;
            }         
        }
    }
}
