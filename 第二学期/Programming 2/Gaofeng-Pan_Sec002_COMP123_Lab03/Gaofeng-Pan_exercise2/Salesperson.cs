using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaofeng_Pan_exercise2
{
    public interface ISellable
    {
        string SalesSpeech();
        double MakeSale();
    }
    public abstract class Salesperson : ISellable
    {
        private string firstName;
        private string lastName;
        
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
        
        public Salesperson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public abstract string SalesSpeech();
        public abstract double MakeSale();
        public override string ToString()
        {
            return String.Format("Name: {0}" + " " + "{1}", FirstName, LastName);
        }
    }
}
