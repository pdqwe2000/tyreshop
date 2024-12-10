using Tyre_Shop.models;

namespace Tyre_Shop.classes.auth
{
    // This class represents a User in the Tyre Shop system, inheriting from the Person class.
    public class User : Person
    {
        #region Properties
        // Property to store the user's password.
        public string Password { get; set; }

        // Boolean property to indicate whether the user has administrative privileges (true for Admin, false for regular users).
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
        /// <
        /// <returns></returns>  
        public User() { }
        #endregion
    }
}
