using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.models;

namespace Tyre_Shop.classes
{
    // This class represents a Client in the Tyre Shop system.  
    // It inherits from the Person class and adds specific properties related to clients.  
    public class Client : Person
    {
        // Private property to indicate whether the client is a company (true) or an individual (false).
        private bool Empresa { get; set; }

        // Constructor to initialize a Client object with the given details.  
        // Calls the base constructor of the Person class to set common properties (name and phone).  
        public Client(string name, string phone, bool empresa) : base(name, phone)
        {
            Empresa = empresa;  // Sets whether the client is a company or an individual.
        }

        // Overrides the ToString() method to provide a string representation of the Client object.  
        // Displays the client's name and phone number in a formatted string.  
        public override string ToString()
        {
            return $"{Name} - Telefone: {Phone}";
        }
    }
}
