using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;


            //Categories cat = new Categories();
            BuyerBo bb = new BuyerBo();
            SellerSo ss = new SellerSo();
            do
            {
                Console.WriteLine("menu: \n 1.Buyer \n 2.Seller");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:


                        Console.WriteLine("a.signin \n b.Register");
                        string ch1 = Console.ReadLine();
                        switch (ch1)
                        {
                            case "a":
                                Console.WriteLine("enter your Buyer id");
                                int uid = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter your password");
                                string upswd = Console.ReadLine();
                                bool x = bb.Signin(uid, upswd);
                                if (x == true)
                                {
                                    Console.WriteLine("valid user");
                                    bb.Display();
                                }
                                else
                                    Console.WriteLine("not valid");



                                break;
                            case "b":


                                Console.WriteLine("enter your buyer id");
                                int bid = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter your name");
                                string bname = Console.ReadLine();
                                Console.WriteLine("enter your email id");
                                string bemail = Console.ReadLine();
                                Console.WriteLine("enter your password");
                                string bpswd = Console.ReadLine();
                                Console.WriteLine("enter your mobile number");
                                int bmbl = int.Parse(Console.ReadLine());
                                Console.WriteLine(bb.Register(bid, bname, bpswd, bemail, bmbl));
                                bb.Display();
                                break;
                        }
                        break;

                    case 2:


                        Console.WriteLine("a.Register \n b.signin");
                        string ch2 = Console.ReadLine();
                        switch (ch2)
                        {
                            case "a":
                                Console.WriteLine("enter your seller id");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter your password");
                                string pswd = Console.ReadLine();
                                bool x = ss.Signin(id, pswd);
                                if (x == true)
                                    Console.WriteLine("valid user");
                                else
                                    Console.WriteLine("not valid");
                                ss.show();

                                break;
                            case "b":


                                Console.WriteLine("enter your seller id");
                                int sid = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter your name");
                                string sname = Console.ReadLine();
                                Console.WriteLine("enter your email id");
                                string semail = Console.ReadLine();
                                Console.WriteLine("enter your password");
                                string spswd = Console.ReadLine();
                                Console.WriteLine("enter your mobile number");
                                int smbl = int.Parse(Console.ReadLine());

                                string compname = Console.ReadLine();
                                Console.WriteLine("enter company GSTIN");
                                string gstin = Console.ReadLine();
                                Console.WriteLine("enter breif details about company");
                                string cabout = Console.ReadLine();
                                Console.WriteLine("enter address of the company");
                                string adress = Console.ReadLine();
                                Console.WriteLine("enter company website");
                                string cweb = Console.ReadLine();
                                Console.WriteLine(ss.Register(sid, smbl, sname, semail, spswd, compname, gstin, cabout, adress, cweb));
                                ss.show();
                                break;
                        }




                        //DateTime dt = DateTime.Now;
                        //Console.WriteLine("buyer account created on "+dt.Month+dt.Day+dt.Year);



                        break;




                }
                Console.WriteLine("enter 1 do u want to continue");
                cont = int.Parse(Console.ReadLine());
            } while (cont == 1);
            Console.ReadLine();
        }



    }
}
