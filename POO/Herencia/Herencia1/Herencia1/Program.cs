using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo  Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");


            Mamiferos animal = new Caballo("Bucefalo"); //Principio de sustitucion 
                                                        //Ejemplo de uso de principio de sustitucion con array de clases
            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Juan;
            almacenAnimales[2] = Copito;
            //En este caso solo se accede a metodos de la superclase Mamiferos 
            almacenAnimales[1].getNombre();


            Console.ReadKey();
        }
    }

    class Mamiferos
    {

        private String nombreSerVivo;

        public Mamiferos(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es " + nombreSerVivo);
        }
    }

    class Caballo : Mamiferos
    {
        public Caballo(string nombreCaballo):base(nombreCaballo)
        {


        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }


    }

    class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ");
        }
    }

    class Gorila : Mamiferos 
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
      public void trepar()
        {
            Console.WriteLine("soy capaz de treapar");
        }
    }
}
