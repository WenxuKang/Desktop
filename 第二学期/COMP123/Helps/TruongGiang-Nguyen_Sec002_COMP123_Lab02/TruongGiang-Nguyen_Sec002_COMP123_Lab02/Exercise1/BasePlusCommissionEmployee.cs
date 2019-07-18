using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class BasePlusCommissionEmployee
    {
        //Declaration & initialization
        int empID;
        string firstName;
        string lastName;
        double baseSalary=200.00; //default value
        double grossSales;
        double commissionRate=0.1; //default value
        //default constructor
        public BasePlusCommissionEmployee() { }
        //overload constructor
        public BasePlusCommissionEmployee(int ID, string first, string last, double salary, double sale, double rate)
        {
            if (ID > 0)
                empID = ID;
            else
                Console.WriteLine("The ID must be positive!");
            if (first != null & last != null)
            {
                firstName = first;
                lastName = last;
            }
            else
                Console.WriteLine("Employees name should be filled in");
            if (salary > 200)
                baseSalary = salary;
            else
                Console.WriteLine("Base salary must be >= 200!");
            GrossSale = sale;
            CommissionRate = rate;
        }
        public BasePlusCommissionEmployee(int ID, string first, string last, double salary) //overload constructor
        {
            if (ID > 0)
                empID = ID;
            else
                Console.WriteLine("The ID must be positive!");
            if (first != null & last != null)
            {
                firstName = first;
                lastName = last;
            }
            else
                Console.WriteLine("Employees name should be filled in");
            if (salary > 200)
                baseSalary = salary;
            else
                Console.WriteLine("Base salary must be >= 200!");
        }
        public int EmpID //read only property
        {
            get
            {
                return empID;
            }
        }
        public string FirstName //readonly property
        {
            get
            {
                return firstName;
            }
        }
        public string LastName //read only property
        {
            get
            {
                return lastName;
            }
        }
        public double BaseSalary //read only property
        {
            get
            {
                return baseSalary;
            }
        }
        public double GrossSale
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value > 0)
                { grossSales = value; }
                else
                    Console.WriteLine("Gross Sale should be positive");
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
                if (value >= 0.01 && value <= 0.1)
                    commissionRate = value;
                else
                    Console.WriteLine("Commission Rate should be in [0.01 - 0.1]");
            }
        }
        public double Earnings() // earning() method
        {
            return CommissionRate * GrossSale + BaseSalary;
        }
        public override string ToString()
        {
            return String.Format($"ID: {EmpID} \nLast Name: {LastName} \nFirst Name:{FirstName} \nBase Salary: {BaseSalary} \nCommission Rate:{CommissionRate} \nGross Sale: {GrossSale}");
        }

    }
}
