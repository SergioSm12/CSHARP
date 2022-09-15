using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            manejoArchivos miarchivo = new manejoArchivos();

            miarchivo.mensaje();

            Console.ReadKey();
        }
    }

    class manejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        public manejoArchivos()
        {
            archivo = new StreamReader(@"C:\Cursos\CSHARP\Fichero.txt");

            while ((linea = archivo.ReadLine()) != null)
            {

                Console.WriteLine(linea);
                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("Hay {0} lineas", contador);

        }

        ~manejoArchivos()
        {
            archivo.Close();
        }
    }
}
