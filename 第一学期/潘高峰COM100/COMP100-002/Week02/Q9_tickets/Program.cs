using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.	Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt 
 * the user for the amount of adult and child ticket that she needs. The program will 
 * display a user friendly message of the number of tickets brought as well as the total cost. 
 * (Use the "C" format-specifier for currency).
 */

namespace Q9_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int adultTicket;
            int childTicket;
            double totalMoney;
            Console.Write("How many adult tickets do you need: ");
            adultTicket = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many child tickets do you need: ");
            childTicket = Convert.ToInt32(Console.ReadLine());
            totalMoney = 3.75 * adultTicket + 2.25 * childTicket;
            Console.WriteLine("Your total cost of {0} adult tickets and {1} child tickets is {3:C}. ",adultTicket, childTicket ,totalMoney);
        }
    }
}
