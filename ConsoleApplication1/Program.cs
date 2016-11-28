using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair;

namespace PrettyHair.App
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            WareRepository wr = new WareRepository();
            Console.WriteLine();
            wr.wareList.ForEach(item => Console.Write(item.Id.ToString() + " "
                                                     + item.Description + " "
                                                     + item.Price + "\n"));

            Console.WriteLine("\n");
            Console.WriteLine("Pick Ware to add to order by ID:");
      
            int wareid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();      
            
        
            Orderline orderline = new Orderline(wr.GetWareById(wareid), 3);
            Order order = new Order();
            order.Orderline = orderline;
            Console.WriteLine(order.Orderline.Ware.Description +" Price: "+ order.Orderline.Ware.Price + " Quantity: "+ order.Orderline.Quantity);



            /*          Console.WriteLine("Customerlist:");
                      CustomerRepository cr = new CustomerRepository();
                      List<Customer> customerlist = cr.FindCustomers();
                      customerlist.ForEach(item => Console.Write(item.CustomerNumber.ToString() + " "
                                                               + item.Name + " "
                                                               + item.Address + "\n"));


                                                                        ;
                      Console.ReadLine();


              */

            Console.ReadLine();
        }
    }
}
