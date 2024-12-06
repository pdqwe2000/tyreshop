using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tyre_Shop.classes.data;

namespace Tyre_Shop.classes.auth
{
    // This class provides services related to user authentication and registration.  
    // It interacts with the UserRepo class to load, save, and validate user data.  
    public class AuthService
    {
        #region Private Fields
        private readonly string _usersFilePath = Fpm.Instance.UsersFilePath; // Path to the users data file
        #endregion

        #region Public Methods
        /// <summary>
        /// Asynchronously loads the list of users from the data file.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of users.</returns>
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
        /// <param name="phone"></param>
        /// <param name="isAdmin"></param>
        /// <returns>True if registration is successful, false if the username already exists.</returns>
        public async Task<bool> RegisterUserAsync(string username, string password,string phone, bool isAdmin)
        {
            var users = await LoadUsersAsync(); // Load existing users

            // Check if the username already exists
            if (users.Exists(u => u.Name == username))
            {
                return false; // Username already exists, return false
            }

            // Add the new user to the list and save the list back to the file
            users.Add(new User { Name = username, Password = password, Phone=phone,Admin=isAdmin });
            await SaveUsersAsync(users);
            return true; // Return true to indicate successful registration
        }

        #endregion
        //#region Properties
        //// Instance of UserRepo to handle user data persistence.  
        ////private UserRepo repos = new UserRepo();
        //private readonly UserRepo _userService;  // Service to handle user-related operations
        //private readonly ILogin _view;   // Interface for the Login View
        //#endregion

        //#region Methods
        ///// <summary>  
        ///// Handles user login by verifying the username and password.  
        ///// </summary>  
        ///// <param name="name">The username entered by the user.</param>  
        ///// <param name="pass">The password entered by the user.</param>  
        ///// <param name="admin">Specifies whether the user is an admin (not currently validated in this method).</param>  
        ///// <returns>Returns the authenticated User object if successful; otherwise, returns null.</returns>  
        //public async Task LoginAsync(string name, string pass, bool admin)
        //{

        //    // Loads the list of users from the JSON file.  
        //    List<User> users = await _userService.LoadUsersAsync();

        //    // Check if there are no users in the system
        //    if (users.Count == 0)
        //    {
        //        _view.DisplayMessage("No user data file found. Please register first.", "Login Failed", MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Iterates through the list of users to find a match for username and password.  
        //    foreach (User user in users)
        //    {
        //        if (user.Name == name && user.Password == pass)
        //        {
        //            MessageBox.Show("Login Succeded!");  // Displays a success message.  
        //            return;  // Returns the authenticated user.  
        //        }
        //    }

        //    // Displays an error message if the credentials are incorrect.  
        //    MessageBox.Show("Wrong Password or Name.");
        //    return;  // Returns null if authentication fails.  
        //}

        ///// <summary>  
        ///// Registers a new user by adding it to the user repository.  
        ///// </summary>  
        ///// <param name="name">The username of the new user.</param>  
        ///// <param name="pass">The password for the new user.</param>  
        ///// <param name="admin">Specifies whether the new user is an admin.</param>  
        //public void SignupUser(string name,string phone, string pass, bool admin)
        //{
        //    //// Loads the existing users from the JSON file.  
        //    //List<User> users = _userService.LoadUsersAsync();

        //    //// Creates a new User object with the provided details.  
        //    //User newUser = new User(name,phone, pass, admin);

        //    //// Adds the new user to the list.  
        //    //users.Add(newUser);

        //    //// Saves the updated user list back to the JSON file.  
        //    //_userService.SaveUser(users);

        //    //// Displays a success message indicating the user was created.  
        //    //MessageBox.Show("User Created");
        //}
        //#endregion
    }
}
