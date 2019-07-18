
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_1b
{
    class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME = "test.txt";
        static TweetManager()
        {
            // Initialize the tweets field to a new list of tweets
            TWEETS = new List<Tweet>();
            //Opens the file specified by the filename field for reading
            StreamReader reader = new StreamReader(FILENAME);
            //Reads one line from the file
            string input = reader.ReadLine();

            while (input != null)
            {
                //Passes this line to the static Parse() method of the Tweet class to create a tweet object
                TWEETS.Add(Tweet.Parse(input));
                //The resulting object is added to the tweet collectio
                input = reader.ReadLine();
            }
            reader.Close();
        }
        public static void Initialize()
        {
            //Creates about 5 tweets objects and add them to the tweet collection
            Tweet new1 = new Tweet("Koma", "Chogath", "Bascketball", "Welldone!", "11111");
            Tweet new2 = new Tweet("Jim", "Tomas", "Hi", "Hey, bro", "22222");
            Tweet new3 = new Tweet("Kobe", "Braint", "Bascketball", "Miracle!", "33333");
            Tweet new4 = new Tweet("Pink", "ball", "HAHA", "Comedy!", "44444");
            Tweet new5 = new Tweet("Matthew", "Chris", "Hockey", "I am the best", "55555");

            TWEETS.Add(new1);
            TWEETS.Add(new2);
            TWEETS.Add(new3);
            TWEETS.Add(new4);
            TWEETS.Add(new5);

        }
        public static void ShowAll()
        {
            for (int i = 0; i < TWEETS.Count; i++)
            {
                Console.WriteLine(TWEETS[i]);
            }
        }

        public static void ShowAll(string tag)
        {

            for (int i = 0; i < TWEETS.Count; i++)
            {
                // It displays all the tweets with tag matching the argument
                if (TWEETS[i].Tag == "Raptors")
                {
                    Console.WriteLine(TWEETS[i]);
                }
            }
        }
    }
}
