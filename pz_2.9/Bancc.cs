using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace pz_2._9
{
    internal class Bancc
    {
        public int chet;
        public Bancc(int ppp)
        {
            chet = ppp;
        }
        public void sniat(int sum)
        {
            chet -= sum;
        }
        public void vnesti(int sum)
        {
            chet += sum;
        }
    }
}
