using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class BasePlusCommissionEmployee
    {
        //Initialize data members
        private int employeeId;
        private string firstName;
        private string lastName;
        private double baseSalary;
        private double grossSales;
        private double commissionRate;
        public Boolean printResults=true;//To control the print results

        //define properties
        public int EmployeeId//Read-only
        {
            get
            {
                return employeeId;
            }
        }

        public string FirstName//Read-only
        {
            get
            {
                return firstName;
            }
        }

        public string LastName//Read-only
        {
            get
            {
                return lastName;
            }
        }

        public double BaseSalary//Read-only
        {
            get
            {
                return baseSalary;
            }
        }

        public double GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value <= 0.0)
                {
                    Console.WriteLine("It's not allowed numbers less or equal to zero");
                    printResults = false;//Will not print result
                }
                else
                    grossSales = value;
            }
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value >= 0.1 && value <= 1.0)
                { 
                    Console.WriteLine("The commission rate value must be between 0.1 and 1");
                    printResults = false;//Will not print result
                }
                else
                    commissionRate = value;
            }
        }
        //Creating constructor
        public BasePlusCommissionEmployee(int Employee_ID, string First_Name, string Last_Name, double Gross_Sales,
            double Base_Salary = 200.00, double Commission_Rate = 0.1)//The first constructor
        {
            if (Employee_ID > 0)
                this.employeeId = Employee_ID;
            else
            { 
                Console.WriteLine("Invalid value to employee ID");
                printResults = false;//Will not print result
            }
            if (First_Name != null)
                this.firstName = First_Name;
            else
            {
                Console.WriteLine("Invalid value to first name");
                printResults = false;//Will not print result
            }
            if (Last_Name != null)
                this.lastName = Last_Name;
            else
            {
                Console.WriteLine("Invalid value to last name");
                printResults = false;//Will not print result
            }
                this.grossSales = Gross_Sales;
            if (Base_Salary > 0)
                this.baseSalary = Base_Salary;
            else
            {
                Console.WriteLine("Base salary must be not negative");
                printResults = false;//Will not print result
            }
            this.commissionRate = Commission_Rate;
        }
        //Creating other constructor
        public BasePlusCommissionEmployee(int Employee_ID, string First_Name, string Last_Name)//The second constructor
        {
            this.employeeId = Employee_ID;
            this.firstName = First_Name;
            this.lastName = Last_Name;
        }
    public double Earnings()//Create method Earnings
        {
            return ((commissionRate * grossSales) / 100) + baseSalary;//Calculating the earnings
        }

        public override string ToString() //Create method ToString
        {
            if (printResults)//if true then print
                return string.Format("Id: {0}\n First name: {1}\t Last name: {2}\n" +
                    " Base salary: {3}\n Gross sales: {4}\n Commission rate: {5}\n Earnings(base salary+commission): {6}",
                    employeeId, firstName, lastName, baseSalary, grossSales, commissionRate, Earnings());//Output format
            else//if false then do not print
                return string.Format("");
        }
    }
}
