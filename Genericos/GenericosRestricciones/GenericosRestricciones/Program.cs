using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // No se puede implementar la clase estudiante por que no tiene implementada la interfas de salario esto por la restriccion 
            AlcemEmpleados<Estudiante> empleados = new AlcemEmpleados<Estudiante>(3);

            empleados.Agregar(new Director(1200000));
            empleados.Agregar(new Director(1200000));
            empleados.Agregar(new Director(1200000));
        }
    }

    interface IparaEmpleados { 
     double getSalario()
    }
    class Director : IparaEmpleados
    {
        private double Salario;
        public Director(double salario)
        {
            this.Salario = salario;
        }

        public double getSalario()
        {
            return this.Salario;
        }
    }

    class Secretaria:IparaEmpleados
    {
        private double Salario;
        public Secretaria(double salario)
        {
            this.Salario = salario;
        }
        public double getSalario()
        {
            return this.Salario;
        }

    }

    class Electrisistá: IparaEmpleados
    {
        private double Salario;
        public Electrisistá(double salario)
        {
            this.Salario = salario;
        }
        public double getSalario()
        {
            return this.Salario;
        }

    }

    // Clase con restricciones 
    class AlcemEmpleados<T> where T : IparaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;

        public AlcemEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleado[i]=obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }
    }

    class Estudiante
    {
        private double edad;
        public Estudiante (double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return this.edad;
        }
    }
}
