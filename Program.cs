using System;
namespace UserRegProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my User Regestation Problem");

            Name name = new Name();
            Console.WriteLine("Enter your Fast Name");
            string Name = Console.ReadLine();
            bool match = name.validateName(Name);

            if (match)
                Console.WriteLine("Name Matched");
            else
                Console.WriteLine("Name are not Matche");



        }
    }
}