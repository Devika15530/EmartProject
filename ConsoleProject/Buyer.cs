using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{ 
   
 
 public    class Buyer

    {
        int bid,bnum;
        string bname, bemail, bpswd;
        public Buyer()
        {

        }
        public Buyer(int id,string name,string email,string pswd,int num)
        {
            this.bid = id;
            this.bname = name;
            this.bemail = email;
            this.bpswd = pswd;
            this.bnum = num;
        }

        public int Id { get => bid; set => bid = value; }
        public string Name { get => bname; set => bname = value; }
        public int Num { get => bnum; set => bnum = value; }
      
        public string Pswd { get => bpswd; set => bpswd = value; }
        public string Email { get => bemail; set => bemail = value; }
    }


}




