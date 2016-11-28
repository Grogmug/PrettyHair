using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair;

namespace PrettyHair.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Costumerlist:");
            CustomerRepository cr = new CustomerRepository();
            List<Customer> customerlist = cr.FindCustomers();
            customerlist.ForEach(item => Console.Write(item.CustomerNumber.ToString() + " "
                                                     + item.CustomerName + " "
                                                     + item.CustomerAddress + "\n"));
            Console.ReadLine();

        }
    }
}
