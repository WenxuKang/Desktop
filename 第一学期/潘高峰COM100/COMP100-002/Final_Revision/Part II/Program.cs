using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_II
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHorizontalStars(0);
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
            DisplayVerticalStars(0);
            DisplayVerticalStars(5);
            DisplayVerticalStars(10);
            DisplayVolumeofSphere(1);
            DisplayVolumeofSphere(2);
            DisplayVolumeofSphere(10);
            DisplaySellingPrice(1000, "ON");
            DisplaySellingPrice(3000, "QC");
            DisplaySellingPrice(5000, "BC");
            DisplayConversionTable(0);
            DisplayConversionTable(90);
            KMtoMIConversionTable(0, 10, 10);
            KMtoMIConversionTable(50, 5, 5);
            KMtoMIConversionTable(100, 20, 20);
            DisplaySineTable(0.5, 0.03, 10);
            ConvertCMtoM(90);
            ConvertCMtoM(120);
            ConvertCMtoM(275);
        }
        #region Q_01
        /*Write a method called DisplayHorizontalStars(int numberOfStars). 
         * This method will output the number of stars horizontally specified by its argument. 
         * Call the DisplayHorizontalStars() method three times from your program Main() method, 
         * supplying 0, 5 and 10 respectively for the number of stars.
         */
         static void DisplayHorizontalStars(int numberOfStars)
        {
            for(int i = 0 ; i < numberOfStars ; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
        #region Q_02
        /*2.	Write a method similar to the one above that displays a vertical line of stars. 
         * Call this method three times with arguments 0, 5 and 10 respectively.
         */
         static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
        #region Q_03
        /*	Write a method that accepts an argument of type double. 
         *	The method will calculate and display the volume of a sphere with radius specified by its argument. 
         *	[V=4/3  πr^3]. 
         *	Call this method from your main three times, with arguments 1, 2, and 10 respectively. 
         *	The answers are 4.1888, 33.5103 and 4188.7902 respectively.
         *	Use Math.PI for the value of π
         */
         static void DisplayVolumeofSphere(double radius)
        {
            double volume = (double)4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Volume is {volume:f4}.");
            Console.WriteLine();
        }
        #endregion
        #region Q_04
        /*4.	Write a method that takes two arguments: a cost price and a two letter province code. 
         * It will calculate and display the selling price. 
         * (If province is Ontario a tax of 13% is added to the price, 
         * if the province is Quebec a tax of 17% is added to the cost price. 
         * There is no tax for the rest of the provinces and territories). 
         * In your main, call this method enough times to fully test it
         */
         static void DisplaySellingPrice(double costPrice,string province)
        {
            double sellPrice;
            if(province=="ON")
            {
                sellPrice = costPrice * 1.13;
            }
            else if(province=="QC")
            {
                sellPrice = costPrice * 1.17;
            }
            else
            {
                sellPrice = costPrice;
            }
            Console.WriteLine($"The selling price is {sellPrice:c}.");
            Console.WriteLine();
        }
        #endregion
        #region Q_05
        /*5.	Write a method that takes a single argument of type double. 
         * The will display a Celsius to Fahrenheit conversion table. 
         * The starting temperature is indicated by the argument 
         * and it will display 10 lines in increments of 1. [Farenheit = 9/5 Celsius + 32]. 
         * In your main call this method two times, each time with a different value.
         */
         static void DisplayConversionTable(double Celsius)
        {
            double Fahrenheit;
            for(int counter=0;counter<10;counter++)
            {
                Fahrenheit = 9.0 / 5 * Celsius + 32;
                Console.WriteLine($"{Celsius,10:f2}{Fahrenheit,20:f2}");
                Celsius++;
            }
            Console.WriteLine();
        }
        #endregion
        #region Q_06
        /*6.	Write a method that takes the following arguments: 
         * a starting km value of type double, an increment size of type double and the number of lines of type int. 
         * The display a kilometer to miles conversion table. [miles = km * 0.621371]. 
         * In your main call this method three times, each time with different values.
         */
         static void KMtoMIConversionTable(double km,double step,double line)
        {
            double mile;
            int i = 0;
                while(i<line)
            {
                mile = km * 0.621371;
                Console.WriteLine("{0,10:f}{1,20:f}", km, mile);
                km+=step;
                i++;
            }
            Console.WriteLine();
        }
        #endregion
        #region Q_07
        /*7.	Modify the DisplaySineTable() method in the previous section to accept the start value, 
         * the step size and number of rows as argument to the method.
         */
         static void DisplaySineTable(double start,double step,int row)
        {
            int counter = 0;
            while (counter < row)
            {
                Console.WriteLine("{0:f2}{1,7:f4}", start, Math.Sin(start));
                counter++;
                start += step;
            }
            Console.WriteLine();
        }
        #endregion
        #region Q_08
        /*8.	Write a method that converts a person’s height from centimeter to meters 
         * and centimeters and display the result on the console. 
         * In your main method, you should call this method three times with argument 90, 120 and 275. 
         * Input	Result
         * 90cm	    0m 90cm
         * 120cm	1m 20 cm
         * 275cm	2m 75cm
         */
         static void ConvertCMtoM(double cm)
        {
            double m;
            double remainder;
            m = (int)cm / 100;
            remainder = cm % 100;
            Console.WriteLine("Input      Result");
            Console.WriteLine($"{cm,3}cm     {m}m {remainder}cm");
            Console.WriteLine();
        }
        #endregion
    }
}
