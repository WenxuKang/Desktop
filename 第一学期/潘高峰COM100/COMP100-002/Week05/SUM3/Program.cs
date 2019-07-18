using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.	To display the sum of all the multiples of 3 between 1000000 and 2000000. 
(Answer = 499, 999, 500, 000). If the sum might be larger than 2billion then the 
type of sum should be a long and not an int. 
[Hint: like the C (currency) and the  F (decimal) format specifiers, 
there is also a N specifier]

 */

namespace SUM3
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int counter = 1000000;
            do
            {if (counter % 3 == 0)
                { sum = sum + counter; }
                counter++;

            } while (counter<=2000000);
            Console.WriteLine("sum is: "+sum);
        }
    }
}
