using System;


namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Number =0;

            do
            {
                Console.WriteLine("The value is :" + Number);
                Number++;
            } while (Number < 50);

            Console.ReadKey();
        }
    }
}
