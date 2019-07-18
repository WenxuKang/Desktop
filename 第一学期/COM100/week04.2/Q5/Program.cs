using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.Write a program for a furniture company. Ask the user to choose Pine Oak or Mahogany. Show the price of a
 * table manufactured with the chosen wood Pine
 * tables cost $100, Oak tables cost $225, and 
 * Mahogany tables cost $310. Use named constants and switch.
 *
 */
namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which furniture you want choose: ");
            string furniture = Console.ReadLine();
            int Pine = 100;
            int Oak = 225;
            int Mahogany = 310;

            switch (furniture)
            {
                case "Pine":
                    Console.WriteLine("it cost {0:c}", Pine);
                    break;

                case "Oak":
                    Console.WriteLine("it cost {0:c]", Oak);
                    break;

                case "Mahogany":
                    Console.WriteLine("it cost {0:c}", Mahogany);
                    break;

            }
        }
    }
}
