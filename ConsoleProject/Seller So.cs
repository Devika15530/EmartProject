using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class SellerSo:Seller
    {

        List<Seller> l1 = new List<Seller>();
       

        public bool Signin(int sid, string spswd)
        {
            
         Seller b = l1.Find(res => sid.Equals(res.Id));
            if (b != null)
                return true;
            else return false;
        }


        public string Register(int sid, int snum,string sname, string semail,string spswd, string compname,string gstin,string cabout, string adress, string cweb )
        {
            l1.Add(new Seller(sid,snum, sname,semail, spswd, compname, gstin, cabout, adress, cweb));
            return "registered succesfully";


        }

        ItemBo ib = new ItemBo();
        public void show()
        {
            int c, n;
            do
            {

                Console.WriteLine("menu 1.Add items\n 2.Search items \n 3.See items \n   4.Additemstosub");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("enter category id");
                            int catid = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter category name");
                            string catname = Console.ReadLine();
                            Console.WriteLine("enter subcategory id");
                            int subcid = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter category name");
                            string subcname = Console.ReadLine();

                            Console.WriteLine("enter subcategory description");
                            string subdesc = Console.ReadLine();

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
                            ib.AddItem(itemid, catid, subcid, itemname, catname, subcname, itemstock, itemprice, itemdesc, itemremarks, subdesc);
                            Console.WriteLine("do you want to continue");
                            c = int.Parse(Console.ReadLine());


                        } while (c == 1);

                        break;

                    case 2:
                        ib.Search();
                        break;
                    case 3:
                        ib.DisplayProducts();
                        break;
                    case 4:
                        
                        Console.WriteLine("enter subcategory id");
                        int asi = int.Parse(Console.ReadLine());
                        ib.Add(asi);

                        break;
                       

                }

                Console.WriteLine("do you want to perform another operation");
                n = int.Parse(Console.ReadLine());
            } while (n == 1);



        }
        

    }
}
