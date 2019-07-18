using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee testOne = new Employee(1, "Jhon", 3000.00);
            Employee testTwo = new Employee();

            Console.Write("Please enter your first name: ");
            testTwo.FirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            testTwo.LastName = Console.ReadLine();

            Console.Write("Please enter your base salary: ");
            testTwo.BaseSalary= Convert.ToDouble( Console.ReadLine());

            Console.Write("Please enter your gross salary: ");
            testTwo.GrossSales=Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your comission rate: ");
            testTwo.ComissionRate=Convert.ToDouble(Console.ReadLine());

            double commissionTwo= testTwo.Earings();
          
            Console.WriteLine($"{testTwo.FirstName} {testTwo.LastName} has earned commission of{commissionTwo:C} ");
           
            
        }
        public static void PositiveValidation()
        {
            bool validation = true;
            while (validation)
            {

            }
        }
    }

}
