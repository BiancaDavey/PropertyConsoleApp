using System;
using System.Net.Mail;

namespace exampleApp
{
    public abstract class Client
    {
        private int totalClients = 0;
        public string ClientID { get; protected set; }
        public string ContactName { get; protected set; }
        public string Location {get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }

        // Constructor for the Superclass.

        public Client(string contactName, string location, string email, string phone){

            ContactName = contactName;
            Location = location;
            ClientID = GenerateID();
            Email = VerifyEmail(email);
            Phone = phone;
            AddClient();
        }

        // The GenerateID method combines a substring of the first two characters of the client's name with a random 4 digit integer to form a client ID.
        public string GenerateID(){

            System.Random random = new System.Random();
            string clientName = ContactName.Substring(0, 1);
            int clientNumber = random.Next(1000,9999);
            string clientID = clientName + clientNumber.ToString();
            return clientID;
        }

        // The VerifyEmail method verifies that a provided email address satisfies formatting requirements.

        public string VerifyEmail(string email){

            string invalid = "Invalid";
            try {
                var newMail = new MailAddress(email);
                bool isValid = newMail.Host.Contains(".");
                if (!isValid) {
                    Console.WriteLine($"The email {email} is invalid and requires updating.");
                    Email = invalid;
                    return invalid;
                }
                else {
                    Email = email;
                    return email;
                }
            }
            catch(Exception) {
                Console.WriteLine($"The email {email} is invalid and requires updating. \n");
                Email = invalid;
                return invalid;
            }
        }


        // The AddClient method adds a client to the total count of clients.
        public int AddClient() {

            totalClients += 1;
            Console.WriteLine("Client has been added successfully: \n");
            return totalClients;
        }

        // Subclasses of the Client class must implement a ClientProfile method.
        public abstract string ClientProfile();


    }
}