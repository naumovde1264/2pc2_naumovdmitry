using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            float h = 0.1f;
            float a = 1.45f;
            float b = 2.3f;
            while (0 <= x && x <= 1)
            {
                double y = x + b * x * Math.Sin(a);
                Console.WriteLine($" x = {x} y = {y}");
                x = Math.Round(x + h, 1);
            }

        }
    }
}
