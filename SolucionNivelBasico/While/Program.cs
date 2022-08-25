using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            int Correlativo;
            Correlativo = 1;
            Console.WriteLine("La Tabla #5");

            while (Correlativo<=12)
            {
                Console.WriteLine("5 x " + Correlativo + " = " + (5 * Correlativo));
                Correlativo++;

            }

            Console.ReadKey();
        }
    }
}
