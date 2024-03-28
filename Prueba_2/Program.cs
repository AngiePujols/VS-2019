using System;

namespace Prueba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double valor1;
            double valor2;
            double resultado;
            string opcion;

            Console.WriteLine("Suma");
            Console.WriteLine("Resta");
            Console.WriteLine("Multiplicacion");
            Console.WriteLine("Division");

            Console.WriteLine("Elija una Opción");
            opcion = Console.ReadLine();
            Console.WriteLine("Digite en el valor 1");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite en el valor 2");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();


            if (opcion == "Suma")
            {
                resultado = valor1 + valor2;
                Console.WriteLine("{0} + {1}= {2}", valor1, valor2, resultado);
                Console.ReadLine();
            }
            if (opcion == "Resta")
            {
                resultado = valor1 - valor2;
                Console.WriteLine("{0} - {1}= {2}", valor1, valor2, resultado);
                Console.ReadLine();
            }
            if (opcion == "Multiplicacion")
            {
                resultado = valor1 * valor2;
                Console.WriteLine("{0} x {1}= {2}", valor1, valor2, resultado);
                Console.ReadLine();
            }
            if (opcion == "Division")
            {
                resultado = valor1 / valor2;
                Console.WriteLine("{0} / {1}= {2}", valor1, valor2, resultado);
                Console.ReadLine();
            }

        }

    
    }
  
}
