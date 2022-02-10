using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._3
{
    class Account
    {
        public string login;
        public int ID;
        public string email;
        public string pass;
        public DateTime date;
        public Account(string l, int id, string e, string p, DateTime d)
        {
            login = l;
            ID = id;
            email = e;
            pass = p;
            date = d;


        }
        public Account(string l = "unknow", int id = 0, string e = "unknow", string p = "unknow")
        {
            login = l;
            ID = id;
            email = e;
            pass = p;
        }
        public Account(string l, string e, string p)
        {
            login = l;

            email = e;
            pass = p;
        }
        public void GetInfo()
        {
            if (date == DateTime.MinValue)
                Console.WriteLine($"{login} \n{ID} \n{email} \n{pass} ");

            else
                Console.WriteLine($"{login} \n{ID} \n{email} \n{pass} \n{date}");
        }
    }
}
