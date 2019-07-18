using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	Write a program that prompts the user for the number of
 * courses and residency status (domestic or international) and 
 * calculates tuition cost. Cost is calculated based on the table below.
  Domestic	$325 per course
  International	$1375 per course
 *You decide how you want the user to enter her/his residency status
 *and prompt accordingly, also you should use named constants for the
 *cost per course
 */
namespace Q3_tuition_cost
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 courses;
            Int32 coursesCost;
            char stateus;
            Console.Write("Please enter your courses' amount: ");
            courses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your residency status(Domestic please enter\"D\";International please enter\"I\"): ");
            stateus = Convert.ToChar(Console .ReadLine ());
            switch (stateus)
            {
                case 'D':
                    coursesCost = 325 * courses;
                    Console.WriteLine("Your tuition cost is: $" + coursesCost);

                    break;
                case 'I':
                    coursesCost = 1375 * courses;
                    Console.WriteLine("Your tuition cost is: $" + coursesCost);
                    break;
                

                


            }


        }
    }
}
