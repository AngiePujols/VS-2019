using System;

namespace Casos1
{
    class Program
    {
        static void Main(string[] args)
        {

            int caso;

  
            Console.WriteLine("------Menu--------");
            Console.WriteLine("*****1.Azul*******");
            Console.WriteLine("*****2.Rojo*******");
            Console.WriteLine("*****3.Verde******");
            Console.WriteLine("***4.Amarillo*****");
            Console.WriteLine("****5.Blanco******");
            Console.WriteLine("****6.Negro******");
            Console.WriteLine("      ");
            Console.WriteLine("~~~~Digite su Numero~~~~");
            caso = Convert.ToInt32(Console.ReadLine());

            if (caso>10 || caso<0)
            {
                Console.WriteLine("Tiene que Digitar un Numero");
            }

            switch (caso)

            {
                case 1:
                    Console.WriteLine("Ha Elegido la Opcion Azul");
                    break;

                case 2:
                    Console.WriteLine("Ha Elegido la Opcion Rojo");
                    break;

                case 3:
                    Console.WriteLine("Ha Elegido la Opcion Verde");
                    break;

                case 4:
                    Console.WriteLine("Ha Elegido la Opcion Amarillo");
                    break;

                case 5:
                    Console.WriteLine("Ha Elegido la Opcion Blanco");
                    break;

                case 6:
                    Console.WriteLine("Ha Elegido la Opcion Negro");
                    break;

                default:
                    Console.WriteLine("Opcion no Valida");
                    break;


            }



        }
    }
}
