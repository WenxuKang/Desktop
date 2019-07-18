using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPersonalInformation();
            Console.Write("Enter the price of the item: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double cost = CalculateSellingPrice(2);
            Console.WriteLine($"An item of price{cost:c}will cost {cost:c}");
        }
        #region Q2
        /*
         * Write a method that take the price of
         * an item and calculates and return the
         * selling price(add 13% to the price)
         *
         * In your main method, promot the user
         * for the price of an item. then call this 
         * method and display the resulting cost
         */
         static double CalculateSellingPrice(double price)
        {
            return price * 1.13;

        }
        #endregion
        #region Q1 
        /*
         *Write a method to display your personal information
         *
         */
        static void DisplayPersonalInformation()
        {
            Console.WriteLine("Wenxu Kang");
            Console.WriteLine("Centennial College");
            Console.WriteLine("941 Progress Ave");
            Console.WriteLine("Scarborough");
            #endregion
        }

    }
}
