//-----------------------------------------------------------------​
//    <copyright file="LoginFacade.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Auth;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.Classes.Facade
{
    /// <summary>
    /// Provides a simplified interface for handling login operations 
    /// such as user authentication, loading user data, and verifying admin privileges.
    /// </summary>
    public class LoginFacade
    {
        #region Fields and Properties

        private readonly AuthService _authService; // Service for authentication operations

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginFacade"/> class.
        /// </summary>
        public LoginFacade()
        {
            _authService = new AuthService();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Asynchronously loads the list of users from the authentication service.
        /// </summary>
        /// <returns>A task representing the asynchronous operation, containing a list of users.</returns>
        public async Task<List<User>> LoadUsersAsync()
        {
            return await _authService.LoadUsersAsync();
        }

        /// <summary>
        /// Validates the credentials of a user against the list of users.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <param name="password">The password to validate.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if the credentials are valid; otherwise, false.</returns>
        public bool ValidateCredentials(string username, string password, List<User> users)
        {
            return _authService.ValidateCredentials(username, password, users);
        }

        /// <summary>
        /// Determines if the specified user has admin privileges.
        /// </summary>
        /// <param name="username">The username to verify.</param>
        /// <param name="password">The password to verify.</param>
        /// <param name="users">The list of users to check against.</param>
        /// <returns>True if the user has admin privileges; otherwise, false.</returns>
        public bool VerifyAdmin(string username, string password, List<User> users)
        {
            return _authService.VerifyAdmin(username, password, users);
        }

        #endregion
    }
}
