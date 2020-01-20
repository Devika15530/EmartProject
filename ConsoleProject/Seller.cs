using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Seller
    {
        int sid, smbl;
        string sname, semail, spswd, scompname, gstin, cabout, cadress, cweb;
     public    Seller()
        {

        }


      public   Seller(int id,int mbl,string name,string email,string pswd,string compname,string gstin,string cabout,string cadress,string cweb)
        {
            this.sid = id;
            this.smbl = mbl;
            this.sname = name;
            this.semail = email;
            this.spswd = pswd;
            this.compname = compname;
            this.gstin = gstin;
            this.cabout = cabout;
            this.cadress = cadress;
            this.cweb = cweb;
        }

        public int Id { get => sid; set => sid = value; }
        public string Name { get => sname; set => sname = value; }
        public int Phno { get => smbl; set => smbl = value; }
        public string Cname { get => sname; set => sname = value; }
        public string Gstin { get => gstin; set => gstin = value; }
        public string Email { get => semail; set => semail = value; }
        public string compname { get => compname; set => scompname = value; }



    }
}
