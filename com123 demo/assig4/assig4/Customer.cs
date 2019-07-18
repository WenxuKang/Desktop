using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    class Customer
    {
        //public List<Account> accout=new List<Account>();
            public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address{ get; set; }
       public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;LastName = lastName;Address = address;
        }



    }
}
