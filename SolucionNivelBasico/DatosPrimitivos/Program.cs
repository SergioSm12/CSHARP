using System;

namespace DatosPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            const double Sueldo=2500; //Constante
            dynamic Contenido;

            Contenido = 10;

            Nombre = "Sergio";
            Edad = 39;
            

            Console.WriteLine("Mi nombre es :" + Nombre + " y Mi edad es " + Edad +" y teniendo el sueldo de :" + Sueldo);

            Console.WriteLine("contenido: " + Contenido);
            Console.ReadKey();
        }
    }
}
