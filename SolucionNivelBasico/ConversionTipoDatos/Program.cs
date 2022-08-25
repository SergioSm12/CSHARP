using System;


namespace ConversionTipoDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            String Nombre;
            int edad;
            bool casado;
            double sueldo;

            Console.Write("ingrese su nombre :");
            Nombre = Console.ReadLine();
            
            Console.Write("Ingrese su Edad : ");
            //edad = int.Parse(Console.ReadLine());
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su estado civil ? : ");
            //casado = bool.Parse(Console.ReadLine());
            casado = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingresa tu sueldo : ");
            //sueldo = double.Parse(Console.ReadLine());
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your name is " + Nombre);
            Console.WriteLine("your age is : " + edad);
            Console.WriteLine("Your marital status is :"+ casado);
            Console.WriteLine("Your salary is :" + sueldo);

            Console.ReadKey();

        }
    }
}
