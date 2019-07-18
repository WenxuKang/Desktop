using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A confectionary store wants a program that will prompt the user for 
 * the price of the candy and the amount of money she would like to spend and 
 * then calculates and display the amount of candies that can be purchased. 
 */
namespace Q1_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double price, budget;
            //processing
            //output
            int numberOfCandies;
            //algorithm
            Console.Write("Enter the price of a candy: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your budget: ");
            budget = Convert.ToDouble(Console.ReadLine());
            numberOfCandies = (int)(budget / price);
            Console.WriteLine("With {1:c}, you will get {2} {0:c} candies", 
                price, budget, numberOfCandies);
        }
    }
}
