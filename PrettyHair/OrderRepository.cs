using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
  public  class OrderRepository
    {
        public List<Order> OrderList { get; set; }
        public List<Order> FindOrder()
        {
            return OrderList;
        }

        public void NewOrder(int id, string deliverydate)
        {
            OrderList.Add(new Order(id, deliverydate, false));
        }
    }

}
