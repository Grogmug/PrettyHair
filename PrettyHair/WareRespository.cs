using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class ItemRepository
    {
        private List<Ware> wareList;

        public ItemRepository()
        {
            wareList = new List<Ware>();
            wareList.Add(new Ware(1, 20, 10, "HyldeB"));
        }



        public void DeleteWareByID(int id)
        {
            //Ware w = wareList.Find(x => x.Id == id);
            wareList.RemoveAll(x => x.Id == id);
        }



        public void UpdateWare(Ware w)
        {
            Ware oldWare = wareList.Find(x => x.Id == w.Id);

            oldWare.Price = w.Price;
            oldWare.Amount = w.Amount;
            oldWare.Designation = w.Designation;
        }

        public List<Ware> GetWares()
        {
            return wareList;
        }

        public Ware GetWareById(int id)
        {
            return wareList.Find(x => x.Id == id);
           
        }


    }

}
