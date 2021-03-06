namespace exampleApp
{
    class Company : Client
    {

        public string CompanyName { get; }

        // TODO: note- adding a List of all registered companies.
        //List<List<Company>> companies = new List<List<Company>>();

        public Company(string contactName, string location, string companyName, string email, string phone) : base(contactName, location, email, phone)
        {
            CompanyName = companyName;
        }

        public override string ClientProfile()
        {
            //throw new NotImplementedException();
            return $"Client {ClientID} \n Company Name: {CompanyName} \n Contact Name: {ContactName} \n Location: {Location} \n Email: {Email} \n Phone: {Phone} \n";
        }
    }
}