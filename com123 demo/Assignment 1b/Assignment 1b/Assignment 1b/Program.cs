using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nAll Tweets");
            TweetManager.ShowAll();
            // string tag = Console.ReadLine();
            //TweetManager.ShowAll(tag);
            string tag = "Raptors";
            Console.WriteLine($"\n\n{tag}");
            TweetManager.ShowAll(tag);
        }
    }
}
