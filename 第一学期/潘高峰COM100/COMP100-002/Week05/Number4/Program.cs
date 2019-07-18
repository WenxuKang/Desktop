using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	To display the numbers 10 … 40 on separate lines with 
 * an asterisk before the multiples of 7. (asterisk besides multiples)
 */

namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10, stop = 41;
            do
            {
                if (counter % 7 == 0)
                { Console.Write("*"); }
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            while (counter < stop);  
        }
    }
}
