using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame(110, 8);
        }
        static void PlayGame(int target,int chances)
        //if chances are exceeded - print lost,stop game
        //prompt for input
        //read input
        //compare to target
        //if same - print win, stop game
        //if low - print too low
        //if high - print too high
        {
            for (int counter = 1; ; counter++)
            {
                if (counter == chances+1)
                {
                    Console.WriteLine("You lost.");
                    break;
                }
                else
                {
                    Console.Write($"Enter guess #{counter } of {chances}: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    if (a == target)
                    {
                        Console.WriteLine($"Exactly! You win. Use #{counter} times from {chances}.");
                        break;
                    }
                    else if (a < target)
                    {
                        Console.WriteLine("Too low.");
                    }
                    else
                    {
                        Console.WriteLine("Too high.");
                    }
                }
            }
        }
    }
}
