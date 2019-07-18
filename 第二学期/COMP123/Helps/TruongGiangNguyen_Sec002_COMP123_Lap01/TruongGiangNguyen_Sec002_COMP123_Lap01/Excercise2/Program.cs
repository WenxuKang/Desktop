using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations & Initializations
            string[] strArray = {"Ontario", "Vancouver", "Quebec", "Alberta", "Nova Scotia"};
            int[] integerArray = {1, 2, 3, 4, 5};
            int result;
            //Print array elements
            foreach (int iValue in integerArray)
                Console.Write($"{iValue},\t");
            //Sum of two first numbers
            result = Addition(1, 2);
            Console.WriteLine($"\nSum of two integers: {result}");
            //Sum of first three numbers
            result = Addition(1, 2, 3);
            Console.WriteLine($"Sum of three integers: {result}");
            //Sum of first four numbers
            result = Addition(1, 2, 3, 4);
            Console.WriteLine($"Sum of four integers: {result}");
            //Display Province Name
            DisplayName("Ontario", "Vancouver");
            DisplayName("Ontario", "Vancouver", "Nova Scotia", "Newfoundland");
        }
        private static int Addition(params int[] iArray)
        {
            int total = 0;
            foreach (int iNum in iArray)
                total += iNum;
            return total;
        }
        private static void DisplayName(params string[] names)
        {
            foreach (string sName in names)
                Console.Write($"{sName}, ");
            Console.WriteLine();
        }
    }
}
