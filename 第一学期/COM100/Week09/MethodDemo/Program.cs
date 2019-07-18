using System;


namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Driver1();
            //Driver2();
            Driver3();
            //Driver4();
        }

        #region equations
        static void Driver4()
        {
            Equation();
        }
        /*
         * Write a method that will produce the following output:
         * y = 5 + 3x -2x^2
         */
        static void Equation()
        {
            double start = 0, end = 2, step = 0.25;
            Console.WriteLine($"  x     5     3x   -2x^2  y");
            for (; start <= end; start += step)
            {
                double first = 5;
                double second = 3 * start;
                double third = -2 * start * start;
                double last = first + second + third;
                Console.WriteLine($"{start, 5:F1} {first, 5:F1} {second, 5:F1} {third, 5:F1} {last, 5:F1}");
            }
        }

        #endregion
        
        #region practice out
        static void Driver3()
        {
            int c;// = 0;
            //Console.WriteLine($"Before method {c}");
            Twice3(out c);
            Console.WriteLine($"After method {c}");
        }
        /*
         * Write a method that modifies its argument
         */
        static void Twice3(out int c)
        {
            c = 20;
            Console.WriteLine($"In method {c}");
        }
        #endregion

        #region Twice with ref
        static void Driver2()
        {
            int b = 5;
            Console.WriteLine($"Before method {b}");
            Twice2(ref b);
            Console.WriteLine($"After method {b}");
        }
        /*
         * Write a method that doubles its argument
         */
        static void Twice2(ref int a)
        {
            a *= 2;
            Console.WriteLine($"In method {a}");
        }
        #endregion

        #region broken Twice
        static void Driver1()
        {
            int a = 5;
            Console.WriteLine($"Before method {a}");
            Twice1(a);
            Console.WriteLine($"After method {a}");
        }
        /*
         * Create a method that doubles its argumemnt
         */
        static void Twice1(int a)
        {
            a *= 2;
            Console.WriteLine($"In method {a}");
        }
        #endregion
    }
}
