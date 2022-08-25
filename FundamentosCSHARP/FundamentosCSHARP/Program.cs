using System;
using System.Collections.Generic;
using FundamentosCSHARP.Models;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
       
            

            List<Bebida> bebidas = new List<Bebida>() { new Bebida("poker", 500 ) };
            bebidas.Add(new Bebida("Costeña", 2000));
            
            foreach(var bebida in bebidas)
            {
                Console.WriteLine(bebida.Nombre);
            }
            Console.ReadKey();
        }
    }
}
