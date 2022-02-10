using System;

namespace pz_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2022, 07, 13);
            Account acc = new Account("salo", 666, "marylinmanson@gmail.com", "MatItoPloho", d);
            acc.GetInfo();
            Account acc1 = new Account("salo", 666, "marylinmanson@gmail.com", "MatItoPloho");
            acc1.GetInfo();
            Account acc2 = new Account("salo", "marylinmanson@gmail.com", "MatItoPloho");
            acc2.GetInfo();
            Account acc3 = new Account("salo", 666, "marylinmanson@gmail.com");
            acc3.GetInfo();
        }
    }
}
