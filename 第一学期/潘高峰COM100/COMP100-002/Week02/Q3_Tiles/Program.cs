using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tile Limited wants a program allows its salesclerk to enter the length and 
 * width (in meters) of a rectangle and the price of a square meter of tile. 
 * The program should display the area of the rectangle and the total cost of the tile.
 */
namespace Q3_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double length, width, price;
            //processing
            double area;
            //output
            double cost;
            //algorithm
            Console.Write("Enter the length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the price of a square meter of tile: ");
            price = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            cost = area * price;
            Console.WriteLine("With{0:c}, you will get {1}m length, {2}m width, {3:c} per square meter tile.",
                cost, length, width, price);

        }
    }
}
