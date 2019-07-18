using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Question 4a -> 10 marks
  * Solution   -> Question4a.exe
  * 
  * Name: Narendra Pershad
  * Date: 
  * 
  * Purpose: Write a program that prompts the user for the temperature
  * of the room. It will display the following message "Too cold",
  * Just right or "Too warm" according to the value entered. The
  * table below explains the logic 
  * 
  * under 19.5 -> Too cold
  * over 22.5 -> Too warm
  * overwise -> Just right
 */

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature of the room: ");
            double TEM = Convert.ToDouble(Console.ReadLine());
            if (TEM > 22.5)

            {
                Console.WriteLine("Too warm.");
            }
            else
                if (TEM < 19.5)
               {
                Console.WriteLine("Too cold.");

                }
                else
               {
                Console.WriteLine("Just right.");
                }

        }
    }
}
