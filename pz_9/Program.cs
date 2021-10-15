using System;
using System.Collections.Generic;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sizeArray = random.Next(10, 25);
            char[,] array = new char[sizeArray, sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    array[i, j] = (char)('A' + random.Next(0, 25));
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    if (dict.ContainsKey(array[i, j]))
                    {
                        dict[array[i, j]]++;
                    }
                    else
                    {
                        dict.Add(array[i, j], 1);
                    }

                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<char, int> keyValue in dict)
            {
                Console.WriteLine($"Буква {keyValue.Key} повторяется {keyValue.Value} раз(-а)");
            }
        }
    }
}
        
    
