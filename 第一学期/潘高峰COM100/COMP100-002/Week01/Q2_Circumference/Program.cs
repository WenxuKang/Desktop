using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Builders’s Inc. needs a program that allows its salesclerks to 
 * enter the diameter of a circle and the prices of railing material per foot.
 * The program should display the circumference of the circle 
 * and total cost of the railing material. 
 * (Use 3.14 as the value of pi). 
 * [You should use double instead of int32 for the number]
 */
namespace Q2_Circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            //output
            double circumference;
            double cost;
            //input
            double diameter;
            double price;
            //processing
            //algorithm
            Console.Write("Enter the diameter: ");
            diameter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price: ");
            price = Convert.ToDouble(Console.ReadLine());
            circumference = 3.14 * diameter;
            cost = circumference * price;
            Console.WriteLine("Circumference: "+circumference);
            Console.WriteLine("Cost: $"+cost);
        }
    }
}
