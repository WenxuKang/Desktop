using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Server
    {
        protected List<string> duties;
        protected double wages;

        public string Name { get; }

        public Server(string name)

        {
            Name = name; wages = 14.95;

            duties = new List<string> { "11", "22", "33", "44", "55" };

        }
        public override string ToString()
        {
            return $"My name is {Name}, my wages is {wages:C}, my duties are:\n{string.Join(",", duties)}";
        }
    }

        class Superisor: Server

        {
            public Superisor(string name)
                :base("arrod")
            {
                wages = 18.25;
                duties.Add("Scheduling");
            }

        }
    }

