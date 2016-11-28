using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
  public  class Customer
    {
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(int customerNumber, string name, string address)
        {
            this.CustomerNumber = customerNumber;
            this.Name = name;
            this.Address = address;
        }
    }
}
