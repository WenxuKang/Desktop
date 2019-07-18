using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A confectionary store wants a program that will 
 * prompt the user for the price of the candy and 
 * the amount of money she would like to spend and 
 * then calculates and display the amount of candies 
 * that can be purchased. 
 */
namespace Q1_Candy
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double price, budget;
            //output
            double numberOfCandies;
            //processing
            //algorithm
            Console.Write("Enter price of candy: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is your budget: ");
            budget = Convert.ToDouble(Console.ReadLine());

            numberOfCandies = budget / price;
            Console.WriteLine($"You will get {numberOfCandies:n0} candies for {budget:c}");

        }
    }
}
