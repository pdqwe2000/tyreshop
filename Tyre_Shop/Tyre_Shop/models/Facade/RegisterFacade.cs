//-----------------------------------------------------------------​
//    <copyright file="RegisterFacade.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------


using Tyre_Shop.Classes.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tyre_Shop.Classes.Auth;

namespace Tyre_Shop.Classes.Facade
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
        public async Task<bool> RegisterUserAsync(string username, string password, string phone, bool isAdmin)
        {
            return await _authService.RegisterUserAsync(username, password,phone,isAdmin); // Call the service method to register the user
        }
        public async Task<bool> ChangeUserCredentialsAsync(string username, string newPassword = null, string newPhone = null, bool? isAdmin = null)
        {
            if (await _authService.ChangeUserCredentialsAsync(username, newPassword, newPhone, isAdmin))return true;

            return false;
        }
        public async Task<List<User>> LoadUsersAsync()
        {
            return await _authService.LoadUsersAsync();
        }
        public async Task<bool> DeleteUserAsync(string username)
        {
            return await _authService.DeleteUserAsync(username);
        }
            #endregion
        }
}
