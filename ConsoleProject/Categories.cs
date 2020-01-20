using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
 abstract class Categories
    {
      public  int cid;
        public string cname;

        public Categories()
        {

        }
     
public  Categories(int id,string name)
        {
            this.cid = id;
            this.cname = name;
        }












































        //int catid;
        //string catname, catdesc;
        //List<Categories> lc = new List<Categories>();
        //public Categories()
        //{

        //}
        //public Categories(int id, string name, string desc)
        //{
        //    this.catid = id;
        //    this.catname = name;
        //    this.catdesc = desc;
        //}

        //public void AddCategories()
        //{
        //    Console.WriteLine("enter how many categories do you want to enter");
        //    int categ = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < categ; i++)
        //    {
        //        Console.WriteLine("enter category id");
        //        catid = int.Parse(Console.ReadLine());
        //        Console.WriteLine("enter category name");
        //        catname = Console.ReadLine();

        //        Console.WriteLine("enter category description");
        //        catdesc = Console.ReadLine();
        //        lc.Add(new Categories(catid, catname, catdesc));
        //    }


        //}


        //public override string ToString()
        //{
        //    return "category id" + this.catid + "categorgy name" + this.catname + "description" + this.catdesc;
        //}


        //public void Display()
        //{
        //    Console.WriteLine("avaliable categories");
        //    foreach (Categories ce in lc)
        //    {
        //        Console.WriteLine(ce.ToString());
        //    }

        //    Console.WriteLine("enter what cateogry do you want to buy");
        //    int op = int.Parse(Console.ReadLine());
        //    switch (op)
        //    {
        //        case 1:
        //            Console.WriteLine(" in electronics we have");
        //            SubCategory.SubOfElectronics();
        //            break;

        //        case 2:
        //            Console.WriteLine("in fashion we have");
        //            SubCategory.SubOfFashion();
        //            break;
        //    }

        //}


        //public void SellerDisplay()
        //{
        //    Console.WriteLine("avaliable categories");
        //    foreach (Categories ce in lc)
        //    {
        //        Console.WriteLine(ce.ToString());
        //    }

        //}

    }
}
