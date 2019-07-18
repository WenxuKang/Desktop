using System;

namespace ConsoleApp2
{
    class Program
    {

        
        static void Main(string[] args)
        {
            object[] Emplyees = new object[] { new PartTimeEmployee(), new Employee()  };

            foreach(object employee in Emplyees)
            {
                //Console.WriteLine{ (employee) as Employee).AccordWeeklyPay};

            if((employee as Employee) !=null)
                {
                    Console.WriteLine((employee as Employee).AccordiWeeklyPay);

                }
            else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
