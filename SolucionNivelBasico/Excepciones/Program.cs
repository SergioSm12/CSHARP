using System;


namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edad;
            try
            {
                Console.Write("Ingresa tu edad : ");
                Edad = int.Parse(Console.ReadLine());
                Console.Write(Edad);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

 
            Console.ReadKey();
        }
    }
}
