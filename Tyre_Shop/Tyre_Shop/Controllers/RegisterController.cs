﻿//-----------------------------------------------------------------​
//    <copyright file="RegisterController.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Facade;
using Tyre_Shop.Classes.Interfaces;

namespace Tyre_Shop.Classes.Controller
{
    /// <summary>
    /// Controller responsible for handling user registration logic, including
    /// input validation, password confirmation, and communication with AuthService using the RegisterFacade.
    /// </summary>
    internal class RegisterController
    {
        #region Fields and Properties

        private readonly IRegister _view;                   // Interface for the Register View
        private readonly RegisterFacade _registerFacade;    // Facade for handling registration operations

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterController"/> class.
        /// </summary>
        /// <param name="view">The view that the controller will interact with.</param>
        public RegisterController(IRegister view)
        {
            _view = view;  // Assign the view
            _registerFacade = new RegisterFacade();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handles the user registration process asynchronously.
        /// Validates input, ensures password confirmation, and registers the user.
        /// </summary>
        public async Task HandleRegistrationAsync()
        {
            // Check if any required fields are empty
            if (string.IsNullOrWhiteSpace(_view.Username) ||
                string.IsNullOrWhiteSpace(_view.Password) ||
                string.IsNullOrWhiteSpace(_view.ConfirmPassword) ||
                _view.Phone == null)
            {
                _view.DisplayMessage("Username, Password, and Phone fields cannot be empty.", "Sign Up Failed", MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (_view.Password != _view.ConfirmPassword)
            {
                _view.DisplayMessage("Passwords do not match. Please re-enter.", "Sign Up Failed", MessageBoxIcon.Error);
                _view.ClearInputs();  // Clear the inputs to prompt user for new data
                return;
            }

            try
            {
                // Attempt to register the user
                bool registrationSuccess = await _registerFacade.RegisterUserAsync(_view.Username, _view.Password, _view.Phone, _view.IsAdmin);

                if (registrationSuccess)
                {
                    _view.ClearInputs();  // Clear inputs after successful registration
                    _view.DisplayMessage("Your account has been successfully created.", "Registration Success", MessageBoxIcon.Information);
                }
                else
                {
                    // If username already exists, show error
                    _view.DisplayMessage("Username already exists.", "Sign Up Failed", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur during the registration process
                _view.DisplayMessage($"An error occurred: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
