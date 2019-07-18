using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/** Question 6 -> 20 marks
  * Solution   -> Question6a.exe
  * 
  * Name: Narendra Pershad
  * Date: 
  * 
  * Purpose: Write a program that prompt the user to enter the type (domestic or foreign) 
  *          and number of plates that he would like to order.
  *          The program will accept both inputs and calculate and display the cost of the order. 
  *          The calculation is done according to the  table below:
  * 
  * For domestic cuisine and more than 100 plates -> 34.95 per plate
  * For domestic cuisine and up to 100 plates     -> 39.95 per plate
  * For foreign cuisine and more than 100 plates  -> 44.95 per plate
  * For foreign cuisine and up to 100 plates      -> 54.95 per plate
  * 
  * To get maximum marks for this question you MUST use the following:
  * 1) a nested if-else structure
  * 2) for foreign cuisine you must check for both "F" and "f" (you don't need to check 
  *    for domestic)        
 */

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of plates you want: ");
            Int32 amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the type of plates you want(domestic please enter \"D\", foreigh please enter\"F\"): ");
            Char type = Convert.ToChar(Console.ReadLine());
            double perplateCost = 0;
            if (amount > 100)
            {
                switch (type)
                {
                    case 'D':
                    case 'd':
                        perplateCost = 34.95;
                        break;
                    case 'f':
                    case 'F':
                        perplateCost = 44.95;
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case 'D':
                    case 'd':
                        perplateCost = 39.95;
                        break;
                    case 'f':
                    case 'F':
                        perplateCost = 54.95;
                        break;
                }
            }
            double totalCost = amount * perplateCost;
            Console.WriteLine("The cost of the order is: {0:c}",totalCost);
        }
    }
}
