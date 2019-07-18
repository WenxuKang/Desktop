using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	Write an application that asks a user to enter an IQ score.
 *  If the score is a number less than 0 or greater than 200,
 *  issue an error message; otherwise, issue an “above average”, 
 *  “average”, or “below average” message for scores over, at,
 *   or under 100, respectively
 *
 */
namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the IQ number:");
            double IQ = Convert.ToDouble(Console.ReadLine());
            if (IQ > 200 || IQ < 0)
                Console.WriteLine("you get the error meesage");
            if (IQ > 100 && IQ < 200)
                Console.WriteLine("your IQ is over average");
            if (IQ < 100 && IQ > 0)
                Console.WriteLine("your IQ is under average");
            if (IQ == 100)
                Console.WriteLine("your IQ is average");
        }
    }
}
