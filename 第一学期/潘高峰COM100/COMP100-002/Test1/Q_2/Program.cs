using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #2 Winter 2018        =========================
 * 
 * Name:Gaofeng Pan
 * Student ID:300973143
 *
 * Question 2c.
 * 10 Marks.
 *
 * Write a program that subtract the user input from a target. When the target gets 
 * to zero or just becomes negative. The program prints the final target and the 
 * number of user inputs required
 * 
 * Type of loop-> do-while
 * [Solution: Question2C]
 -------------------------------------------------------------------------------- */


namespace Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter target value: ");
            double a = Convert.ToDouble(Console.ReadLine());
            int Counter=1;
            double b;
            do
            {
                Console.Write($"Enter #{Counter}: ");
                b = Convert.ToDouble(Console.ReadLine());
                a = a - b;
                Counter++;
            } while (a > 0);
            Console.Write($"It took {Counter-1} inputs to bring target to {a}");
        }
    }
}
