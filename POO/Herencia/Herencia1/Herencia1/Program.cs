using System;


namespace Herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            IMamiferosTerrestres IBabieca = Babieca;//Solucionar Ambiguedad

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");


            Mamiferos animal = new Caballo("Bucefalo"); //Principio de sustitucion 
                                                        //Ejemplo de uso de principio de sustitucion con array de clases
            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;
            almacenAnimales[1] = Juan;
            almacenAnimales[2] = Copito;
            //En este caso solo se accede a metodos de la superclase Mamiferos 

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Ballena miWally = new Ballena("Wally");
            miWally.nadar();

            Console.WriteLine("Numero de patas de Babieca " + IBabieca.NumeroPatas());//Solucionar Ambiguedad

            Console.ReadKey();
        }
    }
    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }

    interface IAnimalesDeportes
    {
        string TipoDeporte();

        Boolean EsOlimpico();
    }

    interface ISaltoConPatas
    {
        int NumeroPatas();
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

        public virtual void pensar()  // virtual indica que este metodo cuando se hereda cambia su comportamiento
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
    }



    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {


        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

         int IMamiferosTerrestres.NumeroPatas()//Solucionar cuando dos metodos se llaman de la misma forma en dos interfaces(ambiguedad)
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()// Solucionar ambiguedad 
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Hipica";
        }

        public Boolean EsOlimpico()
        { 
            return true;
        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar ");
        }
    }

    class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar() //  override modificacion del metodo virtual
        {
            Console.WriteLine("Soy capaz de pensar ");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public  override void pensar()//override sobreescribe o modifica el metodo virtual heredado de mamiferos
        {
            Console.WriteLine("pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("soy capaz de treapar");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}
