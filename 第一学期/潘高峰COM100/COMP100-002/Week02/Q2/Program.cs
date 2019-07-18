using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*When Jacob Steinberg began his trip to California, he filled his car’s tank with gas and reset his trip meter to zero. 
 * After traveling some distance (324 miles), Jacob stopped at a gas station to refuel; the gas tank required fuel (17 gallon). 
 * Create a program that Jacob can use to display his car gas mileage – the number of miles his can be driven per gallon of gas. 
 */
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double distance, consumption;
            //processing
            //output
            double pergallonDistance;
            //algorithm
            Console.Write("Enter the distance: ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the gas consumption: ");
            consumption = Convert.ToDouble(Console.ReadLine());
            pergallonDistance = distance / consumption;
            Console.WriteLine("You can drive "+pergallonDistance+" miles per gallon of gas.");       

        }
    }
}
