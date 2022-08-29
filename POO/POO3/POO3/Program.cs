using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
            Console.ReadKey();
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);

            double distancia =origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre dos puntos es de : {distancia}");
        }
    }
}
