using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for a name , 
 * Social Insurance Number, hourly pay rate and the 
 * number of hours worked. In an attractive format 
 * display all the input data as well as the following:
Gross pay is hourly pay rate times hours worked
Federal tax is 15 percent of gross pay
Provincial tax is 10 percent of gross pay
Net pay is gross minus federal and provincial taxes


Enter your name: Stephen Harper
Social Insurance Number: 123-456-789
Hourly pay rate: 11:50
Hours worked: 40
Payroll Summary for Stephen Harper
SIN: 123-456-789
You worked 40 hours at $11.50 per hour
Gross pay:                       $460.00
Federal Tax:                      $69.00
Provincial Tax:                   $46.00
----------------------------------------
Net pay:                         $345.00

To get the table at the bottom, you will need to ensure the lines with the dollar value end at the same column then use a column indicator with the placeholder. {«data value»,«number of columns to utilize»:«format specifier»}
e.g. {grossPay, 8:C} means put the second data value, display in currency format and occupy 8 columns

 */
namespace Q2_NetPay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Social Insurance Number: ");
            string sin = Console.ReadLine();
            Console.Write("Hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Payroll Summary for {name}");
            Console.WriteLine($"SIN: {sin}");
            Console.WriteLine($"You worked {hours} hours at {rate:C} per hour");

            double grossPay = hours * rate;
            double federalTax = grossPay * 0.15;
            double provincialTax = grossPay * 0.1;
            double netPay = grossPay - federalTax - provincialTax;

            Console.WriteLine($"Gross pay:      {grossPay,8:C}");
            Console.WriteLine($"Federal Tax:    {federalTax,8:C}");
            Console.WriteLine($"Provincial Tax: {provincialTax,8:C}");
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Net pay:        {netPay,8:C}");
        }
    }
}
