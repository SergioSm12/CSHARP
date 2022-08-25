using System;


namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            IngresoDatos();
           Console.ReadKey();
        }

        // Mi primer Metodo 

        static void IngresoDatos()
        {
            string Nombre;
            Console.Write("Ingresa tu nombre : ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre);
        
        }


    }
}
