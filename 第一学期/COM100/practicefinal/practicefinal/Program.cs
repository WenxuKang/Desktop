using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefinal
{
    class Program
    {
        

        static void Main(string[] args)
        {


            string choice = "1";

            for (; choice != "X";)
            {
                Menu();
                choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "A":
                        DemoQuestion3();
                        break;
                    case "B":
                        DemoQuestion4();
                        break;
                    case "C":
                        DemoQuestion5();
                        break;
                    case "D":
                        DemoQuestion6();
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid response");
                        break;
                }
            }
        }





        #region Question 1 - 13 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * +---------------------COMP100------------------------+
         * |           a) Working with Newton's Law             |
         * |           b) Height Converter                      |
         * |           c) Sine and Cosine Table                 |
         * |           d) Number Frequency                      |
         * |                                                    |
         * |           x) To exit the program                   |
         * +----------------------------------------------------+
         * Press the letter corresponding to your choice-> 
         * 
         */
        static void Menu()
        {
            Console.WriteLine("|------------------Programming I-----Wenxu Kang------|");
            Console.WriteLine("|           a) Working with Newton's Law             |");
            Console.WriteLine("|           b) Height Converter                      |");
            Console.WriteLine("|           c) Sine and Cosine Table                 |");
            Console.WriteLine("|           d) Number Frequency                      |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           X. To exit the program                   |");
            Console.WriteLine("|----------------------------------------------------|");
        }
        #endregion


        #region Question 2 - 26 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call this method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following required functionality for all valid responses.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * A will call the DemoQuestion3() method
         * B will call the DemoQuestion4() method
         * C will call the DemoQuestion5() method
         * D will call the DemoQuestion6() method
         * X will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */
        #endregion

        #region Question 3 - 15 marks
        /*  CalculateGravitationalForce - 9 marks
         * 	“Newton's law of universal gravitation states that every point mass in the 
         * 	universe attracts every other point mass with a force that is directly 
         * 	proportional to the product of their masses and inversely proportional to 
         * 	the square of the distance between them.” 
         * 	
         * Write a method with the following specifications:
         * Name     : CalculateGravitationalAttraction
         * Parameter: 
         * 	          A double representing the mass of the first body
         * 	          A double representing the mas of the second body
         * 	          A double representing the distance between them. 
         * Returns  : double that represents the force of attraction between them
         * Displays : Nothing
         * Task     : Calculate and return the force of attraction between them. 
         * 	[F=G (m_1 m_2)/d^2  , where G = 6.673e-11]. 
         */
        static double CalculateGravitationalAttraction(double m_1, double m_2, double d, double F)
        {
            double G = 6.673e-11;
            F = G * (m_1 * m_2) / Math.Pow(d, 2);
            return F;
        }




        /* Driver for question 3 - 6 marks
         * 
         * Write the statements to call the above method with the masses of the earth, 
         * moon and the distance between them and display the resulting force. 
         * 
         * 	Mass of Earth = 5.972E24, moon = 7.348E22, Distance = 384,400,000m.
         * 	[Answer 1.99e020N]
         * 	You shoul use E as a format specifier in your output
         */
        static void DemoQuestion3()
        {

            Console.WriteLine("\n\n**********Begin Question 3 **********");

            double m_1;
            double m_2;
            double d;
            double F;
            m_1 = 5.972E24;
                Console.WriteLine("Mass of Earth ={0:f6}",m_1);
            m_2 = 7.348E22;

                Console.WriteLine("Moon ={0:f4}", m_2);
            d = 384400000;

            Console.WriteLine("Distance = {0:f6}",d);
            F= 1.99e020;
            Console.WriteLine("The force of attraction = {0:f6}", F);


            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        #endregion

        #region Question 4 - 10 marks
        /* Write a method with the following specifications: - 9 marks
         * Name     : HeightConversion
         * Parameter: an int representing the height value in cm
         * Returns  : Nothing
         * Displays : The appropriate meter and cm equivalent
         * Tasks: Converts the argument to metres and cm and display
         * it on the console. 
         */
        static void HeightConversion(double cm)
        {
            HeightConversion(75);
            HeightConversion(100);
            HeightConversion(290);

        }
        /* Driver for question 4 - 3 marks
         * Write the code to call the above method below three times
         * with argument 75, 100 and 290.
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            double cm=75;
            double m=100;
            double remainder;
            m = (int)cm / 100;
            remainder = cm % 100;
            
            Console.WriteLine($"{cm,3}cm     {m}m {remainder}cm");
            cm = 100;
            m = 100;
            m = (int)cm / 100;
            remainder = cm % 100;

            Console.WriteLine($"{cm,3}cm     {m}m {remainder}cm");
            cm = 290;
            m = 100;
            m = (int)cm / 100;
            remainder = cm % 100;

            Console.WriteLine($"{cm,3}cm     {m}m {remainder}cm");


            Console.WriteLine();


            Console.WriteLine("\n\n**********End Question 4 **********\n\n");
        }
        #endregion

        #region Question 5 - 18 marks
        /* SineCosine - 10 marks
         * Write a method with the following specifications:
         * Name     : SineCosine
         * Parameter: 
         *           A double that represents an angle in radians
         *           A double that represents the sine to the first argument
         *           A double that represents the cosine of the first argument
         * Returns  : Nothing
         * Displays : Nothing
         * Task     : Calculates the sine and cosine of the first argument and
         * assigns the result values to the second and third Parameter
         * 
         * NOTE: the second and thred arguemnts are decorated so that the 
         * method is able to change the actual value of the variable
         */
        static void SineCosine(double angle, out double sinh, out double cosh)
        {
            sinh = Math.Sin(angle);
            cosh = Math.Cos(angle);


        }
        /* Driver for question 5 - 8 marks 
         * Write the code statements to call this method ten times with values 
         * 0.500, 0.501, 0.502 … 0.509  and printout the values for angle, 
         * sine and cosine in a tabular format. It is expected to use some
         * kind of repetitive structure
         */
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");


            
            double sine, cosine;
            double angle = 0.50;
            Console.WriteLine("     angle    sine   cosine");
            for (double i = 5; i < 15; i++)
            {
                
                SineCosine(angle, out sine, out cosine);
                Console.WriteLine("{0,8:f2}{1,9:f4}{2,9:f4}", angle, sine, cosine);
            }

            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion

        #region Question 6 - 20 marks
        /* Write a method with the following specifications: //13 marks
         * Name: CalculateNumberFrequencies
         * Argument: an int array with values ranging from 0 to 99
         * Returns: int array of 10 integers. The first element will 
         *          indicate the number or unit values in the argument 
         *          (i.e. values 0-9), the second element will indicate 
         *          the number of 10 values (i.e. values 10-19), the 
         *          third element will indicate the number of 20 values 
         *          (i.e. values 20-29) etc.
         * Display: Nothing
         * Tasks  : The method will create an int array of 10 elements 
         *          (call this the result). 
         *          Each item of the argument is examined and the 
         *          appropriate element of the result array is incremented. 
         */


        /* Driver for Question 6 - 7 marks
         * Write the code to do the following:
         *   Call the GenerateRandomIntArray() and assign the results to a suitable variable
         *   Use the DisplayIntArray() method to display the above variable
         *   Print an empty line
         *   Call CalculateNumberFrequencies() method and display the resulting value
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********End Question 6 **********");
            GenerateRandomIntArray();
            int[] result = GenerateRandomIntArray();
            DisplayIntArray(result);
            CalculateNumberFrequencies(result);

            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }

        private static int[] GenerateRandomIntArray()
        {
            throw new NotImplementedException();
        }

        private static void CalculateNumberFrequencies(int[] result)
        {
            throw new NotImplementedException();
        }

        static void CalculateNumberFrequencies(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 99)
                {
                    Console.Write(" {0:f0}", array[i]);
                }
            }
            Console.WriteLine();
        }

          static void DisplayIntArray(int[] numbers)
        {
            foreach (var x in numbers)
                Console.Write("{0,3}", x);
        }


        private static void GenerateRandomIntArray(double[] result)
        {
            throw new NotImplementedException();
        }


    /*
     * FREE CODE
     */
    static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            int[] result = new int[numberOfItems];
            Random generator = new Random();
            for (int i = 0; i < numberOfItems; i++)
                result[i] = generator.Next(largestValue);
            return result;
        }
        #endregion
    }
}
