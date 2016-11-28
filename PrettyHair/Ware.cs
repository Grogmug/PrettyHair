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
        
        public string Description { get; set; }

        public Ware(int id, decimal price, string description)
        {
            this.Id = id;
            this.Price = price;

            this.Description = description;
        }
    }
}
