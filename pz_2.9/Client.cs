﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._9
{
    internal class Client

    {
        Bancc chett;
        public event MyDelegate MyEvent;
        public Client(Bancc a)
        {
            chett = a;
        }
        public void slejka()
        {
            if (chett.chet <= 100)
            {
                if (MyEvent != null)
                {
                    MyEvent -= NotError;
                    MyEvent -= Error;
                    MyEvent += Error;
                    MyEvent();
                }
            }
            else
            {
                if (MyEvent != null)
                {
                    MyEvent -= Error;
                    MyEvent -= NotError;
                    MyEvent += NotError;
                    MyEvent();
                }
                else
                {
                    MyEvent += NotError;
                    MyEvent();
                }
            }
        }
        private void Error()
        {
            Console.WriteLine($"Недостаточно средств: {chett.chet}");
        }
        private void NotError()
        {
            Console.WriteLine($"Деньги есть: {chett.chet}");
        }
    }
}