using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado Empleado1 = new Empleado("Juan");

            Empleado1.SALARIO = 4500000;
            Empleado1.SALARIO += 500000;
            Console.WriteLine("El salario es " + Empleado1.SALARIO);
            Console.ReadKey();
        }
    }

    class Empleado
    {
        private string nombre;
        private double salario;
        public Empleado(string nombre)
        {
         this.nombre = nombre;

        }

        private double evaluaSalario(double salario)
        {
            if(salario < 0) return 0;
            else return salario;
        }

        // Creacion de Propiedad 

        /*
        public double SALARIO
        {
            get { return this.salario; }
            set { this.salario = evaluaSalario(value); }
        }
        */

        public double SALARIO
        {
          get => this.salario;
          set => this.salario = evaluaSalario(value);   
        }


        /*public void SetSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo . se asignara 0 como salario ");
                this.salario = 0;
            }
            else
            {
                this.salario = salario;    
            }
        }

        public double GetSalario()
        {
            return this.salario;
        }*/

        
    }
}
