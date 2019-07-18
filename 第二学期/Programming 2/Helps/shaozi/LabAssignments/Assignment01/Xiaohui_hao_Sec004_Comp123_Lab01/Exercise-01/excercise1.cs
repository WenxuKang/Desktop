using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class excercise1
    {
        static void Main(string[] args)
        {
            int x1 = 1, x2 = 2, x3 = 3;
            Console.WriteLine("The lagest of two numbers is:{0} ", MaxOfNumber(x1, x2));
            
          Console.WriteLine();
            Console.WriteLine("The lagest of three numbers is:{0} ", MaxOfNumber(x1,x2,x3));
            
        }

        private static int MaxOfNumber(int x1, int x2)
        {
            
          
            return(Math.Max(x1, x2));
            
        }
        
        private static int MaxOfNumber(int x1, int x2, int x3)
        {
           
            return(Math.Max(Math.Max(x1, x2), x3));
        }
    }
}
