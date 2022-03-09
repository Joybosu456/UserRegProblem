using System;
namespace UserRegProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my User Regestation Problem");

            MobileNo no = new MobileNo();
            Console.WriteLine("Enter your MobileNo");

            string MobileNo = Console.ReadLine();

            bool match = no.validateMobileNo(MobileNo);

            if (match)
                Console.WriteLine("MobileNo Matched");
            else
                Console.WriteLine("MobileNo are not Matche");



        }
    }
}