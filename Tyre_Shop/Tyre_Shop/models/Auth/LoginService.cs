using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.models.Interfaces;

namespace Tyre_Shop.classes
{
    // This class provides services related to user authentication and registration.  
    // It interacts with the UserRepo class to load, save, and validate user data.  
    public class LoginService
    {
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
