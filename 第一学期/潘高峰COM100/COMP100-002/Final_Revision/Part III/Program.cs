using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CaculateDifference(10, 20));
            Console.WriteLine(CaculateDifference(20, 10));
            Console.WriteLine(CaculateDifference(10, 33));
            Console.WriteLine(CaculateDifference(999,333));
            Console.WriteLine();
            Console.WriteLine(CalculatePower(1, 0.5));
            Console.WriteLine(CalculatePower(20, 33.33));
            Console.WriteLine();
            Console.WriteLine(CaculateTuitionFee(6));
            Console.WriteLine(CaculateTuitionFee(6,1000));
            Console.WriteLine(CaculateTuitionFee(10));
            Console.WriteLine(CaculateTuitionFee(10,100));
            Console.WriteLine();
            Console.WriteLine(CalculateCommission(900));
            Console.WriteLine(CalculateCommission(1000));
            Console.WriteLine(CalculateCommission(2000));
            Console.WriteLine();
            Console.WriteLine($"{CalculateBurgerMoney():c}");
            Console.WriteLine($"{CalculateBurgerMoney():c}");
            Console.WriteLine();
            Console.WriteLine($"{CalculateGravitationalAttraction(5.972 * 10e24, 7.348 * 10e22, 384400000):e2}N");
            Console.WriteLine();
            Console.WriteLine(CalculateAreaofTriangle(5.83,4.24,8.00));
            Console.WriteLine();
            Console.WriteLine(ConvertCelsiusToFahrenheit(0));
            Console.WriteLine(ConvertCelsiusToFahrenheit(50));
            Console.WriteLine(ConvertCelsiusToFahrenheit(100));
            Console.WriteLine();
            Console.WriteLine(ConvertFahrenheitToCelsius(0));
            Console.WriteLine(ConvertFahrenheitToCelsius(32));
            Console.WriteLine(ConvertFahrenheitToCelsius(212));
            Console.WriteLine();
            Console.WriteLine(ConvertCelsiusToKelvin(-190));
            Console.WriteLine(ConvertCelsiusToKelvin(0));
            Console.WriteLine(ConvertCelsiusToKelvin(100));
            Console.WriteLine();
            Console.WriteLine(ConvertFahrenheitToKelvin(0));
            Console.WriteLine(ConvertFahrenheitToKelvin(32));
            Console.WriteLine(ConvertFahrenheitToKelvin(212));
            Console.WriteLine();
            Console.Write("Please enter a integer: ");
            Console.WriteLine(Cube(Square(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine();
            Console.WriteLine("Your commission is "+$"{CalculateCommissionII(DailySalesAmount()):c}");
        }
        #region Q_01
        /*1.	Write a method called CaculateDifference(int firstNumber, int secondNumber). 
         * This method will calculate and return the difference between the two numbers 
         * i.e. it will subtract the smaller one from the larger one and then return that value. 
         * Call the CaculateDifference() method four times from your program Main() method supplying different arguments each time. 
         * You must display the returned value for each call.
         */
         static int CaculateDifference(int firstNumber, int secondNumber)
        {
            //int difference = Math.Abs(firstNumber - secondNumber);
            //return difference;
            return (firstNumber > secondNumber) ? (firstNumber - secondNumber) : (secondNumber - firstNumber);
        }
        #endregion
        #region Q_02
        /*2.	Write a method called CalculatePower(double current, double resistance). 
         * The method will calculate and return the electrical power dissipated in a circuit. [P=I2R].
         * Call the CalculatePower() method two times from your program Main() method 
         * supplying different arguments each time and displaying the returned value each time.
         */
         static double CalculatePower(double current, double resistance)
        {
            double power;
            power = Math.Pow(current, 2) * resistance;
            return power;
        }
        #endregion
        #region Q_03
        /*3.	Write a method called CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99). 
         * This method will calculate and return the required fees amount. 
         * [Fees = number of courses * cost per course + 15.25]. 
         * Call the CaculateTuitionFee() method four times from your program Main() method supplying different arguments each time.
         */
         static double CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fee = numberOfCourses * costPerCourse + 15.25;
            return fee;
        }
        #endregion
        #region Q_04
        /*4.	Write a method called CalculateCommission(double saleAmount). 
         * This method will calculate and return a sales representation’s commission. 
         * [over $1000 the commission will be 1%]. 
         * Call the CalculateCommission() method three times from your program Main() method, 
         * supplying arguments 900, 1000 and 2000.
         */
         static double CalculateCommission(double saleAmount)
        {
            double commission;
            if (saleAmount>1000)
            {
                commission = 0.01 * (saleAmount - 1000);
            }
            else
            {
                commission = 0;
            }
            return commission;
        }
        #endregion
        #region Q_05
        /*5.	Write a method that does not take any argument. 
         * The method will prompt the user for the number of burgers that he wants to buy. 
         * The method will calculate and return the amount of money that will be required. [One burger cost $1.39]. 
         * From your program Main() method, call the above method two times 
         */
        static double CalculateBurgerMoney()
        {
            Console.Write("How many burgers do you want to buy? ");
            double cost = Convert.ToInt32(Console.ReadLine()) * 1.39;
            return cost;
        }
        #endregion
        #region Q_06
        /*	“Newton's law of universal gravitation states 
         *	that every point mass in the universe attracts every other point mass with a force 
         *	that is directly proportional to the product of their masses 
         *	and inversely proportional to the square of the distance between them.” 
         *	Write a method called CalculateGravitationalAttraction() that takes three double arguments 
         *	(masses of the two bodies and the distance between them). 
         *	The method will calculate and return the force of attraction between them. 
         *	[F=G (m_1 m_2)/d^2  , where G = 6.673x10-11]. 
         *	In your main call this method with the masses of the earth, moon and the distance between them 
         *	and display the resulting force. 
         *	Mass of Earth = 5.972 × 10e24, moon = 7.348 × 10e22, Distance = 384,400000m. [Answer 1.99 x 1020N] 
         */
         static double CalculateGravitationalAttraction(double firstMass,double secondMass,double distance)
        {
            double force = 6.673e-11 * firstMass * secondMass / Math.Pow(distance,2);
            return force;
        }
        #endregion
        #region Q_07
        /*	Heron’s formula allows you to calculate the area of any triangle given the length of the three sides. 
         *	Write a method that takes the length of the three sides and return the area of the specified triangle. 
         *	A=√(s(s-a)(s-b)(s-c) ) where s=(a+b+c)/2. 
         *	In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area. [Answer = 12.0].
         */
         static double CalculateAreaofTriangle(double a,double b,double c)
        {
            double s = (a + b + c) / 2.0;
            double area = Math.Pow(s*(s - a)*(s - b)*(s - c), 0.5);
            return area;
        }
        #endregion
        #region Q_08
        /*8.	Write a method called ConvertCelsiusToFahrenheit that takes a double argument. 
         * The method will calculate and return the Fahrenheit equivalent of the argument. 
         * [F = C * 9 / 5 + 32]. 
         * In your main call this method three times with arguments 0, 50 and 100 respectively and display the results.
         */
         static double ConvertCelsiusToFahrenheit(double C)
        {
            double F = C * 9.0 / 5 + 32;
            return F;
        }
        #endregion
        #region Q_09
        /*9.	Write a method called ConvertFahrenheitToCelsius that takes a double argument. 
         * The method will calculate and return the Celsius equivalent of the argument. [C = (F – 32) * 5 / 9]. 
         * In your main call this method three times with arguments 0, 32 and 212 respectively and display the results.
         */
         static double ConvertFahrenheitToCelsius(double F)
        {
            double C = (F - 32) * 5.0 / 9;
            return C;
        }
        #endregion
        #region Q_10
        /*10.	Write a method called ConvertCelsiusToKelvin that takes a double argument. 
         * The method will calculate and return the Kelvin equivalent of the argument. [K = C + 273.15]. 
         * In your main call this method three times with arguments -196, 0 and 100 respectively and display the results.
         */
         static double ConvertCelsiusToKelvin(double C)
        {
            double K = C + 273.15;
            return K;
        }
        #endregion
        #region Q_11
        /*11.	Write a method call ConvertFahrenheitToKelvin that takes a double argument. 
         * The method will calculate and return the Kelvin equivalent of the argument. 
         * [Use the two previous methods to assist in your computation]. 
         * In your main call this method three times and display the results.
         */
         static double ConvertFahrenheitToKelvin(double F)
        {
            double K = ConvertCelsiusToKelvin(ConvertFahrenheitToCelsius(F));
            return K;
        }
        #endregion
        #region Q_12
        /*12.	Write two methods: Square(int) and Cube(int), 
         * these methods return the square and the cube of its argument. 
         * In your main method prompt the user for an integer, 
         * then pass this integer to the Square method and then pass the results to the Cube method. 
         * In the main method print out the final results.
         */
         static int Square(int m)
        {
            int a = m * m;
            return a;
        }
        static int Cube(int n)
        {
            int b = n * n * n;
            return b;
        }
        #endregion
        #region Q_13
        /*13.	Write two methods that will be called from main. 
         * The first method should prompt the user for his daily sales amount. 
         * The method should accept and return this amount. 
         * The second method should calculate and return his commission based on the following: 0-999 3%, 1000-2999 4% and over 3000 5%. 
         * In your main call the two methods and display the results in a readable manner
         */
        static double DailySalesAmount()
        {
            Console.Write("Please enter your daily sales amount: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static double CalculateCommissionII(double amount)
        {
            double commission;
            if(amount<=999)
            {
                commission = 0.03 * amount;
            }else if(amount<=2999)
            {
                commission = 0.04 * (amount-999)+29.97;
            }else
            {
                commission = 0.05 * (amount - 2999) + 109.97;
            }
            return commission;
        }
        #endregion
    }
}
