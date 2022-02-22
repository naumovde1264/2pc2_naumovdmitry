using System;

namespace pz_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2020, 07, 13);
            Account2 acc = new Account2("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d);
            acc.GetInfo();
            DateTime d1 = new DateTime(1000, 07, 13);
            Account2 acc1 = new Account2("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d1);
            acc1.GetInfo();
            DateTime d2 = new DateTime(1000, 07, 13);
            Account2 acc2 = new Account2("", "", 666, "1", d2);
            acc2.GetInfo();
            DateTime d3 = new DateTime(2023, 07, 13);
            Account2 acc3 = new Account2("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d3);
            acc3.GetInfo();
            Console.WriteLine("users:" + Account2.GetCounter());
        }
        
    } 
}
