using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
   class SubCategory:Categories
    {
    public string scname;
     public    string scdesc;
      public  int scid;
        //public int Scid { get=>scid; set =>scid=value; }
        //public string ScName { get => scname; set => scname = value; }

        public SubCategory()
        {

        }
        public SubCategory(int cid,string cname,int sid,string sname,string desc):base(cid,cname)
        {
            this.scid = sid;
            this.scname = sname;
            this.scdesc = desc;

        }






        //public void  AddSubCat()
        //{

        //    Console.WriteLine("enter category id that u want to add subcategories");
        //    int temp = int.Parse(Console.ReadLine());

              




        //}


              









        //public static  void SubOfElectronics()
        //{

        //    Console.WriteLine("available items are 1.tv 2.fridge");

        //    int se = int.Parse(Console.ReadLine());



        //}

        //   public static  void SubOfFashion()
        //{

        //}



    }
}
