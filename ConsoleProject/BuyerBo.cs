using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class BuyerBo:Buyer
    {
        ItemBo ib = new ItemBo();

        bool b;
        List<Buyer> l = new List<Buyer>();
        public bool  Signin(int id,string pswd)
        {
            

            Buyer b = l.Find(res => id.Equals(res.Id));
           
            if (b != null)
                return true;
            else return false;


                                   
        }

      

        public string Register(int bid,string bname,string bpswd,string bemail,int bnum)
        {
            l.Add(new Buyer(bid, bname, bpswd, bemail, bnum));
            return "registered succesfuully";
        }

        public void Display()
        {
            Console.WriteLine("Menu 1.Display 2.Search 3.Exit \n enter your choice");
            int op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    ib.DisplayProducts();
                    break;
                case 2:
                    ib.Search();
                    break;

            }

        }
    }
}
