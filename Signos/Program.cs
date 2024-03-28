namespace Signos
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Ingrese su  Primer Numero");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese su Segundo Numero");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su Tercer Numero");
            num3 = Convert.ToInt32(Console.ReadLine());

			if (num1 > num2 && num1 > num3 && num2 > num3)
			{
				Console.WriteLine("El Mayor es:{0}", num1);
				Console.WriteLine("El del Medio es:{0} ", num2);
				Console.WriteLine("El Menor es:{0} ", num2);
			}

			else
			if (num2 > num1 && num3 > num1 && num3 > num2)
			{
				Console.WriteLine("El Mayor es:{0}", num3);
				Console.WriteLine("El del Medio es:{0} ", num2);
				Console.WriteLine("El Menor es:{0} ", num1);
			}

			else
			if (num1 > num2 && num1 > num3 && num2 > num3)
			{
				Console.WriteLine("El Mayor es:{0}", num1);
				Console.WriteLine("El del Medio es:{0} ", num3);
				Console.WriteLine("El Menor es:{0} ", num2);
			}

			else
			if (num2 > num1 && num2 > num3 && num3 > num1)
			{
				Console.WriteLine("El Mayor es:{0}", num2);
				Console.WriteLine("El del Medio es:{0} ", num3);
				Console.WriteLine("El Menor es:{0} ", num1);
			}

			else
			if (num3 > num1 && num3 > num2 && num1 > num2)
			{
				Console.WriteLine("El Mayor es:{0}", num3);
				Console.WriteLine("El del Medio es:{0} ", num1);
				Console.WriteLine("El Menor es:{0} ", num2);
			}
			else
			if (num2 > num1 && num1 > num3 && num2 > num3)

			{
				Console.WriteLine("El Mayor es:{0}", num2);
				Console.WriteLine("El del Medio es:{0} ", num1);
				Console.WriteLine("El Menor es:{0} ", num3);
			}
		}
    }
    }
