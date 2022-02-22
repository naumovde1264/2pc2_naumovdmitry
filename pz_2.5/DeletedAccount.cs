using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._5
{
    class DeletedAccount: Account3 
    {
      public string Reason { get; set; }
        public DeletedAccount(string l, string e, int i, string p, DateTime d, string r) 
            :base(l, e, i, p, d)
        {
            Reason = r;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Reason);
        }
    }   
}
