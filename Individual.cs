namespace exampleApp
{
    class Individual : Client
    {
        public int PropertiesOwned { get; }
        public Individual(string contactName, string location, int propertiesOwned, string email, string phone) : base(contactName, location, email, phone)
        {
            PropertiesOwned = propertiesOwned;
        }

        public override string ClientProfile()
        {
            //throw new NotImplementedException();
            return $"Client {ClientID} \n Client Name: {ContactName} \n Number of Properties: {PropertiesOwned} \n Location: {Location} \n Email: {Email} \n Phone: {Phone} \n";
        }
    }
}