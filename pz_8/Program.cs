using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arrayInt = new int[10];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = rand.Next(0, 50);
            }
            Console.Write("Массив до: ");
            foreach (int i in arrayInt)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Array.Sort(arrayInt);
            Console.Write("Массив после: ");
            foreach (int i in arrayInt)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
