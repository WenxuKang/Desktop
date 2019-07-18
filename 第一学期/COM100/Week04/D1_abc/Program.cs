using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_abc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            string letter = Console.ReadLine();
            switch (letter)
            {
                case "a":
                    Console.WriteLine("Apple");
                    break;
                case "b":
                case "c":
                    Console.WriteLine("Baby or Candy");
                    break;
                default:
                    Console.WriteLine("Sorry I don't know that letter!");
                    break;
            }
        }
    }
}
