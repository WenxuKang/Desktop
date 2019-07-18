using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program named PizzaPrices that prompts the user to make a choice for 
 * a pizza size -- Small, Medium, Large, or Extra large -- 
 * and then displays the price as $6.99, $8.99, $12.50, or $15.00, respectively
 */
namespace PizzaPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your pizza size: ");
            
            string size= Console.ReadLine();

                switch (size)
                {
                    case "Small":
                        Console.WriteLine($" The price as $6.99. ");
                        Console.WriteLine();
                        break;
                    case "Medium":
                        Console.WriteLine($"the price as $8.99");
                        Console.WriteLine();
                        break;
                    case "Large":
                        Console.WriteLine($"The price as $12.50");
                        Console.WriteLine();
                        break;
                    case "Extra Large":
                        Console.WriteLine($"The price as $15.00");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }

