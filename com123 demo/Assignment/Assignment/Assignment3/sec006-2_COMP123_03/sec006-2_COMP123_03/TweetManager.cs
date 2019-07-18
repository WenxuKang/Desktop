using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace sec006_2_COMP123_03
{
    class TweetManager
    {
        //Fields
        private static Tweet[] tweets;
        private static string fileName = "tweets.txt";

        //Static constructor
        static TweetManager()
        {

            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            int lineNumber = File.ReadLines(fileName).Count();
            tweets = new Tweet[lineNumber];
            for (int i = 0; i < tweets.Length; i++)
            {
                string record = streamReader.ReadLine();
                while (record != null)
                {
                    tweets[i] = Tweet.Parse(record);
                    break;
                }
            }
            streamReader.Close();
            fileStream.Close();
        }

        //ShowAll() Method
        public static void ShowAll()
        {
            for (int i = 0; i < tweets.Length; i++)
            {
                Console.WriteLine(tweets[i].ToString());
                Console.WriteLine();
            }
        }

        //Overload ShowAll() Method
        public static void ShowAll(string hashtag)
        {
            for (int i = 0; i < tweets.Length; i++)
            {
                if (hashtag == tweets[i].Hashtag)
                {
                    Console.WriteLine(tweets[i].ToString());
                }
            }
        }

        //Create a Json file
        public static void ConvertToJson()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            FileStream fileStream = new FileStream("tweets.json", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(serializer.Serialize(tweets));
            streamWriter.Close();
            fileStream.Close();

            bool tweetsOfJson = File.Exists("tweets.json");
            Console.WriteLine($"If tweets.json exists? {tweetsOfJson}");
            Console.WriteLine("Converted successfully!");
        }
    }
}
