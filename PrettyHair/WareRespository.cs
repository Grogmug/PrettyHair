using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class WareRepository
    {
        public List<Ware> wareList;

        public WareRepository()
        {
            wareList = new List<Ware>();
            wareList.Add(new Ware(1, 20, "Shampoo: Feeling Good Hair"));
            wareList.Add(new Ware(2, 30, "Awesome Saks"));
            wareList.Add(new Ware(3, 5, "Rusten Saks"));
            wareList.Add(new Ware(4, 100, "Butters Creamy Goo"));
            wareList.Add(new Ware(5, 50, "Hair Color"));
            wareList.Add(new Ware(6, 25, "HairClue"));
            wareList.Add(new Ware(7, 60, "Stor Saks"));
            wareList.Add(new Ware(8, 40, "Balsam"));


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
            
            oldWare.Description = w.Description;
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
