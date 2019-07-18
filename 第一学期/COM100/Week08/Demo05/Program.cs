using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 75;
            const int ROWS = 21;
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    //if (c == r)
                    //if(c + r == 23 || c == r)
                    //if(c==0||r==0 || r == 20|| c == 74)
                    //if(c % 4 == 0 || r % 4 == 0)
                    if(r >= c)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("+");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
