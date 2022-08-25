using System;


namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] Nombres = { "Victor", "Sergio", "David"};

            Console.WriteLine("Contenido del vector :");
            for(int i =0; i <Nombres.Length; i++ ) 
            {
                Console.WriteLine("Posicion: " + i + " = " + Nombres[i]);
            }
            
            
            Console.ReadKey();
        }
      
    }
}
