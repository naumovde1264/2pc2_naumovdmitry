using System;

namespace pz_5
{
    class Program
    {

        static void Main(string[] args)
         
      
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("задание №1");
            int i;
            for (i = 10; i <= 80; i = i + 4)
                Console.WriteLine(i);
            Console.WriteLine();

            Console.WriteLine("задание №2");
            int j;
            {
                for (j = 4; j < 16; j++)
                    Console.WriteLine(letters[j]);

            }
            Console.WriteLine("задание №3");
            int e;
            for (e = 0; e < 7; e++)
                Console.WriteLine("#######");

            Console.WriteLine("задание №4");
            int g;
            for (g = 0; g < 100; g++)
                if (g % 5 == 4)
                    Console.Write(g + " ");
           
            

                
                
          

        }
        
           
    }
}
