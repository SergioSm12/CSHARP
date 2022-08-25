using System;


namespace CondicionIF
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary;

            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();

            Console.Write("Enter your salary: ");
            salary = double.Parse(Console.ReadLine());
            // The minimum wage in colombia is 1000000
            // The salary is greater than 200000 
            if(salary <= 1000000)
            {
                Console.WriteLine(name + ", The salary you have is very little. ");

            }else if(salary>1000000 && salary <= 3000000)
            {
                Console.WriteLine(name + ", Your salary is moderate");
            }else if(salary > 3000000)
            {
                Console.WriteLine(name+ ", Your salary is good");
            }
            


            Console.ReadKey();
        }
    }
}
