using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	To display the numbers 1 … 20 on separate lines with an asterisk
 * after the multiples of 5. (multiples besides asterisk) 
 */

namespace Q4_Number3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1, stop = 21;
            do
            {
                if (counter % 5 == 0)
                { Console.WriteLine(counter+"*"); }
                else
                { Console.WriteLine(counter); }
                counter = counter + 1;              
            }
            while (counter < stop);
        }
    }
}
