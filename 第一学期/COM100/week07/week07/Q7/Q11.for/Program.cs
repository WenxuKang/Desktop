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

 *
 */
namespace Q11.@for
{
    class Program
    {
        static void Main(string[] args)
        {
            char F;
            char S;
            int num1, octal, hex, num2;

            Console.Write("Please enter the first character: ");
            F = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter the second character: ");
            S = Convert.ToChar(Console.ReadLine());


            num1 = (int)F;
            num2 = (int)S;
            for (; num1 > num2;)
            {
                Console.WriteLine("Please enter the second character: ");
                S = Convert.ToChar(Console.ReadLine());
                num1 = (int)F;
                num2 = (int)S;
            }

            Console.WriteLine("Letter     Decimal          Octal         Hex");
            for (; num1<=num2; F++)
            {
                int e = 8;
                int h = 16;
                Console.WriteLine($"{F,2}{num1,13}{Convert.ToString(num1, e),17}{Convert.ToString(num1, h),13}");
                num1 = num1 + 1;
                F = (char)num1;
            }
        }
    }
}
