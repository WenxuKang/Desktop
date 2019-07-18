using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_GrossPay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output
            int grossPay;
            //Input
            int rate;
            int hours;
            //Processing
            //Algorithm
            Console.WriteLine("Enter rate");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hours");
            hours = Convert.ToInt32(Console.ReadLine());
            grossPay = rate * hours;
            Console.WriteLine(grossPay);
        }
    }
}
