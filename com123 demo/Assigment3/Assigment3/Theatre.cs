using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
    public class Theatre
    {
        private List<Show> Shows;
        public string Name { get; }

        public Theatre(string name)
        {
            Name = name;
            Shows = new List<Show>();
            Show show1 = new Show(new Movie("Raptors", 2019, 0617), Day.Mon, 114.00, new Time(1, 1, 4));
            Shows.Add(show1);
            Show show2 = new Show(new Movie("Warriors", 2019, 0616), Day.Sun, 110.00, new Time(1, 1, 0));
            Shows.Add(show2);
        }

        public void AddShow(Show show)
        {
            Shows.Add(show);

            Console.WriteLine((Shows.Count));
        }

        public void PrintShows()
        {
            Console.WriteLine(Name);
            foreach (Show x in Shows)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(Shows.Count);
        }

        public void PrintShows(Genre genre)
        {
            Console.WriteLine(Name);
            foreach (Show x in Shows)
            {
                if (x.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(x);
                }
                else
                {

                }
            }


        }

        public void PrintShows(Day day)
        {
            Console.WriteLine(Name);
            foreach (Show x in Shows)
            {
                if (x.Day == day)
                {
                    Console.WriteLine(x);
                }


            }
            Console.WriteLine(Shows.Count);
        }

        public void PrintShows(Time time)
        {
            Console.WriteLine(Name);
            foreach (Show x in Shows)
            {
                if (x.Time == time)
                {
                    Console.WriteLine(x);
                }
            }

        }

        public void PrintShows(string actor)
        {
            Console.WriteLine(Name);
            foreach (Show x in Shows)
            {
                if (x.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine(Shows.Count);
        }

        public void PrintShows(Day day, Time time)
        {
            Console.WriteLine(Name);
            int number = 0;
            foreach (Show x in Shows)
            {
                if (x.Day == day && x.Time == time)
                {
                    number++;
                    Console.WriteLine(x);
                }
            }


            Console.WriteLine("A numbered list of the movies displayed is {0}\n", number);



        }

    }
}