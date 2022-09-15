using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);
            /*
            archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("leidy");
            archivos.agregar("David");*/

            /*
            archivos.agregar(new Empleado(4100000));
            archivos.agregar(new Empleado(2000000));
            archivos.agregar(new Empleado(1200000));
            archivos.agregar(new Empleado(8500000));*/

            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());


            //Empleado salarioEmpleado = archivos.getElemento(2);
            DateTime fecha = archivos.getElemento(3);
            Console.WriteLine(fecha) ;

            Console.ReadKey();
        }
    }

    // clase que almacena datos de cualquier clase en un array con genericos 
    class AlmacenObjetos<T>
    {
        private T [] datosElemento;
        private int i=0;
        public AlmacenObjetos(int z)
        {

            datosElemento = new T[z];

        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

    }

    class Empleado
    {
        private double Salario;

        public Empleado(double salario)
        {
            this.Salario = salario;
        }

        public double getSalario()
        {
            return this.Salario;
        }
    }
}
