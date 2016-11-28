using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
   public class CustomerRepository
    {
        private List<Customer> customerList;

        public CustomerRepository() {
            customerList = new List<Customer>();
            customerList.Add(new Customer(1, "Peter", "Kolding Dengodevej 1"));
        }

        public List<Customer> FindCustomers()
        {
            return customerList;
        }
    }
}
