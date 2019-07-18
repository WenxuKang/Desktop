using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	To display the numbers 1 … 20 on separate lines
 */

namespace Q3_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1, stop = 21;
            do
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            while (counter < stop);
        }
    }
}
