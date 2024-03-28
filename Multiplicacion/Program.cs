using System;

namespace Multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int a=0;
            
            Console.WriteLine("Digite un Numero Para Ser Multiplicado Hasta el 12");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" ");
            
            while(a <= 12)
            {
                Console.WriteLine(num1 + "x" + a + "=" + (a * num1));
                a++;
            }

            Console.ReadLine();

        }
    }
}
