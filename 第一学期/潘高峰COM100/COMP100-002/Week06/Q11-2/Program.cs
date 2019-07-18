using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char X;
            char Y;
            Console.Write("Please enter a start character: ");
            X = Convert.ToChar(Console.ReadLine());
            Console.Write("Please enter a stop character: ");
            Y = Convert.ToChar(Console.ReadLine());
            if (X > Y)
            {
                for (; ; )
                {
                    Console.WriteLine("The second character should occur later in the alphabet than the first character.");
                    Console.Write("Please enter a stop character: ");
                    Y = Convert.ToChar(Console.ReadLine());
                    if (X <= Y)
                        break;
                }
            }
            Console.WriteLine("Letter     Decimal     Octal     Hex");
            for(;X<=Y;X++)
            {
                Console.WriteLine("{0,3}{1,12}{2,12}{3,9}", X, (int)X, Convert.ToString(X, 8), Convert.ToString(X, 16));
            }
        }
    }
}
