using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class ItemBo:SubCategory
    {


        SubCategory sc = new SubCategory();
      public  static List<SubCategory> lc = new List<SubCategory>();
        public static List<Item> li = new List<Item>();
        public void AddItem(int id, int cid, int scid, string iname, string cname, string scname, int noi, int price, string idesc, string remarks, string scdesc)
        {

            SubCategory cat = new SubCategory( cid,cname,scid,scname,scdesc);
            Item item = new Item(id,price,noi,iname,idesc,remarks);
            lc.Add(cat);
            li.Add(item);

            Console.WriteLine("items are added to the list");

        }

        public void Add(int i)
        {
            foreach(SubCategory x in lc)
            {
                if(x.scid==i)
                {
                    Console.WriteLine("how many items do u want to enter");
                    int hno = int.Parse(Console.ReadLine());
                    for (int l = 0; l < hno; l++)
                    {
                        Console.WriteLine("enter Item id");
                        int itemid = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter Item price");
                        int itemprice = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter Item stocknum");
                        int itemstock = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter item name");
                        string itemname = Console.ReadLine();
                        Console.WriteLine("enter item desc");
                        string itemdesc = Console.ReadLine();
                        Console.WriteLine("enter item remarks");
                        string itemremarks = Console.ReadLine();
                        Item item = new Item(itemid, itemprice, itemstock, itemname, itemdesc, itemremarks);
                        li.Add(item);
                    }
                }
            }
        }


        public void DisplayProducts()
        {
            Console.WriteLine("Category Id \t Category Name");
            foreach (Categories i in lc)
            {
                Console.WriteLine(i.cid + "\t" + i.cname);
            }

            Console.WriteLine("Enter Cid for which you want to go to Subcategory");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("SubCategory Id \t SubCategory Name  \t SubCategory Desc");
            foreach (SubCategory i in lc)
            {
                if (i.cid == ch)
                {

                    Console.WriteLine(i.scid + "\t" + i.scname + "\t" + i.scdesc);
                }
            }

            Console.WriteLine("Enter scid for which you want to go to Items");
            int ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Item Id \t Item Name \t Item Quantity \t Item Price \t Item Description");


            foreach (SubCategory i in lc)
            {
                foreach (Item ii in li)
                {
                    if (i.scid == ch1)
                    {

                        Console.WriteLine(ii.itemid + "\t" + ii.itemname + "\t" + ii.stocknum + "\t" + ii.price + "\t" + ii.ides + "\t" + ii.remarks);
                    }

                }
            }



        }


        public void Search()
        {
            Console.WriteLine("1.Search By Item Number");
            Console.WriteLine("2.Search By Item Name");
            Console.WriteLine("Enter Your Choice");
            int ch = int.Parse(Console.ReadLine());
            String s = "";
            int f = 0;
            if (ch == 1)
            {
                Console.WriteLine("Enter Item NO that you want to search");
                int n = int.Parse(Console.ReadLine());
                foreach (Item i in li)
                {
                    if (i.itemid == n)
                    {

                        s = i.itemid + "\t" + i.itemname + "\t" + i.stocknum + "\t" + i.price + "\t" + i.ides;
                        break;
                    }
                    else
                        f = 1;
                }
            }
            else
            {
                Console.WriteLine("Enter Item Name that you want to search");
                String name = Console.ReadLine();

                foreach (Item i in li)
                {
                    if (i.itemname == name)
                    {
                        s = i.itemid + "\t" + i.itemname + "\t" + i.stocknum + "\t" + i.price + "\t" + i.ides;
                        break;
                    }
                    else
                        f = 1;
                }
            }
            if (f == 1)
                Console.WriteLine("Item Not Found");
            else
            {
                Console.WriteLine("Item Id \t Item Name \t Item Quantity \t Item Price \t Item Description");
                Console.WriteLine(s);
            }
        }
    }
}



























                //Console.WriteLine("enter how many categories do you want to enter");
                //int categ = int.Parse(Console.ReadLine());
                //for (int i = 0; i < categ; i++)
                //{
                //    Console.WriteLine("enter category id");
                //  int  catid = int.Parse(Console.ReadLine());
                //    Console.WriteLine("enter category name");
                //   string catname = Console.ReadLine();


                //    Console.WriteLine("enter subcategories");
                //    Console.WriteLine("enter how many sub categories do you want to enter");
                //    int subcateg = int.Parse(Console.ReadLine());
                //    for (int j = 0; j < subcateg; j++)
                //    {
                //        Console.WriteLine("enter sub category id");
                //        int subid = int.Parse(Console.ReadLine());
                //        Console.WriteLine("enter category name");
                //        string subname = Console.ReadLine();
                //        Console.WriteLine("enter category description");
                //        string catdesc = Console.ReadLine();


                //        lc.Add(new SubCategory(catid, catname, subid, subname, catdesc));
                //    }
            
       
