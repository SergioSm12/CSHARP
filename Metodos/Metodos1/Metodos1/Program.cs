using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number 1 :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type number 2 :");
            int number2 = int.Parse(Console.ReadLine());

            Sum2Numbers(number1, number2);

            Console.ReadKey();
        }

        static void Sum2Numbers(int number1, int number2)
        {
            Console.WriteLine($"The sum is :{number1 + number2}");

        }
    }
}
