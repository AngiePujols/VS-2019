using System;

namespace Casos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int caso;
            string caso1;
            Console.WriteLine("Digite su Numero");
            caso = Convert.ToInt32(Console.ReadLine());
           
            if (caso < 0 || caso > 10)
            {
                Console.WriteLine("Tiene que Digitar un Numero");
            }
           
            switch (caso)
          
            {
                case 1:
                    Console.WriteLine("Ha Elegido la Opcion 1");
                    break;

                case 2:
                    Console.WriteLine("Ha Elegido la Opcion 2");
                    break;
                
                case 3:
                    Console.WriteLine("Ha Elegido la Opcion 3");
                    break;

                default:
                    Console.WriteLine("Opcion no Valida");
                    break;


            }
            
            

        }
    }
}
