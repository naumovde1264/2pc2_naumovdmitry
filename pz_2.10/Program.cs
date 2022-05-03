using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr217_2
{
    class MyClass
    {
        public int n;
    }
    class Program
    {
        unsafe static void Main()
        {
            fixed (int* p = &new MyClass().n)
            {
                char* s = (char*)p;
                *s = 'A';
                *(s + 1) = 'B';
                Console.WriteLine("Значение поля n = " + (*p));
            }
        }
    }
}