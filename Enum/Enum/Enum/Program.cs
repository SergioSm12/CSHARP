using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000 };
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(Bonus.extra,1900.50);
            Console.WriteLine("El salario del empleado es : "+ empleado1.GetSalario());

            Console.ReadKey();

        }
    }

    class Empleado
    {
        private double salario;
        private Bonus bonusEmpleado;
        public Empleado(Bonus bonusEmpleado, double salario)
        {
           this.bonusEmpleado = bonusEmpleado;
           this.salario = salario; 
        }

        public double GetSalario()
        {
            return this.salario+(double)bonusEmpleado;
        }
        
    }

}
