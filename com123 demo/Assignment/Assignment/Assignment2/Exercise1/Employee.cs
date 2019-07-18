using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Employee
    {
        private int employeedId;

        public int EmployeeID
        {
            get
            {
                return employeedId;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BaseSalary { get; set ; }
        public double GrossSales { get; set; }
        public double ComissionRate { get; set; }
      
        public Employee()
        {                                    
            BaseSalary = 1000.00;            
            ComissionRate = 0.1;            
        }
        public Employee(int employeeId, string firstName, double baseSalary)
        {
            this.employeedId = employeeId;
            this.FirstName = firstName;
            this.BaseSalary = baseSalary;
        }
        public double Earings()
        {
            double commission = ComissionRate * GrossSales + BaseSalary;
            return commission;
        }
    }
}
