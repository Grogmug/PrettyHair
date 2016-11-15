using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class Ware
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Designation { get; set; }

        public Ware(int id, decimal price, int amount, string designation)
        {
            this.Id = id;
            this.Price = price;
            this.Amount = amount;
            this.Designation = designation;
        }
    }
}
