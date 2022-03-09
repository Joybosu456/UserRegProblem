using System;
namespace UserRegProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my User Regestation Problem");

            LastName name = new LastName();
            Console.WriteLine("Enter your Last Name");
            string LastName = Console.ReadLine();
            bool match = name.validateLastName(LastName);

            if (match)
                Console.WriteLine("Last Name Matched");
            else
                Console.WriteLine("Last Name are not Matche");



        }
    }
}