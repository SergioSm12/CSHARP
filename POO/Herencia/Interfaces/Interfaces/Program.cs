using System;


namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.MostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Icetex","Consulta auxilios Academicos","09/09/2022");
            Console.WriteLine(av2.GetFecha());
            av2.MostrarAviso();

            Console.ReadKey();


        }
    }

    
}
