//-----------------------------------------------------------------​
//    <copyright file="Register.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System.Windows.Forms;

namespace Tyre_Shop.Classes.Interfaces
{
    internal interface IRegister
    {
        #region Properties
        /// <summary>
        /// Gets the username entered by the user during registration.
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Gets the password entered by the user during registration.
        /// </summary>
        string Password { get; }

        /// <summary>
        /// Gets the confirmed password entered by the user during registration.
        /// </summary>
        string ConfirmPassword { get; }
        
        /// <summary>
        /// Gets the phone entered by the user during registration.
        /// </summary>
        string Phone {  get; }

        /// <summary>
        /// Gets the admin status entered by the user during registration.
        /// </summary>
        bool IsAdmin {  get; }

        #endregion

        #region Methods
        /// <summary>
        /// Displays a message to the user.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="caption">The caption for the message box.</param>
        /// <param name="icon">The icon to display in the message box.</param>
        void DisplayMessage(string message, string caption, MessageBoxIcon icon);

        /// <summary>
        /// Clears the input fields for username, password, and confirmed password.
        /// </summary>
        void ClearInputs();

        /// <summary>
        /// Navigates the user back to the login form.
        /// </summary>
        void NavigateToLogin();
        #endregion
    }
}
