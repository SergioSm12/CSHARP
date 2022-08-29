using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();
            Coche coche3 = new Coche(4500.25,1200.35);
            Console.WriteLine(coche1.getInfo());
            Console.WriteLine(coche2.getInfo());
            Console.WriteLine(coche3.getInfo());
            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
            Console.ReadKey();
                      
            
        }
    }

    partial class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";

        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
     }

    //--------------------------------------------------------------------------------------------------

    
     partial class Coche 
    { 

        public String getInfo()
        {
            return "La informacion del coche es \n" + "ruedas: " + ruedas + " largo :" + largo + " ancho :" + ancho;
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador= climatizador;
            this.tapiceria= tapiceria;
        }

        public String getExtras()
        {
            return "Extras del coche:\n" + "Tapiceria : "+ tapiceria + " Climatizador: "+ climatizador;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;


      }
}
