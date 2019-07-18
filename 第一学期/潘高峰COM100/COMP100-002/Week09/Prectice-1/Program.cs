using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prectice_1
{
    class Program
    {
        //Declare the following arrays in a global scope
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };
        static void Main(string[] args)
        {
            PrintObama();

            PrintPoemReverse();

            SumPrimes();

            DoublePrimes();
            SumPrimes();

            PrintVowels();
            CaseConversion();
            PrintVowels();

            Console.WriteLine(SumPrimes_2());
        }
        #region Question 1
        /*1.	Write a method that prints the string array obama. Each element must be on a separate line.
         * From your main, call this method. [Your method will not take any parameters and it does not return a value.]
         */
        static void PrintObama()
        {
            int counter = 0;
            while (counter < obama.Length)
            {
                Console.WriteLine(obama[counter++]);
            }

        }
        #endregion
        #region Question 2
        /*2.	Write a method that prints the string array poem in reverse order. All the items must be in the same line.
         * From your main, call this method. [Your method will not take any parameters and it does not return a value.]
         */
        static void PrintPoemReverse()
        {
            for (int i = poem.Length - 1; i >= 0; i--)
            {
                Console.Write($"{poem[i]} ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Question 3
        /*3.	Write a method that sums all the items of the array primes, and then display this sum.
         * From your main, call this method. [Your method will not take any parameters and it does not return a value.]
         */
        static void SumPrimes()
        {
            int sum = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                sum = sum + primes[i];
            }
            Console.WriteLine(sum);
        }
        #endregion
        #region Question 4
        /*4.	Write a method that doubles all the items of the int array primes.
         * This method does not display anything.
         * From your main, call the previous method, this method and then the previous method again. 
         * Because the previous method was called twice, you will have two printouts, one with the original value and the second one with the doubled values. 
         * [Your method will not take any parameters and it does not return a value.]
         */
        static void DoublePrimes()
        {
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = 2 * primes[i];
            }
        }
        #endregion
        #region Question 5
        /*5.	A) Write a method that will subtract 32 from each item of the char array vowels. 
         * You will have to cast the 32 to a char in order to do the subtraction 
         * B) Write a second method that will display all the items of the char array vowels on a single line 
         * C) From your main, call the second method, then the first and then the second again
         * 
         * Subtracting or adding 32 is a common technique for converting from lower case alphabet to upper case alphabet and vice-versa
         */
        static void CaseConversion()
        {        
            for (int i = 0; i<vowels .Length;i++ )
            {
                vowels[i] -= (char)32;
                //vowels[i] = (char)(vowels[i] - 32);
            }
        }
        static void PrintVowels()
        {
            int counter = 0;
            while (counter < vowels.Length)
            {
                Console.Write(vowels[counter++]+" ");
            }
            Console.WriteLine();
        }
        #endregion
        #region Question 6
        /*6.	Modify your solution for Question 3 so that the method calculates the sum, 
         * but return this value instead of displaying it
         * From your main, call this new method and display the return value
         */
         static int SumPrimes_2()
        {
            int sum = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                sum = sum + primes[i];
            }
            return sum;
        }
        #endregion
    }
}
