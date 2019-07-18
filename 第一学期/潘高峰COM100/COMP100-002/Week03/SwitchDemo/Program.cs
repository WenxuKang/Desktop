using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a single letter: ");
            string letter = Console.ReadLine();
            switch (letter.ToUpper())
            {
                case "A":
                    Console.WriteLine("Very good");
                    break;
                case "B":
                case "C":
                    Console.WriteLine("Good");
                    break;                                
                case "D":
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("Work harder");
                    break;
            }
        }
    }
}
