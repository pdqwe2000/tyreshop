//-----------------------------------------------------------------​
//    <copyright file="LoginController.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using Tyre_Shop.Classes.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Auth;
using Tyre_Shop.Classes.Facade;
using System.IO;
using System;

namespace Tyre_Shop.Classes.Controller
{
    /// <summary>
    /// Controller responsible for handling the login logic.
    /// </summary>
    public class LoginController
    {
        #region Fields and Properties

        private readonly ILogin _view;                  // Interface for the Login View
        private readonly LoginFacade _loginFacade;      // Facade for handling login operations

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize the LoginController with the specified view.
        /// </summary>
        /// <param name="view">The view that the controller will interact with.</param>
        public LoginController(ILogin view)
        {
            _view = view;                          // Assign the view
            _loginFacade = new LoginFacade();      // Initialize the LoginFacade
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handles the login process asynchronously.
        /// </summary>
        public async Task HandleLoginAsync()
        {
            try
            {
                // Load the list of users from the LoginFacade
                List<User> users = await _loginFacade.LoadUsersAsync();

                // Check if there are no users in the system
                if (users.Count == 0)
                {
                    _view.DisplayMessage("No user data file found. Please register first.", "Login Failed", MessageBoxIcon.Error);
                    return;
                }

                // Validate the credentials entered by the user
                bool loginSuccess = _loginFacade.ValidateCredentials(_view.User, _view.Password, users);

                if (loginSuccess)
                {
                    // Check if the user has admin privileges
                    bool isAdmin = _loginFacade.VerifyAdmin(_view.User, _view.Password, users);

                    // Navigate to the main form
                    _view.NavigateToMainForm(_view.User, isAdmin);
                }
                else
                {
                    // If login failed, show an error message and clear inputs
                    _view.DisplayMessage("Invalid Credentials, please try again.", "Login Failed", MessageBoxIcon.Error);
                    _view.ClearInputs();
                }
            }
            catch (FileNotFoundException ex)
            {
                // Handle case where the user data file is missing
                _view.DisplayMessage($"User data file not found: {ex.Message}", "File Error", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                _view.DisplayMessage($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}