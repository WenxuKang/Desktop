using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*12.	Write a program to reverse the digits of a positive integer number. 
 * For example, if the number 8735 is entered, the number displayed should be 5378. 
 * (Hint: Use a do statement and continuously strip off and display the units digit of the number. 
 * If the variable num initially contains the number entered, the units digit is obtained as (num % 10). 
 * After a units digit is displayed, dividing the number by 10 sets up the number for the next iteration.
 * Thus, (8735 % 10) is5and (8735 / 10) is 873. The do statement should continue as long as the remaining number is not zero).
 */

namespace Q12_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please enter a positive integer number: ");
             int X = Convert.ToInt32(Console.ReadLine());
             int A;
             do
             {
                 A = X % 10;
                 X = X / 10;
                 Console.Write(A);
             } while (X>0);

        }
    }
}
