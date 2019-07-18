﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1.	Create a program that prompts the user 
 * for her first name, middle initial and 
 * last name. The program will display the 
 * user name three times using the following
 *  three formats: 
 *  first name and last name
 *  first name middle initial and last name
 *  last name, first name and middle initial
 *  For inputs Barack H Obama
 *  
 *  Barack Obama
 *  Barack H Obama
 *  Obama, Barack H
 */
namespace Q1_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();

            Console.Write("Enter your middle initial: ");
            string mName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine($"{fName} {lName}");
            Console.WriteLine($"{fName} {mName} {lName}");
            Console.WriteLine($"{lName}, {fName} {mName}");
        }
    }
}
