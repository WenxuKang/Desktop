using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers If it is S, subtract the
 * second integer from the first else multiply 
 * the integers Display the results of the arithmetic
 *
 */
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter one integers: ");
            int intone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter another integers: ");
            int inttwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a character: ");
            char character = Convert.ToChar(Console.ReadLine());
            
            switch (character)
            {
                case 'A':
                    Console.WriteLine("The result is:{0},", intone + inttwo);
                    break;
                case 'S':
                    Console.WriteLine("The result is:{0},", intone + inttwo);
                    break;

                default:
                    Console.WriteLine("This result is illegal");
                    break;


            }

        }
    }
}
