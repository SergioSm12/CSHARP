using System;


namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado1 = new Empleado(1200, 250);
            empleado1.cambiaSalario(empleado1,100);//Los cambios no se veran reflejados en el objeto inicial debido a que solo altera la copia struct.
            Console.WriteLine(empleado1);
            Console.ReadKey();
        }
    }

    public struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }


        public override string ToString()
        {
            return string.Format("Salario y comision del empleado ({0},{1})", this.salarioBase, this.comision);

        }

        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase+=incremento;
            emp.comision+= incremento;
        }
    }
}
