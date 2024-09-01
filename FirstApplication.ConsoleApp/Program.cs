using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter date of Birth in format Day/Month/year: ");

            DateOnly date;
            date = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1} and date of birth {2} ", name, age, date);
            Console.ReadKey();
        }
    }
}