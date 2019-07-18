using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_Ex_01
{
    class BasePlusCommissionEmployee
    {
        private int empID;
        private string fName, lName;
        private double baseSalary, grossSales;
        private double commRate;

        public int EmpID
        {
            get
            {
                return empID;
            }
        }
        public string FName
        {
            get
            {
                return fName;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
        }
        public double BaseSalary
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
                if (value > 0.0)
                    grossSales = value;
                else
                    Console.WriteLine("Provide positive value for gross sales.");
            }
        }
        public double CommRate
        {
            get
            {
                return commRate;
            }
            set
            {
                if (value >= 0.1 & value <= 1.0)
                    commRate = value;
                else
                    Console.WriteLine("Commission rate should be between 0.1 and 1.0%.");
            }
        }

        public BasePlusCommissionEmployee(int employeeID, string firstN, string lastN, 
            double grossS, double baseS = 200.0, double commRate = 0.1)
        {
            if (employeeID > 0)
                this.empID = employeeID;
            else
                Console.WriteLine("Provide positive value for employee ID.");


            if (firstN != null)
                this.fName = firstN;
            else
                Console.WriteLine("Provide appropriate value for first name.");


            if (lastN != null)
                this.lName = lastN;
            else
                Console.WriteLine("Provide appropriate value for last name.");


            if (baseS >= 0)
                this.baseSalary = baseS;
            else
                Console.WriteLine("Provide nonnegative value for base salary.");


            GrossSales = grossS;
            CommRate = commRate;
        }

        public BasePlusCommissionEmployee(int employeeID, string firstN, double baseS = 200.0)
        {
            if (employeeID > 0)
                this.empID = employeeID;
            else
                Console.WriteLine("Provide positive value for employee ID.");


            if (firstN != null)
                this.fName = firstN;
            else
                Console.WriteLine("Provide appropriate value for first name.");


            if (baseS >= 0)
                this.baseSalary = baseS;
            else
                Console.WriteLine("Provide nonnegative value for base salary.");
        }

        public double Earnings()
        {
            return CommRate * GrossSales + BaseSalary;
        }

        public override string ToString()
        {
            return string.Format($"Employee ID: {EmpID}\nLast Name: {LName}\nFirst Name: {FName}\nBase Salary: {BaseSalary}\nGross Sales: {GrossSales}\nCommission Rate: {CommRate}");
        }
    }
}
