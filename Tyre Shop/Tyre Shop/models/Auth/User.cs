using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.models;

namespace Tyre_Shop.classes
{
    // This class represents a User in the Tyre Shop system, inheriting from the Person class.
    public class User : Person
    {
        // Property to store the user's password.
        public string Senha { get; set; }

        // Boolean property to indicate whether the user has administrative privileges (true for Admin, false for regular users).
        public bool Admin { get; set; }

        // Parameterized constructor to initialize a User object with the given details.
        // It calls the base constructor from the Person class to initialize shared properties (name and phone).
        public User(string name, string phone, string senha, bool admin) : base(name, phone)
        {
            Senha = senha;       // Assigns the password to the user.
            Admin = admin;       // Sets whether the user is an administrator or not.
        }
    }
}
