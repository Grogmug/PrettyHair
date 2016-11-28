using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
   public class Order
    {
        public int Id { get; set; }
        public string Date { get { return Date; } set { Date = Convert.ToString(DateTime.Now); } }
        public string DeliveryDate { get; set; }
        public bool Picked = true;
        public Orderline Orderline { get; set; }    
        

        private List<Orderline> OrderlineList; 

        public Order(int id, string deliveryDate, bool picked)
        {

            OrderlineList = new List<Orderline>();
            Id = id;
            DeliveryDate = deliveryDate;
            Picked = picked;

        }

        public void AddOrderline(Ware ware, int quantity)
        {
           OrderlineList.Add(new Orderline(ware, quantity));

        }

        public Order()
        {
            OrderlineList = new List<Orderline>();
        }


    }
}
