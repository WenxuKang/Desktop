using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise2
{
    public interface ISellable
    {
        string SalesSpeech();
        double MakeSale();
    }
    public abstract class Salesperson:ISellable
    {
        private string firstName;
        private string lastName;
        //property
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        //constructor
        public Salesperson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        //method
        public abstract string SalesSpeech();
        public abstract double MakeSale();
        public override string ToString()
        {
            return String.Format("Name: {0}" + " " + "{1}", FirstName, LastName);
        }
    }
}
