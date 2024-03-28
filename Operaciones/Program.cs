using System;


namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;
            int resta;
            int multiplicacion;
            int division;
            num1 = 19;
            num2 = 34;
            suma = num1 + num2;

            Console.WriteLine("+++Suma+++");
            Console.WriteLine("{0} + {1} = {2}", num1, num2, suma);
            Console.WriteLine("La Suma es: {0}", suma);

            Console.WriteLine("-----------------------------------");
            num1 = 138;
            num2 = 89;
            resta = num1 - num2;
            Console.WriteLine("---Resta---");
            Console.WriteLine("{0} - {1} = {2}", num1, num2, resta);
            Console.WriteLine("La Resta es: {0}", resta);
            Console.WriteLine("-----------------------------------");
            num1 = 12;
            num2 = 76;
            multiplicacion = num1 * num2;
            Console.WriteLine("***Multiplicación***");
            Console.WriteLine("{0} x {1} = {2}", num1, num2, multiplicacion);
            Console.WriteLine("La Multiplicación es: {0}", multiplicacion);

            Console.WriteLine("-----------------------------------");
            num1 = 500;
            num2 = 50;
            division = num1 / num2;
            Console.WriteLine("÷÷÷División÷÷÷");
            Console.WriteLine("{0} ÷ {1} = {2}", num1, num2, division);
            Console.WriteLine("La División es: {0}", division);

        }
    }
}
