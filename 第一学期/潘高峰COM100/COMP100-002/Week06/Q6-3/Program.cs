using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Cel;
            double Start;
            double End;
            double Counter;
            Console.Write("Please Enter the starting Fahrenheit value: ");
            Start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter the ending Fahrenheit value: ");
            End = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter the increment of Fahrenheit value: ");
            Counter = Convert.ToDouble(Console.ReadLine());
            for (; Start <= End; Start = Start + Counter)
            {
                Console.Write("Fahrenheit: " + Start);
                Cel = (Start - 32) * 5 / 9;
                Console.WriteLine(" Celsius: " + Cel);
            }
        }
    }
}
