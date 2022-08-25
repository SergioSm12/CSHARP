using System;


namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];

            Persona[0, 0] = "SERGIO";
            Persona[0, 1] = "Mesa";

            Persona[1, 0] = "David";
            Persona[1, 1] = "Buitrago";

            Persona[2, 0] = "Juan";
            Persona[2, 1] = "Gomez";


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Persona [" + i + "] = " + Persona[i, 0] + " " + Persona[i, 1]);
            }
            Console.ReadKey();
        }
    }
}
