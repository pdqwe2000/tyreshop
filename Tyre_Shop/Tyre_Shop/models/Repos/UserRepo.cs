﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.models.Data;


namespace Tyre_Shop.classes
{
    // This class is responsible for managing the persistence of User objects in the system.  
    // It provides methods to save and load user data to and from a JSON file.  
    public class UserRepo
    {
        #region Properties

       
        private readonly string _usersFilePath = Fpm.Instance.UsersFilePath; // Path to the users data file
     
        
        // Root path of the application, determined dynamically based on the location of the executing assembly.  
        //private static string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;
        //// Path to the JSON file where user data is stored.  
        //private static string _usersFilePath = Path.Combine(rootPath, "assets", "Users.json");
        #endregion

        #region Methods

        /// <summary>  
        /// Method to save a list of users to a JSON file.  
        /// </summary>  
        /// <param name="users">List of Users to save in JSON.</param>  

        public void SaveUser(List<User> users)
        {
            // Serializes the list of users into a JSON-formatted string.  
            string jsonString = System.Text.Json.JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true  // Formats the JSON with indentation for better readability.  
            });

            // Writes the JSON string to the file specified by the path variable.  
            File.WriteAllText(_usersFilePath, jsonString);
        }

        /// <summary>  
        /// Method to load a list of users from the JSON file.
        /// </summary>  

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
        /// Validates user credentials by checking the username and password against the list of users.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <param name="password">The password to validate.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if the credentials are valid, otherwise false.</returns>
        public bool ValidateCredentials(string username, string password, List<User> users)
        {
            return users.Any(user => user.Name == username && user.Password == password); // Check if any user matches
        }

        /// <summary>
        /// Asynchronously saves the list of users to the data file.
        /// </summary>
        /// <param name="users">The list of users to save.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
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
        /// Asynchronously registers a new user by adding their credentials to the users list.
        /// </summary>
        /// <param name="username">The username of the user to register.</param>
        /// <param name="password">The password of the user to register.</param>
        /// <returns>True if registration is successful, false if the username already exists.</returns>
        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            var users = await LoadUsersAsync(); // Load existing users

            // Check if the username already exists
            if (users.Exists(u => u.Name == username))
            {
                return false; // Username already exists, return false
            }

            // Add the new user to the list and save the list back to the file
            users.Add(new User { Name = username, Password = password });
            await SaveUsersAsync(users);
            return true; // Return true to indicate successful registration
        }

        #endregion
    }
}
