using System;

namespace Pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var lastItemsArray = new int[10];
            var maxItemsArray = new int[10];



            int[][] nums = new int[10][];

            for (int i = 0; i < 10; i++)
            {

                nums[i] = new int[random.Next(5, 35)];

                for (int j = 0; j < nums[i].Length; j++)
                {
                    nums[i][j] = random.Next(100);
                }
            }

            foreach (int[] item in nums)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                lastItemsArray[i] = nums[i][nums[i].Length - 1];
            }

            foreach (var i in lastItemsArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                maxItemsArray[i] = nums[i].Max();
            }

            foreach (var i in maxItemsArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
