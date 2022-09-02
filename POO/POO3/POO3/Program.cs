using System;


namespace POO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine(miVariable.ToString());

            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };

            miVariable=miOtraVariable;

            Console.ReadKey();
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            Punto otroPunto = new Punto();

            double distancia =origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre dos puntos es de : {distancia}");
            Console.WriteLine($"Numero de objetos creados {Punto.GetContadorDeObjetos()}");
        }
    }
}
