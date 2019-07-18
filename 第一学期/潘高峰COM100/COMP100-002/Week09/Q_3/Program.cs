using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	Write a method that takes an argument (a string array) and print each item on a single line separated by a space. 
 * From your main, call this method with poem as argument
 */

namespace Q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();
            int j = 0;
            do
            {
                Console.Write(poem[j] + " ");
                j++;
            } while (j < poem.Length);
        }
    }
}
