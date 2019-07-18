using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.	To display numbers 20 … 60 on separate lines skipping the multiple of 3. 
 * You must print a blank line for each multiple.
 */

namespace Q6_Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 20, stop = 61;
            do
            {
                if (counter % 3 == 0)
                { Console.WriteLine(" "); }
                else
                { Console.WriteLine(counter); }
                counter = counter + 1;
            }
            while (counter < stop);
        }
    }
}
