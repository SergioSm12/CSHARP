using System;


namespace MetodoEjem3Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Dias;
            double PagoxDia;

            Console.Write("Ingresa tu Nombre :");
            Nombre = Console.ReadLine();

            Console.Write("Cuanto te pagan por dia ");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.Write("Cuantos dias Trabajaste ?");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine(Nombre + "Tus Ganancias son : " + CalcularTotal(PagoxDia, Dias));

            Console.ReadKey();

        }

        //Metodo para obtener ganancias

        static double CalcularTotal(double PagoDia, int Dia)
        {
            double Total;
            Total = PagoDia * Dia;
            return Total;
        }
    }
}
