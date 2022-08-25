using System;
using System.Collections.Generic;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0 };


            
            for(int i=0; i<numeros.Length; i ++)
            {
                Console.WriteLine("Iteracion: "+ i +" = "+numeros[i]);
            }

            foreach(var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("**********************");
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            lista.Add(9);
            lista.Add(10);
            lista.Remove(2);

            foreach(var number in lista)
            {
                Console.Write(number);
            }
            
            Console.ReadKey();
        }
    }
}
