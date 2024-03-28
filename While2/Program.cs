using System;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Factorial de un Numero por Teclado
            int x=1, n, factorial = 1;
            string valor;
            double a;
            float v;

            Console.WriteLine("Digite un Numero Entero");
            valor = Console.ReadLine();
            n = int.Parse(valor);
            //a = Double.Parse(valor);
            //v = float.Parse(valor);

            while(x<=n)
            {

                factorial = factorial * x;
                x = x + 1;
                Console.WriteLine("El Factorial es:" + factorial);

            }

            //Console.WriteLine("El Factorial es:" + factorial);
            Console.ReadLine();
        }
    }
}
