using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._5
{
    class Account3
    {
        string password;
        string login;
        DateTime date;
        string email;
        int id;
        static int count = 0;
        public string Login
        {
            get { return login; }
            set
            {
                if (value == "") login = "unknow";
                else login = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 8) password = "unknow";
                else password = value;
            }
        }
        public int ID
        {
            get { return id; }
            set
            {
                if (value == 0) id = 999;
                else id = value;
            }

        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value == "") email = "unknow";
                else email = value;
            }
        }
        DateTime Date
        {
            get { return date; }
            set
            {
                if (value < new DateTime(2000, 01, 01) || value > new DateTime(2022, 01, 01))
                {
                    date = new DateTime(0001, 01, 01);
                }
                else date = value;
            }

        }
        public Account3(string l, string e, int i, string p, DateTime d)
        {
            Login = l;
            Email = e;
            ID = i;
            Password = p;
            Date = d;
            if (d > new DateTime(2020, 01, 01)) count++;

        }
        public static int GetCounter()
        {
            return count;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{login} \n{id} \n{email} \n{password} \n{date}");
        }
    }
}
