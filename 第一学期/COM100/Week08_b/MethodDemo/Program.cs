using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayPersonalInformation();
            Console.Write("Enter the price of the item: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double cost = CalculateSellingPrice(price);
            Console.WriteLine($"An item of price {price:C} will cost {cost:C}");
        }
        #region Q2 - calculate selling price
        /*
         * write a method that take the price of
         * an item and calculates and return the 
         * selling price (add 13% to the price)
         * 
         * In your main method, prompt the user
         * for the price of an item, then call
         * this method and display the resulting cost
         */
        static double CalculateSellingPrice(double price)
        {
            return price * 1.13;
        }
        #endregion

        #region Q1 - display personal info
        /*
         * Write a method to display your personal info
         */
        static void DisplayPersonalInformation()
        {
            Console.WriteLine("Narendra");
            Console.WriteLine("Centennial College");
            Console.WriteLine("941 Progress Ave");
            Console.WriteLine("Scarborough");
        }
        #endregion
    }
}
