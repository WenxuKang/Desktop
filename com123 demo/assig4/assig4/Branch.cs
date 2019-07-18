using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig4
{
    class Branch
    {
       
       
        public Address Address { get; set; }
       public Branch(Address address)
        {
            Address = address;
        }
        public static List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();

        customers.Add(new Customer("a","b",new Address("1","2","3","4","5","6","7")));
            customers.Add(new Customer("1","2", new Address("1", "2", "3", "4", "5", "6", "7")));

            return customers;
        }

        public void DelBranches()
        {

            //customers.Remove(new Customer(" ","",""));
        }
   
}
}
