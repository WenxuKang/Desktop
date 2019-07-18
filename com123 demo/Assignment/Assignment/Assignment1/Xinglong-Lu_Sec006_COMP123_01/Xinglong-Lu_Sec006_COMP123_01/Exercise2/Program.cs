using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition(1, 2, 3);
            Addition(1, 2, 3, 4);
            Addition(1, 2, 3, 4, 5);
            Console.WriteLine();
            string[] names = { "Leo", "Jay", "Kim" };
            DisplayNames("Jhon");
            DisplayNames("Jack", "Rose");
            DisplayNames(names);
            DisplayNames("Jack", "Rose", "Grace", "Finley");
        }
        private static int Addition(params int[] numbers)
        {
            int sum = 0;           
            foreach (int item in numbers)            
                sum = sum + item;            
            Console.WriteLine($"The sum is {sum}");
            return sum;
        }
        private static void DisplayNames(params string[] names)
        {
            foreach (string item in names)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
