using System;


namespace Mayor,Medio y Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;

            string cadena;


            Console.WriteLine("Ingrese su Cadena");

            cadena = Console.ReadLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine(cadena);

            Console.WriteLine("Ingrese su  Primer Numero");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese su Segundo Numero");

            num2 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine(" {0} + {1} = La suma es: {2}", num1, num2, suma);




        }
    }
}
