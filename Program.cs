using System;
namespace UserRegProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my User Regestation Problem");

            //MobileNo no = new MobileNo();
            //Console.WriteLine("Enter your MobileNo");

            //string MobileNo = Console.ReadLine();

            //bool match = no.validateMobileNo(MobileNo);

            //if (match)
            //    Console.WriteLine("MobileNo Matched");
            //else
            //    Console.WriteLine("MobileNo are not Matche");

            //PassWordRule1 passwordRule1 = new PassWordRule1();
            //Console.WriteLine("Enter Password");
            //string value = Console.ReadLine();
            //bool match = passwordRule1.validatePasswordRule1(value);
            //if (match)
            //    Console.WriteLine("Password Matched");
            //else
            //    Console.WriteLine("Password Not Matched");

            PassWordRule2 passwordRule2 = new PassWordRule2();
            Console.WriteLine("Enter Password");
            string value = Console.ReadLine();
            bool match = passwordRule2.validatePasswordRule2(value);
            if (match)
                Console.WriteLine("Password Matched");
            else
                Console.WriteLine("Password Not Matched");



        }
    }
}