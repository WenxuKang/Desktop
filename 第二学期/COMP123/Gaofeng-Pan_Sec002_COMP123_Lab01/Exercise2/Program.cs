using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write an app which contains the following function which makes use of variable number of arguments by use of params keyword:
a) private static int Addition(params int[] numbers) which returns the sum of three different numbers , 
four different numbers and five different numbers. So you need to call this method in the Main() according to above requirements.

b) private static void DisplayNames(params string[] names) which prints the one or two or three or four strings passed to it. 
Since it is of type params, you can pass any number of strings/names and it should be able to display it. 
So you need to call this method in the Main() according to above requirements.
 */

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            sum = Addition(2, 3, 4);
            Console.WriteLine("Sum of these numbers is: " + sum);
            sum = Addition(2, 3, 4, 5);
            Console.WriteLine("Sum of these numbers is: " + sum);
            sum = Addition(2, 3, 4, 5, 6);
            Console.WriteLine("Sum of these numbers is: " + sum);
            Console.WriteLine();

            DisplayNames("Centennial College\n");
            DisplayNames("Centennial College", "Software Technology\n");
            DisplayNames("Centennial College", "Software Technology", "Programming 2\n");
            DisplayNames("Centennial College", "Software Technology", "Programming 2", "Lohan\n");
            DisplayNames("Centennial College", "Software Technology", "Programming 2", "Lohan", "GOOD ClASS\n");
            DisplayNames("Centennial College", "Software Technology", "Programming 2", "Lohan", "GOOD ClASS", "Gaofeng Pan", "300973143", "FROM CHINA\n");
        }
        private static int Addition(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            return sum;
        }

        private static void DisplayNames(params string[] names)
        {
            foreach (string i in names)
                Console.WriteLine(i);
        }
    }
}
