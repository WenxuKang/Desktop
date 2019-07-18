using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalrevision
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        #region Q_01
        /*1.	Write a method called DisplayPersonalInfo(). 
         * This method will display your name, school, program and your favorite course. 
         * Call the DisplayPersonalInfo() method from your program Main() method
         */

        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Name: Wenxu Kang");
            Console.WriteLine("School: Centennial College");
            Console.WriteLine("Program: Software Engineering Technology");
            Console.WriteLine("Favorite course: Programming I");
        }
        #endregion
        #region Q_02
        /*2.	Write a method called CalculateTuition(). 
         * This method will prompt the user for the number of courses 
         * that she is currently taking and then calculate and display the tuition cost. 
         * (cost = number of course * 569.99). 
         * Call the CalculateTuition() method two times from the same Main() method as in question 1.
         */
        static void CalculateTuition()
        {
            Console.Write("Please enter how many courses you have: ");
            Console.WriteLine($"Your tuition is {569.99 * Convert.ToDouble(Console.ReadLine()):c}");
        }
        #endregion
        #region Q_03
        /*3.	Write a method call CalculateAreaOfCircle(). 
         * This method will prompt the user for the radius of a circle and then calculate and display the area.[A = πr2]. 
         * Call the CalculateAreaOfCircle() method twice from the same Main() method as in question 
         * 1. Use Math.Pi for the value of π
         */
        static void CalculateAreaOfCircle()
        {
            Console.Write("Please enter the radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of this circle is {Math.PI * r * r:f}");
        }
        #endregion
        #region Q_04
        /*	Write a method call CalculateAreaOfTriangle(), 
         *	that prompts the user for the base and height of a triangle and then calculate and display the area.
         *	[ A=bt/2 ] 
         *	Call the CalculateAreaOfTriangle() method twice from the same Main() method as in question 1.
         */
        static void CalculateAreaOfTriangle()
        {
            Console.Write("Please enter the base of a triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the height of a triangle: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of this triangle is {0.5 * b * h:f}");
        }
        #endregion
        #region Q_05
        /*5.	Write a method call CalculateSaleCommission(), 
         * that prompts the user for his sales figure, and then calculate and display his commission. 
         * (commission = 25% of sales in excess of 1000. If sales is equal to or below $1000.00 there is no commission) 
         * Call the CalculateSaleCommission() method three times from the same Main() method as in question 1.
         */
        static void CalculateSaleCommission()
        {
            Console.Write("Please enter your sales figure: ");
            double figure = Convert.ToDouble(Console.ReadLine());
            double commission;
            if (figure <= 1000)
            {
                commission = 0;
            }
            else
            {
                commission = 0.25 * (figure - 1000);
            }
            Console.WriteLine($"Your commission is {commission:c}");
        }
        #endregion
        #region Q_06
        /*6.	Write mthod call DisplaySineTable(), that prompts the user for a starting value and an step size. 
         * The method will calculate and display a table (10 rows) of sine values based on the user input. 
         * Use the built-in method Math.Sin() to obtain the sine of an angle. e.g. 
         * if the starting value is 0.5 and the step size is 0.03 the method will display the following table:
         * 0.50	0.4794
         * 0.53	0.5055
         * 0.56	0.5311
         * 
         * 0.77	0.6961
         * The numbers in both columns MUST be right aligned. 
         * Call the DisplaySineTable() method from the same Main() method as in question 1.
         */

        static void DisplaySineTable()
        {
            Console.Write("Please enter a starting value: ");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter a step size: ");
            double step = Convert.ToDouble(Console.ReadLine());
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("{0:f2}{1,7:f4}", start, Math.Sin(start));
                counter++;
                start += step;
            }
        }
        #endregion
        #region Q_07
        /*7.	In a write a method called DisplayMenu() to display the following text on screen:
=============Narendra’s Computer Systems==================
|         1. Display Personal Information                |
|         2. Calculate Tuition                           |
|         3. Calculate Area Of A Circle                  |
|         4. Calculate The Area Of A Triangle            |
|         5. Calculate Sales Commission                  |
|         6. Display Sine Table                          |
|         0. End program                                 |
|                                                        |
==========================================================
          Enter the number of your choice ->
You may replace the instructor’s name with your name.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("=============Wenxu’s Computer Systems==================");
            Console.WriteLine("|         1. Display Personal Information                |");
            Console.WriteLine("|         2. Calculate Tuition                           |");
            Console.WriteLine("|         3. Calculate Area Of A Circle                  |");
            Console.WriteLine("|         4. Calculate The Area Of A Triangle            |");
            Console.WriteLine("|         5. Calculate Sales Commission                  |");
            Console.WriteLine("|         6. Display Sine Table                          |");
            Console.WriteLine("|         0. End program                                 |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("==========================================================");
            Console.WriteLine("          Enter the number of your choice ->              ");
        }
        #endregion
        #region Q_08
        /*8.	Add another method called ShowMenu() to your project. 
         * This method will call the method in question 7 continuously until the user presses 0. 
         * (You will have to invoke the method in a loop body, read in the user input as well as check the input). 
         * You will need to hook up all the methods that you wrote previously i.e. questions 1 to 6. 
         * Remove all the code from your Main() method and add a single call to the ShowMenu() method.
         */
        static void ShowMenu()
        {
            for (; ; )
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayPersonalInfo();
                        break;
                    case "2":
                        CalculateTuition();
                        break;
                    case "3":
                        CalculateAreaOfCircle();
                        break;
                    case "4":
                        CalculateAreaOfTriangle();
                        break;
                    case "5":
                        CalculateSaleCommission();
                        break;
                    case "6":
                        DisplaySineTable();
                        break;
                }
                if (choice == "0")
                    break;
                Console.WriteLine();
            }
        }
        #endregion
    }
}


