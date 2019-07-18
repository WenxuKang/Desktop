using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations & initialization
            CheckingAccount account1 = new CheckingAccount(1, "Truong Nguyen", 5000);
            Console.WriteLine(account1.ToString()); //Display
            Console.WriteLine($"WithDraw ammount: {account1.WithDraw(300)}"); //Invoke WithDraw()
            Console.WriteLine();
            CheckingAccount account2 = new CheckingAccount(2, "Fernando Martin", 40);
            Console.WriteLine(account2.ToString()); //Display
            Console.WriteLine($"WithDraw ammount: {account2.WithDraw(300)}"); //Invoke WithDraw()

        }
    }
}
