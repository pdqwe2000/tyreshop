﻿//-----------------------------------------------------------------​
//    <copyright file="LoginRegisterSystem.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>24-11-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

using Tyre_Shop.classes.auth;
using System.Threading.Tasks;

namespace LoginRegisterSystem.Models.Facades
{
    /// <summary>
    /// Facade class for handling user registration functionality.
    /// </summary>
    public class RegisterFacade
    {
        #region Private Fields
        private readonly AuthService _authService; // Service for user-related operations
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the RegisterFacade with necessary services.
        /// </summary>
        public RegisterFacade()
        {
            _authService = new AuthService(); // Initialize the UserService dependency
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Registers a new user asynchronously.
        /// </summary>
        /// <param name="username">The username of the user to be registered.</param>
        /// <param name="password">The password of the user to be registered.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is true if registration is successful, false otherwise.</returns>
        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            return await _authService.RegisterUserAsync(username, password,"1",true); // Call the service method to register the user
        }
        #endregion
    }
}
