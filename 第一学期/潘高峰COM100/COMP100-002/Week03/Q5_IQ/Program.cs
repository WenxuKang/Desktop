using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	Write an application that asks a user to enter an IQ score. 
 * If the score is a number less than 0 or greater than 200, issue an error message; 
 * otherwise, issue an “above average”, “average”, or “below average”
 * message for scores over, at, or under 100, respectively
 */

namespace Q5_IQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int IQ;
            Console.Write("Enter IQ: ");
            IQ = Convert.ToInt32(Console.ReadLine());
            if (IQ < 0 || IQ > 200)                    
            {
                Console.WriteLine("ERROR");
            }
            if (IQ == 100)
            {
                Console.WriteLine("average");

            }
            if (IQ >=0 & IQ<100)
            {
                Console.WriteLine("below average");
            }
            if (IQ > 100 & IQ <= 200)
                Console.WriteLine("above average");

        }
    }
}
