using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            ////objects
            //Employee receptionist = new Employee();
            //Employee deliveryPerson = new Employee();

            //CommissionEmployee salesperson = new CommissionEmployee();
            //salesperson.IdNum = 234;
            //salesperson.Salary = Convert.ToDouble(Console.ReadLine());
            //salesperson.CommissionRate = 0.07;
            Employee clerk = new Employee();
            CommissionEmployee salesperson = new CommissionEmployee();
            clerk.IdNum = 123;
            clerk.Salary = 30000.00;
            salesperson.Salary = 20000.00;
            salesperson.IdNum = 234;
            salesperson.CommissionRate = 0.07;
            Console.WriteLine("\n"+clerk.GetGreeting());
            Console.WriteLine("Clerk #{0} salary: {1} per year", clerk.IdNum, clerk.Salary.ToString("C"));
            Console.WriteLine("Salesperson #{0} salary: {1} per year", salesperson.IdNum, salesperson.Salary.ToString("C"));
            Console.WriteLine("...plus {0} commission on all sales", salesperson.CommissionRate.ToString("P"));

        }
    }
}
