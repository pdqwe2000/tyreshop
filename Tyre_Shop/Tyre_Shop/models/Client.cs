using Tyre_Shop.models;

namespace Tyre_Shop.classes
{
    // This class represents a Client in the Tyre Shop system.  
    // It inherits from the Person class and adds specific properties related to clients.  
    public class Client : Person
    {
        #region Properties
        // Private property to indicate whether the client is a company (true) or an individual (false).
        private bool Business { get; set; }

        #endregion

        #region Constructors

        // Constructor to initialize a Client object with the given details.  
        // Calls the base constructor of the Person class to set common properties (name and phone).  
        public Client(string name, string phone, bool business) : base(name, phone)
        {
            Business = business;  // Sets whether the client is a company or an individual.
        }
        #endregion

        #region Methods

        // Overrides the ToString() method to provide a string representation of the Client object.  
        // Displays the client's name and phone number in a formatted string.  
        public override string ToString()
        {
            return $"Name: {Name} - Phone: {Phone} Is Business: {Business}";
        }
        #endregion
    }
}
