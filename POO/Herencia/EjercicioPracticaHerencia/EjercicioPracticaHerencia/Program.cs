using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Nissan GTR");
            Avion avion1 = new Avion("Airbus319");

            


            Vehiculo [] AlmacenVehiculos = new Vehiculo[2];
            AlmacenVehiculos[0] = coche1;
            AlmacenVehiculos[1] = avion1;
            for(int i=0; i < AlmacenVehiculos.Length; i++)
            {
                AlmacenVehiculos[i].GetModelo();
                AlmacenVehiculos[i].Conducir();
            }
            Console.ReadKey();
        }
    }

    class Vehiculo
    {
        private string Modelo;

        public Vehiculo(string modelo)
        {
            this.Modelo = modelo;
        }

        public void ArrancarMotor()
        {
            Console.WriteLine("Estoy Prendiendo");
        }

        public void PararMotor()
        {
            Console.WriteLine("Estoy Apagando");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Me pueden conducir");
        }

        public void GetModelo()
        {
            Console.WriteLine("El modelo es " + this.Modelo);
        }
    }

    class Avion: Vehiculo
    {
        public Avion(string modeloAvion) : base(modeloAvion)
        {

        }
        public void Volar()
        {
            Console.WriteLine("Puedo Volar");
        }

        public override void Conducir()
        {
            Console.WriteLine("Me pueden pilotar");
        }

    }

    class Coche:Vehiculo
    {
        public Coche(string ModeloCoche) : base(ModeloCoche)
        {

        }
        public void Ruedas()
        {
            Console.WriteLine("Tengo 4 Ruedas");
        }

        public override void Conducir()
        {
            Console.WriteLine("Me pueden conducir por tierra");
        }
    }
}
