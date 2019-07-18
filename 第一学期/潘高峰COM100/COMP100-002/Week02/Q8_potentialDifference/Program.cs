using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Write a program to calculate and display the potential difference between the ends of a wire. 
 * The program will prompt the user for the current flowing and the resistance of the wire. 
 * (Potential difference is the product of the current and the resistance of the wire and may include a fractional part).
 */

namespace Q8_potentialDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            double potentialDifference;
            double currentFlowing;
            double resistance;
            Console.Write("Enter the current flowing: ");
            currentFlowing = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter resistance of the wire: ");
            resistance = Convert.ToDouble(Console.ReadLine());
            potentialDifference = currentFlowing * resistance;
            Console.WriteLine("The potential difference between the ends of wire is: {0}", potentialDifference);

        }
    }
}
