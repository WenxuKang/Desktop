﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);

            Console.WriteLine($"{c0}");
            Console.WriteLine(c1);

            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

            //Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");

            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
            Console.WriteLine($"-{c0}->{-c0}");
        }



    }
}
