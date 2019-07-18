
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Student name: WENXU KANG   student id 300943385
//               Wen Ma   student ID: 300903179
namespace Assignment_1b
{
    class Tweet
    {
        private static int CURRENT_ID = 1;

        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public string Tag { get; set; }
        public string Id { get; set; }
        //Constructor
        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = Convert.ToString(CURRENT_ID++);
            // the CURRENT_ID is then incremented so that the next assignment will be unique.
        }
        public override string ToString()
        {
            // outputting only part of the Body
            return $"{Tag} {From} {To} {Body.Substring(0)}";
        }
        public static Tweet Parse(string line)
        {
            // // Use Split(new char[]{'\t'}); to chunck the input into four strings
            string[] tweet = line.Split(new char[] { '\t' });

            // Invokes the constructor with the five arguments
            Tweet newtweet = new Tweet(tweet[0], tweet[1], tweet[2], tweet[3], tweet[4]);

            //// Return the result of the above invocation
            return newtweet;
        }
    }
}
