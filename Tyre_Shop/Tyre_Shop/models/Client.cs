﻿//-----------------------------------------------------------------​
//    <copyright file="Client.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

namespace Tyre_Shop.Classes
{
    /// <summary>
    /// This class represents a Client in the Tyre Shop system.
    /// It inherits from the Person class and adds specific properties related to clients.
    /// </summary>
    public class Client : Person
    {
        #region Properties
        // Private property to indicate whether the client is a company (true) or an individual (false).
        private bool Business { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to initialize a Client object with the given details.
        /// Calls the base constructor of the Person class to set common properties (name and phone).
        /// <param name="name">Property to store the person's name.</param>
        /// <param name="phone">Property to store the person's phone number.</param>
        /// <param name="business">Boolean to refer to the type of client</param>
        /// </summary>
        public Client(string name, string phone, bool business) : base(name, phone)
        {
            Business = business;  // Sets whether the client is a company or an individual.
        }
        #endregion

        #region Methods
        /// <summary>
        /// Overrides the ToString() method to provide a string representation of the Client object
        /// Displays the client's name and phone number in a formatted string.
        /// <param name="name">Property to store the person's name.</param>
        /// <param name="phone">Property to store the person's phone number.</param>
        /// <param name="business">Boolean to refer to the type of client</param>
        /// </summary>
        public override string ToString()
        {
            return $"Name: {Name} - Phone: {Phone} Is Business: {Business}";
        }
        #endregion
    }
}
