using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
  public  class Orderline
    {
        public Ware Ware { get; set; }
        public int Quantity {get; set;}

        public Orderline(Ware ware, int quantity)
        {
            this.Ware = ware;
            this.Quantity = quantity;
        }
    }
}
