using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Employee
    {
        private int idNum;
        private double salary;
        public int IdNum
        {
            get
            {
                return idNum;
            }
            set
            {
                idNum = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }

        }
        public string GetGreeting()
        {
            string greeting = "Hello, I am Employee #" + IdNum;
            return greeting;
        }
    }
}
