using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingColors
{
    class Program
    {
        static void Main(string[] args)
        {          
            CreateBox(4,6,'+',ConsoleColor.White,ConsoleColor.Red);
            DrawBox(70,20);
        }
        static void DrawBox(int columns , int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (c % 4 == 0 || r % 4 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write(' ');
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write('+');
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.WriteLine();
            }
        }
        static void CreateBox(int columns ,int rows,char toPrint,ConsoleColor backColor,ConsoleColor foreColor)
        {
            for(int r=0; r< rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.BackgroundColor = backColor;
                    Console.ForegroundColor = foreColor;
                    Console.Write(toPrint);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
    }
}
