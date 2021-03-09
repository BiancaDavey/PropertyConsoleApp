using System;

namespace exampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Property Management System.");
            Console.WriteLine("The local time is " + DateTime.Now + "\n");
            
            // Creating Company object.

            Company exampleCompany = new Company("Bob Jones", "Aerodynamics Ltd", "Cambridge", "123@gmail.com", "07755555555");
            Console.WriteLine(exampleCompany.ClientProfile() + "\n");

            // Creating Individual object.
            
            Individual exampleLandlord = new Individual("Marge Simpson", "Springfield", 2, "456@gmail.com", "07766666666");
            Console.WriteLine(exampleLandlord.ClientProfile() + "\n");

            // Creating Service object.
            
            Service exampleService = new Service("Jane Smith", "London", "Electric Repairs", "Electricity", "789@gmail", "07777777777");
            Console.WriteLine(exampleService.ClientProfile() + "\n");

            Service exampleServiceTwo = new Service("Homer Simpson", "Oxford", "Fix It", "Internet", "012@gmail.com", "07788888888");
            Console.WriteLine(exampleServiceTwo.ClientProfile() + "\n");
        }
    }
}
