using System;


namespace Metodosejem2Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcion;
            int Numero;

            Console.WriteLine("Escoja una opcion : ");
            Console.WriteLine("1 :  Tabla de Suma ");
            Console.WriteLine("2 :  Tabla de Multiplicar ");
            Opcion = int.Parse(Console.ReadLine());
            if(Opcion == 1)
            {
                Console.Write("Digite un numero para la tabla de sumar : ");
                Numero = int.Parse(Console.ReadLine());
                Sumar(Numero);
            }
            else if(Opcion==2)
            {
                Console.Write("Digite el Numero para la tabla de Multiplicar: ");
                Numero = int.Parse(Console.ReadLine());
                Multiplicar(Numero);
            }
            else
            {
                Console.WriteLine("Opcion No valida ");
            }
           
            Console.ReadKey();
        }

        //Metodo de  tabla de suma
        static void Sumar(int Numero)
        {
            for(int i = 1; i<=12; i++)
            {
                Console.WriteLine(Numero + " + " + i + " = " + (Numero + i ));

            }
        }

        //Metodo de la tabla de multiplicar
        static void Multiplicar(int Numero)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Numero + " x " + i + " = " + (Numero * i));
            }
        }


    }
}
