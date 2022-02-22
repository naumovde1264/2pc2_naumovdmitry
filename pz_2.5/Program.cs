using System;

namespace pz_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2020, 07, 13);
            Account3 acc = new Account3("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d);
            acc.GetInfo();
            DateTime d1 = new DateTime(1000, 07, 13);
            Account3 acc1 = new Account3("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d1);
            acc1.GetInfo();
            DateTime d2 = new DateTime(1000, 07, 13);
            Account3 acc2 = new Account3("", "", 666, "1", d2);
            acc2.GetInfo();
            DateTime d3 = new DateTime(2023, 07, 13);
            Account3 acc3 = new Account3("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d3);
            acc3.GetInfo();
            Console.WriteLine("users:" + Account3.GetCounter());
            DeletedAccount acc4 = new DeletedAccount("salo", "marylinmanson@gmail.com", 666, "MatItoPloho", d3, "Rugalsa Matom");
            acc4.GetInfo();
            Console.WriteLine("Hello, World!");
        }
    }
}
