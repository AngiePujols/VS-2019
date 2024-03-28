using System;

namespace Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 11;
            int suma = 0;
            while (contador <= 197)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                    suma = suma + contador;
                }
                contador++;
            }
            Console.WriteLine("La Suma es: " + suma);
            Console.ReadLine();
        }
    }
}
