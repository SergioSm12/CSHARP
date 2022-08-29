using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo1;

            circulo1 = new Circulo();
            Console.Write("Ingrese radio");
            int radio;
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine($"El area del circulo con radio {radio} es de: "+circulo1.CalculoArea(radio));
           

            Circulo circulo2 = new Circulo();
            Console.WriteLine(circulo2.CalculoArea(3));
            

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(3500);
            Console.WriteLine(obj.Convierte(4));
            Console.ReadKey();

        }
    }

    class Circulo
    {
        private const double pi = 3.1416;

        public double CalculoArea(int radio)
        {
            return pi * radio * radio;
        }

        

    }

    class ConversorEuroDolar
    {
        private double euro = 1.269;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;

        }

        public void CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor <= 0) euro = 1.253;

            else
                euro = nuevoValor;
        }

    }
}
