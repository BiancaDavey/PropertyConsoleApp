using System;
using System.Collections.Generic;

namespace exampleApp
{
    class Service : Client
    {
        public string ServiceName { get; }
        public string ServiceType { get; }
        List<string> plumbing = new List<string>();
        List<string> electric = new List<string>();
        List<string> gas = new List<string>();
        List<string> otherService = new List<string>();

        // Constructor.
        public Service(string contactName, string location, string serviceName, string serviceType, string email, string phone) : base(contactName, location, email, phone)
        {
            ServiceName = serviceName;

            if ((serviceType == "Plumbing") || (serviceType == "plumbing")) {
                ServiceType = serviceType;
                plumbing.Add(serviceName);
            }
            else if ((serviceType == "Electric") || (serviceType == "electric")) {
                ServiceType = serviceType;
                electric.Add(serviceName);
            }
            else if ((serviceType == "Gas") || (serviceType == "gas")) {
                ServiceType = serviceType;
                gas.Add(serviceName);
            }
            else {
                ServiceType = "Other";
                otherService.Add(serviceName);
            }
        }

        // TODO: LINQ query builder.
        
        // The FindServices list accepts a category of service provider as an argument and converts the list containing services of this type into an array.
        // TODO: access to demonstrate in Program.cs class.
        public override void FindServices(){

            Console.WriteLine("Enter a category of service: Plumbing, Electric, Gas or Other");
            string serviceCategory = Console.ReadLine();

            if ((serviceCategory == "Plumbing") || (serviceCategory == "plumbing")){
                string[] plumbingList = plumbing.ToArray();
                Console.WriteLine($"Plumbers: {plumbingList}");
            }
            else if ((serviceCategory == "Electric") || (serviceCategory == "electric")){
                string[] electricList = electric.ToArray();
                Console.WriteLine($"Electricians: {electricList}");
            }
            else if ((serviceCategory == "Gas") || (serviceCategory == "gas")){
                string[] gasList = gas.ToArray();
                Console.WriteLine($"Gas services: {gasList}");
            }
            else {
                string[] miscellaneousServices = otherService.ToArray();
                Console.WriteLine($"{serviceCategory} and other services: {miscellaneousServices}");
            } 
        }

        public override string ClientProfile()
        {
            //throw new NotImplementedException();
            return $"Client {ClientID} \n Service Type: {ServiceType} \n Company Name: {ServiceName} \n Contact Name: {ContactName} \n Location: {Location} \n Email: {Email} \n Phone: {Phone} \n";
        }
    }
}