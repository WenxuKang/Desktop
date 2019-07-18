using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace sec006_2_COMP123_03
{
    class Tweet
    {
        //Field
        private static int currentId = 1;

        //Properties
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public string Hashtag { get; set; }

        //Constructor
        public Tweet(string from, string to, string message, string hashtag)
        {
            From = from;
            To = to;
            Message = message;
            Hashtag = hashtag;
            Id = currentId;
            currentId++;
        }

        //Override ToString() Method
        public override string ToString()
        {
            string partOfMessage = Message.Substring(0, Message.Length - 5);
            string tweetString = string.Format($"ID:{Id} form: {From} to: {To} message: {partOfMessage} hashtag: {Hashtag}");
            return tweetString;
        }

        //Parse Method
        public static Tweet Parse(string line)
        {
            Tweet newTweet;
            string[] tweet;
            try
            {
                tweet = line.Split(new char[] { '\t' });
                newTweet = new Tweet(from: tweet[0], to: tweet[1], message: tweet[2], hashtag: tweet[3]);
            }
            catch (IndexOutOfRangeException)
            {
                newTweet = new Tweet(from: "Invalid", to: "Invalid", message: "Invalid", hashtag: "Invalid");
            }
            return newTweet;
        }
    }
}
