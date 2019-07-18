using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace sec006_2_COMP123_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoke ShowAll() Method
            TweetManager.ShowAll();

            //Invoke ShowAll() Method With argument
            Console.WriteLine("Please enter a hashtag: ");
            string hashtag = Console.ReadLine();
            TweetManager.ShowAll(hashtag);

            //Invoke ConvertToJson() Method
            Console.WriteLine();
            TweetManager.ConvertToJson();

            Console.ReadKey();
        }
    }
}
