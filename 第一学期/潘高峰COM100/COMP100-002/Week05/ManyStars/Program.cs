using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyStars
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row=1 ; row<10 ; row++)
            {
                for(int col=1 ; col<10 ; col++)
                {
                    if(row+col>=6 && row+col<=14 && col-row<=4 && col-row>=-4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
