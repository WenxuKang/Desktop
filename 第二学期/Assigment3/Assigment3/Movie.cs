using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
    public class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast { get; private set; }

        public Movie(string name, int year, int length)
        {
            Title = name;
            Year = year;
            Length = length;
            Cast = new List<string>() { "Tony", "Wen", "Mary", "Mark", "Ting" };


        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);

        }

        public void SetGenre(Genre genre)
        {
            Genre = genre;

        }

        public override string ToString()

        {
            string n = string.Join(",", Cast);
            return $"{Length} + {Year} + {Title} + {Genre}" + n;
        }


    }

}