//-----------------------------------------------------------------​
//    <copyright file="User.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

namespace Tyre_Shop.Classes.Auth
{
    /// <summary>
    /// This class represents a User in the Tyre Shop system, inheriting from the Person class.
    /// </summary>
    public class User : Person
    {
        #region Properties
        public string Password { get; set; }
        public bool Admin { get; set; }
        #endregion

        #region Constructor
        /// <summary>  
        /// Constructor  
        /// </summary>  
        /// <param name="name">Hereditary from de Person class. Value entered by the user.</param>  
        /// <param name="phone">Hereditary from de Person class. Value entered by the user.</param>
        /// <param name="pass">Value entered by the user.</param>  
        /// <param name="admin">Specifies whether the user is an admin (not currently validated in this method).</param>  
        /// <returns>It calls the base constructor from the Person class to initialize shared properties (name,phone,).</returns>  
        public User(string name, string phone, string pass, bool admin) : base(name, phone)
        {
            Password = pass;       // Assigns the password to the user.
            Admin = admin;       // Sets whether the user is an administrator or not.
        }

        /// <summary>  
        /// Constructor  
        /// </summary>  
        /// <param name="">Empty constructer</param>
        /// <returns></returns>  
        public User() { }
        #endregion
        
    }
}
