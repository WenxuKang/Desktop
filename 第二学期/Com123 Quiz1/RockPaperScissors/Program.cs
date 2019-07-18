using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void games()
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                              RockPaperScissors                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Game rule：1→Rock，2→Scissors，3→Paper");
        }
        static void Main(string[] args)
        {
            games();
            Random random = new Random();

            string str = "";
            bool flag = true;
            int i = 1;
            int j = 0;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Please enter the number (q→quit)：");
                    str = Console.ReadLine();
                    if (str == "q")
                    {
                        Console.WriteLine("when you enter q，program will quit.");
                        flag = false;
                    }
                    int number = random.Next(1, 4);
                    int input = Convert.ToInt32(str);
                    if (input == 1)
                    {
                        
                        if (number == 1)
                        {
                            Console.WriteLine("User write\"rock\"→computer write\"rock\"");
                            Console.WriteLine("result is a tie!");
                        }
                        else if (number == 2)
                        {
                            Console.WriteLine("User write\"rock\"→computer write\"scissors\"");
                            Console.WriteLine("you win!");
                        }
                        else
                        {
                            Console.WriteLine("User write\"rock\"→computer write\"paper\"");
                            Console.WriteLine("you lose!");
                        }
                        j++;
                    }
                    else if (input == 2)
                    {
                       
                        if (number == 1)
                        {
                            Console.WriteLine("User write\"scissors\"→computer write\"rock\"");
                            Console.WriteLine("you lose!");
                        }
                        else if (number == 2)
                        {
                            Console.WriteLine("users write\"scissors\"→computer write\"scissors\"");
                            Console.WriteLine("result is a tie!");
                        }
                        else
                        {
                            Console.WriteLine("Users write\"scissors\"→computer write\"paper\"");
                            Console.WriteLine("you win!");
                        }
                        j++;
                    }
                    else if (input == 3)
                    {
                 
                        if (number == 1)
                        {
                            Console.WriteLine("Users write\"paper\"→computer write\"rock\"");
                            Console.WriteLine("you win!");
                        }
                        else if (number == 2)
                        {
                            Console.WriteLine("users write\"paper\"→computer write\"scissors\"");
                            Console.WriteLine("you lose!");
                        }
                        else
                        {
                            Console.WriteLine("Users write\"paper\"→computer write\"paper\"");
                            Console.WriteLine("result is a tie!");
                        }
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Error!!!");
                    }
                    if (j % 5 == 0)
                    {
                        Console.WriteLine("Do you want clear the screen(y→clear)?");
                        str = Console.ReadLine();
                        if (str == "y")
                        {
                            Console.Clear();
                            games();
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                catch
                {
                    i++;
                    if (i > 3)
                    {
                        Console.WriteLine("You write wrong code 3 times ，game over!");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid code, please write it again!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
