using System.Collections.Generic;
using System.Windows.Forms;

namespace Tyre_Shop.classes
{
    // This class provides services related to user authentication and registration.  
    // It interacts with the UserRepo class to load, save, and validate user data.  
    public class LoginService
    {
        #region Properties
        // Instance of UserRepo to handle user data persistence.  
        private UserRepo repos = new UserRepo();
        #endregion

        #region Methods
        /// <summary>  
        /// Handles user login by verifying the username and password.  
        /// </summary>  
        /// <param name="name">The username entered by the user.</param>  
        /// <param name="pass">The password entered by the user.</param>  
        /// <param name="admin">Specifies whether the user is an admin (not currently validated in this method).</param>  
        /// <returns>Returns the authenticated User object if successful; otherwise, returns null.</returns>  
        public User Login(string name, string pass, bool admin)
        {
            // Loads the list of users from the JSON file.  
            List<User> users = repos.LoadUsers();

            // Iterates through the list of users to find a match for username and password.  
            foreach (User user in users)
            {
                if (user.Name == name && user.Password == pass)
                {
                    MessageBox.Show("Login Succeded!");  // Displays a success message.  
                    return user;  // Returns the authenticated user.  
                }
            }

            // Displays an error message if the credentials are incorrect.  
            MessageBox.Show("Wrong Password or Name.");
            return null;  // Returns null if authentication fails.  
        }

        /// <summary>  
        /// Registers a new user by adding it to the user repository.  
        /// </summary>  
        /// <param name="name">The username of the new user.</param>  
        /// <param name="pass">The password for the new user.</param>  
        /// <param name="admin">Specifies whether the new user is an admin.</param>  
        public void SignupUser(string name,string phone, string pass, bool admin)
        {
            // Loads the existing users from the JSON file.  
            List<User> users = repos.LoadUsers();

            // Creates a new User object with the provided details.  
            User newUser = new User(name,phone, pass, admin);

            // Adds the new user to the list.  
            users.Add(newUser);

            // Saves the updated user list back to the JSON file.  
            repos.SaveUser(users);

            // Displays a success message indicating the user was created.  
            MessageBox.Show("User Created");
        }
        #endregion
    }
}
