//-----------------------------------------------------------------​
//    <copyright file="LoginRegisterSystem.cs" company="IPCA">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>24-11-2024</date>​
//    <time>21:00</time>​
//    <version>0.1</version>​
//    <author>Ernesto Casanova</author>​
//-----------------------------------------------------------------

using System.Threading.Tasks;
using Tyre_Shop.classes.auth;

namespace Tyre_Shop.classes.facade
{
    public class LoginFacade
    {

        #region Private Fields
        private readonly AuthService _userService;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the LoginFacade with necessary services.
        /// </summary>
        public LoginFacade()
        {
            _userService = new AuthService(); // Initialize the UserService dependency
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Authenticates the user asynchronously based on provided username and password.
        /// </summary>
        /// <param name="username">The username of the user attempting to log in.</param>
        /// <param name="password">The password of the user attempting to log in.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is a boolean indicating whether the authentication was successful.</returns>
        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            // Load the list of users asynchronously
            var users = await _userService.LoadUsersAsync();

            if (users.Count == 0)
            {
                return false;
            }

            // Validate the credentials using the UserService
            return _userService.ValidateCredentials(username, password, users);
        }
        #endregion


    }
}

