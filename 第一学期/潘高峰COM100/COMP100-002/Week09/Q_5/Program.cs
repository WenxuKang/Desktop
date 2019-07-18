using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	In your main method use the method in question 3 to display the poem array, 
 *then use the Array.Sort() method to sort the poem array and then again call the appropriate method to print it
 */

namespace Q_5
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
            Console.WriteLine();

            Array.Sort(poem);

            j = 0;
            do
            {
                Console.Write(poem[j] + " ");
                j++;
            } while (j < poem.Length);
        }
    }
}
