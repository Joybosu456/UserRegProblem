using System;
namespace UserRegProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my User Regestation Problem");

            Email em = new Email();
            Console.WriteLine("Enter your Email");
            string Email = Console.ReadLine();
            bool match = em.validateLastName(Email);

            if (match)
                Console.WriteLine("Email Matched");
            else
                Console.WriteLine("Email are not Matche");



        }
    }
}