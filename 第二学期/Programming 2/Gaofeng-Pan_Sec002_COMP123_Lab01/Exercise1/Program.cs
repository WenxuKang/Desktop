using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write an app which contains the following two overloaded functions:
a) private static int Maximum(int, int) which returns the largest of two numbers
b) private static int Maximum(int, int, int) which returns the largest of three numbers
c) private static int Square(int) which returns square of an integer value
d) private static double Square(double) which returns square of a double value
 */

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Please enter two or three integer numbers(first one): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter two or three integer numbers(second one): ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max: " + Maximum(x, y));
            Console.WriteLine("Please enter two or three integer numbers(third one): ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max: " + Maximum(x, y, z));

            int m;
            Console.WriteLine("Please enter one integer number: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square: " + Square(m));

            double n;
            Console.WriteLine("Please enter one double number: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square: " + Square(n));
        }
        private static int Maximum(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        private static int Maximum(int num1, int num2, int num3)
        {
            int temp;
            if (num1 > num2)
                temp = num1;
            else
                temp = num2;
            if (temp > num3)
                return temp;
            else
                return num3;
        }
        private static int Square(int square)
        {
            return (int)Math.Pow(square, 2);
        }
        private static double Square(double square)
        {
            return Math.Pow(square, 2);
        }
    }
}
