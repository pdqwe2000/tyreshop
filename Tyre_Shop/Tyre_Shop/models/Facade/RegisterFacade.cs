//-----------------------------------------------------------------
//    <copyright file="RegisterFacade.cs" company="FujiSoft">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>19-12-2024</date>
//    <time>23:00</time>
//    <version>0.1</version>
//    <author>Pedro Duarte</author>
//-----------------------------------------------------------------

using Tyre_Shop.Classes.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using Tyre_Shop.Classes.Auth;

namespace Tyre_Shop.Classes.Facade
{
    /// <summary>
    /// Facade class for handling user registration and credential management functionality.
    /// Provides an abstraction layer for the authentication service.
    /// </summary>
    public class RegisterFacade
    {
        #region Private Fields

        private readonly AuthService _authService; // Service for user-related operations

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterFacade"/> class with necessary dependencies.
        /// </summary>
        public RegisterFacade()
        {
            _authService = new AuthService(); // Initialize the AuthService dependency
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Registers a new user asynchronously.
        /// </summary>
        /// <param name="username">The username of the user to be registered.</param>
        /// <param name="password">The password of the user to be registered.</param>
        /// <param name="phone">The phone number of the user.</param>
        /// <param name="isAdmin">Specifies whether the user has admin privileges.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result is true if the registration is successful; otherwise, false.
        /// </returns>
        public async Task<bool> RegisterUserAsync(string username, string password, string phone, bool isAdmin)
        {
            return await _authService.RegisterUserAsync(username, password, phone, isAdmin);
        }

        /// <summary>
        /// Updates user credentials asynchronously.
        /// </summary>
        /// <param name="username">The username of the user whose credentials will be updated.</param>
        /// <param name="newPassword">The new password for the user. Pass null to keep the current password.</param>
        /// <param name="newPhone">The new phone number for the user. Pass null to keep the current phone number.</param>
        /// <param name="isAdmin">Specifies whether the user has admin privileges. Pass null to keep the current role.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result is true if the credentials are successfully updated; otherwise, false.
        /// </returns>
        public async Task<bool> ChangeUserCredentialsAsync(string username, string newPassword = null, string newPhone = null, bool? isAdmin = null)
        {
            return await _authService.ChangeUserCredentialsAsync(username, newPassword, newPhone, isAdmin);
        }

        /// <summary>
        /// Loads the list of registered users asynchronously.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a list of users.
        /// </returns>
        public async Task<List<User>> LoadUsersAsync()
        {
            return await _authService.LoadUsersAsync();
        }

        /// <summary>
        /// Deletes a user asynchronously.
        /// </summary>
        /// <param name="username">The username of the user to be deleted.</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result is true if the user is successfully deleted; otherwise, false.
        /// </returns>
        public async Task<bool> DeleteUserAsync(string username)
        {
            return await _authService.DeleteUserAsync(username);
        }

        #endregion
    }
}
