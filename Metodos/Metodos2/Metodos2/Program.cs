using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero 1 : ");
            int numero1 = int.Parse(Console.ReadLine());    
            Console.Write("Ingrese numero 2 : ");
            int numero2=int.Parse(Console.ReadLine());
            
            Console.WriteLine(SumaNumeros(numero1, numero2));

            Console.ReadKey();
        }

        static int SumaNumeros(int numero1, int numero2)
        {
            int resultado = numero1+ numero2;
            return resultado;
        }
    }
}
