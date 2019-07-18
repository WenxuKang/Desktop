using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Counter = 2;
            int Start = 2;
            while (Start <= 10) 
            {
                Console.Write(Start + " ");
                Start += Counter;
            }
        }
    }
}
