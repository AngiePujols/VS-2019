using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 0;
            int e = 20;
       

            while (x <= e)
            {

                int i = 1;
                while (i <= x)
                {

                    Console.Write("*");
                    i++;

                }
                Console.WriteLine();
                x++;
            }
            Console.ReadLine();


            
        }
    }
}
