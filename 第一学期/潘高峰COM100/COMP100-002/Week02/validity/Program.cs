using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.Write a program to ask the user about the validity of a simple statement. 
 * The program should accept the response then display the statement as well as the response.
 *  The response should be true or false. For this question, 
 *  you must use a variable of type bool.
 */

namespace validity
{
    class Program
    {
        static void Main(string[] args)
        {
            bool statement;
            Console.Write("Enter your validity of a statement: ");
            statement = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your validity of this statement is "+ statement);
            
        }
    }
}
