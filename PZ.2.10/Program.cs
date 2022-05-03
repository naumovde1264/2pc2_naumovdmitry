using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PZ._2._10
{
    class Pobeditel_po_Jizni
    {
        public int joke;
    }
    class Program
    {
        unsafe static void Main()
        {
            fixed (int* ui = &new Pobeditel_po_Jizni().joke)
            {
                char* peremennaya = (char*)ui;
                *peremennaya = 'A';
                *(peremennaya + 1) = 'B';
                Console.WriteLine("Значение поля joke = " + (*ui));
            }
        }
    }
}
