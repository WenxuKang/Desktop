using System;

namespace week10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            PrintLetters(letters);
            PrintNumbers(numbers);
            PrintPoem(poem);

            /* 4.	In your main method use the method in question 1 to display the letters array, 
             * then use the Array.Reverse() method to reverse the letters array and then again call the appropriate method to print it
             */
            PrintLetters(letters);
            Array.Reverse(letters);
            PrintLetters(letters);

            /* 5.	In your main method use the method in question 3 to display the poem array, 
             * then use the Array.Sort() method to sort the poem array and then again call the appropriate method to print it
             */
            PrintPoem(poem);
            Array.Sort(poem);
            PrintPoem(poem);

            /* 6.	In your main method use the method in question 2 to display the numbers array, 
             * then use the Array.Binarysearch() method to try to find the position of 3 in the numbers array. 
             * What is your answer?
             * Now repeat the same steps after you have sorted the array and printed the sorted array
             */
            PrintNumbers(numbers);
            Console.WriteLine(Array.BinarySearch(numbers, 3));
            Console.WriteLine();
            Array.Sort(numbers);
            PrintNumbers(numbers);
            Console.WriteLine(Array.BinarySearch(numbers, 3));
            Console.WriteLine();

            Console.Write("Please enter the amount of numbers in array: ");
            int[] m = InputNumbers(Convert.ToInt32(Console.ReadLine()));
            foreach (int x in m)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Please enter the amount of numbers in array: ");
            int[] n = InputNumbers(Convert.ToInt32(Console.ReadLine()));
            foreach (int x in n)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        #region Question_1
        /* 1.	Write a method that takes an argument (a char array) and print each item on a single line separated by a space. 
         * From your main, call this method with letters as argument
         */
        static void PrintLetters(char[] a)
        {
            for (int counter = 0; counter < a.Length; counter++)
            {
                Console.Write(a[counter] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
        #region Question_2
        /* 2.	Write a method that takes an argument (an int array) and print each item on a single line separated by a space. 
         * From your main, call this method with numbers as argument
         */
        static void PrintNumbers(int[] b)
        {
            int i = 0;
            while (i < b.Length)
            {
                Console.Write(b[i] + " ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
        #region Question_3
        /* 3.	Write a method that takes an argument (a string array) and print each item on a single line separated by a space. 
         * From your main, call this method with poem as argument
         */
        static void PrintPoem(string[] c)
        {
            int j = 0;
            do
            {
                Console.Write(c[j] + " ");
                j++;
            } while (j < c.Length);
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
        #region Question_7
        /*7.	Write a method that creates and return an array of ints. 
         * The method takes a single argument that represents the number of items in the resulting array and does the following:
         * •	Declare an array of the required type
         * •	Allocate memory for the intended number of items
         * •	Using any looping structure, prompt the user for a number and then assign to each element. 
         * In your main method call this method (you will need to supply an argument), 
         * assign the resulting value to at suitable variable and then display this variable.
         */
        static int[] InputNumbers(int a)
        {
            int[] inputNumbers = new int[a];
            for (int x = 0; x < inputNumbers.Length; x++)
            {
                Console.Write($"Please input the #{x + 1} number: ");
                inputNumbers[x] = Convert.ToInt32(Console.ReadLine());
            }
            /*foreach(int x in inputNumbers)
            {
                Console.Write($"Please input the #{x + 1} number: ");
                x = Convert.ToInt32(Console.ReadLine());
            }*/                                                 //error
            return inputNumbers;
        }
        #endregion
        #region Question_8
        /*8.	Write another method that creates and return an array of ints. 
         * The method takes a single argument that represents the number of items in the resulting array and does the following:
         * •	Declare an array of the required type
         * •	Allocate memory for the intended number of items
         * •	Using any looping structure, assign to each element a random integer in the range 100 to 200. 
         * Exercise this method in a similar fashion as you did for question 7.
         * Radom rand = new Random();
         * rand.Next(100, 200);
         */
        static int[] Range(int number)
        {
            Random rand = new Random();
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100, 200);
            }
            return array;
        }
        #endregion
    }
}