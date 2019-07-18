using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            DoubleIt(ref a);
            DoubleIt(ref a);
            Console.WriteLine(a);
            Console.WriteLine();

            int b = 2, c = 0, d = 0;
            CubeIt(b, ref c);
            Console.WriteLine(c);
            CubeIt(c, ref d);
            Console.WriteLine(d);
            Console.WriteLine();

            int e = 4;
            double f = 100, g = 0;
            CalculateTuitionFee(e, f, ref g);
            Console.WriteLine(g);
            int e2 = 6;
            double f2 = 200, g2 = 0;
            CalculateTuitionFee(e2, f2, ref g2);
            Console.WriteLine(g2);
            int e3 = 2;
            double f3 = 50, g3 = 0;
            CalculateTuitionFee(e3, f3, ref g3);
            Console.WriteLine(g3);
            int e4 = 1;
            double f4 = 10, g4 = 0;
            CalculateTuitionFee(e4, f4, ref g4);
            Console.WriteLine(g4);
            Console.WriteLine();

            int h = 10, i = 20, j = 0, k = 0;
            CompareTwoIntegers(h, i, ref j, ref k);
            Console.WriteLine("Sum is {0}. Difference is {1}.",j,k);
            int h2 = 20, i2 = 10, j2 = 0, k2 = 0;
            CompareTwoIntegers(h2, i2, ref j2, ref k2);
            Console.WriteLine("Sum is {0}. Difference is {1}.", j2, k2);
            int h3 = 99, i3 = 33, j3 = 0, k3 = 0;
            CompareTwoIntegers(h3, i3, ref j3, ref k3);
            Console.WriteLine("Sum is {0}. Difference is {1}.", j3, k3);
            Console.WriteLine();

            double l = 0, m = 0, n = 0, o = 0;
            for(int counter=0;counter<20;counter++)
            {
                CalculateTrigValues(l,out m,out n,out o);
                Console.WriteLine("With angle {0}°, Sin is {1:f}, cos is {2:f}, tan is {3:f}.",l,m,n,o);
                l += 5;
            }
            Console.WriteLine();

            double p = 0.500, q = 0, r = 0;
            for (int counter = 0; counter < 10; counter++)
            {
                CalculateTrigValuesII(p, out q, out r);
                Console.WriteLine("With angle {0}, Sin is {1:f}, cos is {2:f}.", p, q, r);
                p += 0.001;
            }
            Console.WriteLine();

            double u = 12, v = 1, w = -6, x1 = 0, x2 = 0;
            SolveQuadraticEquation(u, v, w,out x1,out x2);
            Console.WriteLine("The solutions of quadratic equation are {0:f3} and {1:f3}.", x1, x2);
        }
        #region Q_01
        /*1.	Write a method call DoubleIt(ref int x) that takes a single argument and does not return a value. 
         * This method will double the value of its argument. 
         * In your main, call this method twice and print the value of the parameter after the method call.
         */
         static void DoubleIt(ref int x)
        {
            x *= 2;
        }
        #endregion
        #region Q_02
        /*2.	Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value. 
         * The method will cube the first argument and assign it to the second argument. 
         * In your main, call this method twice and print the value of the parameters after each method call.
         */
         static void CubeIt(int x, ref int cube)
        {
            x = (int)Math.Pow(x, 3);
            cube = x;
        }
        #endregion
        #region Q_03
        /*3.	Write a method with the following header: 
         * static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees). 
         * This method will calculate and assign the required fees amount to the third argument. 
         * [Fees = number of courses * cost per course + 15.25]. 
         * From your program Main() method, call the CalculateTuitionFee () method four times supplying different arguments each time 
         * and display the value of the third argument after each method call.
         */
         static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        #endregion
        #region Q_04
        /*4.	Write a method that takes four parameter of type int. 
         * The method will assign the sum of the first two arguments to the third 
         * and the difference of the first two to the fourth. 
         * This method should be coded so that the calling method will use the value of the third and fourth parameters. 
         * Call this method about three times and print out the value of the four parameters after each method call.
         */
        static void CompareTwoIntegers(int x,int y,ref int sum,ref int dif)
        {
            sum = x + y;
            dif = (x>=y) ? (x - y) : (y - x);
        }
        #endregion
        #region Q_05
        /*5.	Write a method with header 
         * static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent). 
         * The method will use the first argument to compute the values of the other three arguments. 
         * Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth arguments respectively. 
         * [radians = degrees * Math.Pi /180]. 
         * In the Main() method, invoke this method 20 times with the first argument 
         * taking the values 0, 5, 10, … 95 and display the four arguments in a professional tabular format.
         */
         static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            sine = Math.Sin(degrees * Math.PI / 180);
            cosine = Math.Cos(degrees * Math.PI / 180);
            tangent = Math.Tan(degrees * Math.PI / 180);
        }
        #endregion
        #region Q_06
        /*6.	Write a method that takes three parameters of type double: 
         * the first represents an angle, the other two represents the sine and cosine of the angle respectively. 
         * The method must be able to change the actual value of the second and third argument. 
         * In your Main() method, call this method ten times with values 0.500, 0.501, 0.502 … 0.509 
         * and printout the values for angle, sine and cosine in a tabular format
         */
         static void CalculateTrigValuesII(double degrees,out double sine,out double cosine)
        {
            sine = Math.Sin(degrees);
            cosine = Math.Cos(degrees);
        }
        #endregion
        #region Q_07
        /*	A quadratic equation is one in the form of ax2+bx+c = 0. 
         *	Normally, there are two solutions to such equations given by the expression x=(-b∓√(b^2-4ac))/2a.
         *	The Write a method that takes five double arguments, 
         *	the first three represents a, b and c respectively and the last two the solutions to the equation. 
         *	[You can check your implementation, the quadratic equation 12x2+x-6 will yield solutions -0.750 & 0.667]
         */
         static void SolveQuadraticEquation(double a,double b,double c,out double x1,out double x2)
        {
            x1 = (-b + Math.Pow(Math.Pow(b, 2) - 4 * a * c, 0.5)) / (2 * a);
            x2 = (-b - Math.Pow(Math.Pow(b, 2) - 4 * a * c, 0.5)) / (2 * a);
        }
        #endregion
    }
}
