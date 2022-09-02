using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] edades;

            edades = new int[4];

            edades[0] = 12;
            edades[1] =22;
            edades[2] = 18;
            edades[3] = 20;
           
            ;

            int[] edades = { 12, 22, 18, 20 };

            Console.WriteLine(edades[2]);
            */

            //Array implicito
            var datos = new[] { "Sergio", "Mesa", "Colombia" }; // no recive enteros

            var valores = new[] { 15, 28, 35, 4.5, 7.8 };

            // Array de objetos

            Empleados[] arrayEmpleados = new Empleados[2];

            Empleados Ana = new Empleados("Ana", 89);

            arrayEmpleados[0] = new Empleados("Sara", 37);

            arrayEmpleados[1] = Ana;


            //Array anonimo
            var personas = new[]{
                new{Nombre="Juan",Edad=19},
                new{Nombre="Maria",Edad=49},
                new{Nombre="Diana", Edad=35 }
            };

            for(int i=0; i <= valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.ReadKey();
        }

        class Empleados
        {

            String nombre;
            int edad;

            public Empleados(String nombre, int edad) {
                this.nombre = nombre;
                this.edad = edad;
                

            }

        }
    }
}
