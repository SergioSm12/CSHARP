using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int Table;
            Table = 0;

            Console.Write("type of number table : ");
            Table = int.Parse(Console.ReadLine());

            for(int i =1; i<=12; i++)
            {
                Console.WriteLine( Table + " x " + i + " = " + (Table*i));
            }
            Console.ReadKey();

        }
    }
}
