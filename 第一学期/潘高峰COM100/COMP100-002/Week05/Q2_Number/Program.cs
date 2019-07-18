using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	To display the numbers 1 … 5 on separate lines
 */
namespace Q2_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1, stop = 6;
            do
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            while (counter<stop);
        }
    }
}
