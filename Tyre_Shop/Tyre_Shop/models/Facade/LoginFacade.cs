//-----------------------------------------------------------------​
//    <copyright file="LoginRegisterSystem.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>24-11-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Auth;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.Classes.Facade
{
    public class LoginFacade
    {

        private readonly AuthService _authService;

        /// <summary>
        /// Initializes a new instance of the LoginFacade.
        /// </summary>
        public LoginFacade()
        {
            _authService = new AuthService();
        }

        /// <summary>
        /// Loads the list of users asynchronously.
        /// </summary>
        public async Task<List<User>> LoadUsersAsync()
        {
            return await _authService.LoadUsersAsync();
        }

        /// <summary>
        /// Validates the credentials of a user.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <param name="password">The password to validate.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if credentials are valid; otherwise, false.</returns>
        public bool ValidateCredentials(string username, string password, List<User> users)
        {
            return _authService.ValidateCredentials(username, password, users);
        }

        /// <summary>
        /// Checks if the provided user has admin privileges.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <param name="password">The password to check.</param>
        /// <param name="users">The list of users to check against.</param>
        /// <returns>True if the user is an admin; otherwise, false.</returns>
        public bool VerifyAdmin(string username, string password, List<User> users)
        {
            return _authService.VerifyAdmin(username, password, users);
        }
    }
}

