using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  * Question 2a -> 14 marks
  * Solution   -> Question2a.exe
  * 
  * Name: Narendra Pershad
  * Date: 
  * 
  * Purpose: Write a program that prompts the user for his name, annual salary,
  *          and monthly expenses. The program will display the user's name, MONTHLY salary
  *          monthly expenses and extra money.
  * 
  * extra money = income - expenses
  * monthly salary = annual salary / 12
  * 
  * Use the "c" is your format specifier to display a number as a currency
 */

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your annual salary: ");
            double annualSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your monthly expenses: ");
            double monthlyExpenses = Convert.ToDouble(Console.ReadLine());          
            double monthlySalary = annualSalary / 12;
            double extraMoney = monthlySalary - monthlyExpenses;

            Console.WriteLine("Hi,{0}, with a monthly salary of {1:c} and expenses of {2:c}, you will have {3:c} of spending money", name , monthlySalary , monthlyExpenses , extraMoney );
        }
    }
}
