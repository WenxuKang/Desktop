using System;
/*
 * 1.	To display five asterisks on a single line. Each 
 * asterisk must be separated by a space. You must use a 
 * do-while loop to solve this program
 */

namespace Q01_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializer
            int counter = 0, stop = 5;
            do
            {
                //statements
                Console.Write("* ");
                //updater
                counter++;
            } while (counter < stop);//checker
        }
    }
}
