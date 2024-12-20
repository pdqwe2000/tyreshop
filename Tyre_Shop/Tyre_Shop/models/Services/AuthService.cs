//-----------------------------------------------------------------​
//    <copyright file="AuthService.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Data;
using Tyre_Shop.Classes.Auth;
using System;

namespace Tyre_Shop.Classes.Services
{
    /// <summary>
    /// Provides services related to user authentication, registration, and user data management.
    /// </summary>
    public class AuthService
    {
        #region Private Fields

        private readonly string _usersFilePath = Fpm.Instance.UsersFilePath; // Path to the users' data file

        #endregion

        #region Properties

        /// <summary>
        /// Gets the list of users currently loaded.
        /// </summary>
        public List<User> UsersList { get; private set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Asynchronously loads the list of users from the data file.
        /// </summary>
        /// <returns>A task containing the list of users.</returns>
        public async Task<List<User>> LoadUsersAsync()
        {
            // Check if the users file exists
            if (!File.Exists(_usersFilePath))
                return new List<User>(); // Return an empty list if no file is found

            // Read the file and deserialize the JSON content into a list of users
            using (StreamReader reader = new StreamReader(_usersFilePath))
            {
                string json = await reader.ReadToEndAsync();
                return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>(); // Deserialize and return users
            }
        }

        /// <summary>
        /// Validates the credentials of a user.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <param name="password">The password to validate.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if the credentials are valid; otherwise, false.</returns>
        public bool ValidateCredentials(string username, string password, List<User> users)
        {
            return users.Any(user => user.Name == username && user.Password == password); // Check if any user matches
        }

        /// <summary>
        /// Checks if a user has administrator privileges.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <param name="password">The password to check.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if the user is an admin; otherwise, false.</returns>
        public bool VerifyAdmin(string username, string password, List<User> users)
        {
            if (users.Any(user => user.Name == username && user.Password == password && user.Admin == true))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Asynchronously saves the list of users to the data file.
        /// </summary>
        /// <param name="users">The list of users to save.</param>
        /// <returns>A task representing the save operation.</returns>
        public async Task SaveUsersAsync(List<User> users)
        {
            // Serialize the list of users to JSON
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            // Write the JSON string to the file
            using (StreamWriter writer = new StreamWriter(_usersFilePath))
            {
                await writer.WriteAsync(json);
            }
        }

        /// <summary>
        /// Asynchronously registers a new user.
        /// </summary>
        /// <param name="username">The username to register.</param>
        /// <param name="password">The password to register.</param>
        /// <param name="phone">The phone number of the user.</param>
        /// <param name="isAdmin">Indicates if the user has admin privileges.</param>
        /// <returns>True if the registration is successful; otherwise, false.</returns>
        public async Task<bool> RegisterUserAsync(string username, string password, string phone, bool isAdmin)
        {
            var users = await LoadUsersAsync(); // Load existing users

            // Check if the username already exists
            if (users.Exists(u => u.Name == username))
            {
                return false; // Username already exists, return false
            }

            // Add the new user to the list and save the list back to the file
            users.Add(new User { Password = password, Admin = isAdmin, Name = username, Phone = phone });
            await SaveUsersAsync(users);
            return true; // Return true to indicate successful registration
        }

        /// <summary>
        /// Asynchronously changes the credentials of an existing user.
        /// </summary>
        /// <param name="username">The username of the user to update.</param>
        /// <param name="newPassword">The new password to set (optional).</param>
        /// <param name="newPhone">The new phone number to set (optional).</param>
        /// <param name="isAdmin">Indicates whether to change admin status (optional).</param>
        /// <returns>True if the credentials were updated successfully; otherwise, false.</returns>
        public async Task<bool> ChangeUserCredentialsAsync(string username, string newPassword = null, string newPhone = null, bool? isAdmin = null)
        {
            // Load the existing users
            var users = await LoadUsersAsync();

            // Find the user by username
            var user = users.FirstOrDefault(u => u.Name == username);
            if (user == null)
            {
                return false; // User not found
            }

            // Update the user's credentials if provided
            if (!string.IsNullOrEmpty(newPassword))
            {
                user.Password = newPassword;
            }

            if (!string.IsNullOrEmpty(newPhone))
            {
                user.Phone = newPhone;
            }

            if (isAdmin.HasValue)
            {
                user.Admin = isAdmin.Value;
            }

            // Save the updated user list back to the file
            await SaveUsersAsync(users);
            return true; // Indicate that the update was successful
        }

        /// <summary>
        /// Asynchronously deletes a user by username.
        /// </summary>
        /// <param name="username">The username of the user to delete.</param>
        /// <returns>True if the user was deleted successfully; otherwise, false.</returns>
        public async Task<bool> DeleteUserAsync(string username)
        {
            try
            {
                var users = await LoadUsersAsync();
                var userToDelete = users.FirstOrDefault(u => u.Name == username);
                if (userToDelete == null)
                {
                    return false; // User not found
                }

                users.Remove(userToDelete);
                await SaveUsersAsync(users);
                return true; // User deleted successfully
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Error deleting user: {ex.Message}");
                return false; // Indicate failure
            }
        }
        #endregion
    }
}