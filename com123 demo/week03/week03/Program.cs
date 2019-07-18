using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week03
{

    enum Day { Mon, Tue, Wed, Thur, Fri, Sat, Sun }
    [Flags]
    enum Genre {  Home = 0, Comedy = 1, Action = 2 , Decumentary = 4, Sci_Fi = 16, Romance = 16, Adult = 32}
    class Program
    {
        static void Main(string[] args)
        {
            GenreDemo();
        }

        static void GenreDemo()
        {
            Genre genre = Genre.Action;
            Console.WriteLine($"->{genre}");
            if (genre == Genre.Action)
                Console.WriteLine("ACTION");
            else
                Console.WriteLine("not action");

            genre = Genre.Comedy | Genre.Romance | Genre.Action;
            Console.WriteLine($"->{genre}");

            if (genre.HasFlag(Genre.Action))
                Console.WriteLine("ACTION");
            else
                Console.WriteLine("not action");
        }

        static void DayDemo()
        {
            Day today = Day.Wed;
            Console.WriteLine($"Today: {today}");

            today += 1;
            Console.WriteLine($"Today: {today}");

            Console.Write("Enter a day: ");
            string input = Console.ReadLine();
            today = (Day)Enum.Parse(typeof(Day), input);
            Console.WriteLine($"Today:{today}");

        }


    }
}
