//-----------------------------------------------------------------​
//    <copyright file="Ilogin.cs" company="FujiSoft">​
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
    public interface ILogin
    {
        #region Properties
        string User { get; }
        string Password { get; }
        #endregion

        void NavigateToRegister();

        /// <summary>
        /// Navigates to the main form after successful login.
        /// </summary>
        /// <param name="user">The username of the logged-in user.</param>
        void NavigateToMainForm(string username,bool admin);
       
        /// <summary>
        /// Displays a message to the user.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="caption">The message box caption.</param>
        /// <param name="icon">The icon to display in the message box.</param>
        void DisplayMessage(string message, string caption, MessageBoxIcon icon);
        
        /// <summary>
        /// Clears the input fields for username and password.
        /// </summary>
        void ClearInputs();

    }
}
