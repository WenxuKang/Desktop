using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	Write a program for a furniture company.
 * Ask the user to choose Pine Oak or Mahogany. Show the price of 
 * a table manufactured with the chosen wood Pine tables 
 * cost $100, Oak tables cost $225, and Mahogany tables 
 * cost $310. Use named constants and switch.
 */

namespace Q5_furniture
{
    class Program
    {
        static void Main(string[] args)           
        {
            Console.WriteLine("Which kind of wood do you prefer?(Pine enter \"P\";Oak enter \"O\"; Mahogany enter \"M\")");
            char wood = Convert.ToChar(Console.ReadLine());
            switch(wood)
            {
                case 'P':
                    Console.WriteLine("Pine tables cost: $100.");
                    break;
                case 'O':
                    Console.WriteLine("Oak tables cost: $225.");
                    break;
                case 'M':
                    Console.WriteLine("Mahogany tables cost $310.");
                    break;

            }
        }
    }
}
