using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    abstract class Salesperson//create abstract class
    {
        //Initialize data members
        string firstName;
        string lastName;

        public Salesperson() { }
        public Salesperson(string fName, string lName)
        {
            FirstName=fName;
            LastName = lName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName=value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public abstract double MakeSale();
        public override string ToString()
        {
            return String.Format("Full name: {0} {1}\n", FirstName, LastName);
        }


    }
}
