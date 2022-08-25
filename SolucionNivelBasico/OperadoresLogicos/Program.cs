using System;


namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            bool resultado;
            a = 2;
            b = 2;
            c = 0;
            d = 205;

            resultado = (a == b) || (c>d);
            Console.WriteLine("resultado es igual a " + resultado);
            Console.ReadKey();
        }
    }
}
