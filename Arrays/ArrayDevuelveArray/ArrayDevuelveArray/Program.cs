using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDevuelveArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = LeerDatos();

            foreach (int element in arrayElements) Console.WriteLine(element);
            int suma = SumaArrays(arrayElements);

            Console.WriteLine("La suma de los elementos del array es : " + suma);

            Console.ReadKey();

        }

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos quieres que tenga el array : ");
            string tamaño = Console.ReadLine();

            int numElementos = int.Parse(tamaño);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.Write($"Introduzca el dato para la posicion {i} : ");
                tamaño = Console.ReadLine();

                int datosRelleno = int.Parse(tamaño);

                datos[i] = datosRelleno;
            }
            return datos;
        }

        static int SumaArrays(int[] datos)
        {
            int suma = 0;
            for(int i=0; i<datos.Length; i++)
            {
                suma+=datos[i];
            }

            return suma;
        }

    }
}
