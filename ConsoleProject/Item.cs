using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Item
    {
       public int itemid, price,stocknum;
      
       public string itemname,ides,remarks;


        //public int Id { get => itemid; set => itemid = value; }
        //public string Name { get => itemname; set => itemname = value; }

        //public int Price { get => price; set => price = value; }
        //public int Num { get => stocknum; set => stocknum = value; }

        //public string Itemdesc { get => ides; set => ides = value; }
        //public string Remarks { get => remarks; set => remarks = value; }


        public Item() { }
        public Item(int itemid,int price,int stocknum,string itemname,string ides,string remarks)
        {
            this.itemid = itemid;
            this.price = price;
            this.stocknum = stocknum;
            this.itemname = itemname;
            this.ides = ides;
            this.remarks = remarks;


        }



    }
}
