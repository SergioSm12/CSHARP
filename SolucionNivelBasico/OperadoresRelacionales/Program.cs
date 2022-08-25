using System;


namespace OperadoresRelacionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            bool Operaciones;

            num1 = 10;
            num2 = 5;
            Operaciones = (num1 >= num2);

            Console.WriteLine("num1 es mayor o igual que num2 " + Operaciones);
            Console.ReadKey();           

        }
    }
}
