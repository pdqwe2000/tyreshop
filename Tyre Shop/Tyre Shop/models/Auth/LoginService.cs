using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyre_Shop.classes
{
    // This class provides services related to user authentication and registration.  
    // It interacts with the UserRepo class to load, save, and validate user data.  
    public class LoginService
    {
        // Instance of UserRepo to handle user data persistence.  
        private UserRepo repositorio = new UserRepo();

        /// <summary>  
        /// Handles user login by verifying the username and password.  
        /// </summary>  
        /// <param name="nome">The username entered by the user.</param>  
        /// <param name="senha">The password entered by the user.</param>  
        /// <param name="admin">Specifies whether the user is an admin (not currently validated in this method).</param>  
        /// <returns>Returns the authenticated User object if successful; otherwise, returns null.</returns>  
        public User Login(string nome, string senha, bool admin)
        {
            // Loads the list of users from the JSON file.  
            List<User> usuarios = repositorio.LoadUsers();

            // Iterates through the list of users to find a match for username and password.  
            foreach (User usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    MessageBox.Show("Login bem-sucedido!");  // Displays a success message.  
                    return usuario;  // Returns the authenticated user.  
                }
            }

            // Displays an error message if the credentials are incorrect.  
            MessageBox.Show("Nome de usuário ou senha incorretos.");
            return null;  // Returns null if authentication fails.  
        }

        /// <summary>  
        /// Registers a new user by adding it to the user repository.  
        /// </summary>  
        /// <param name="nome">The username of the new user.</param>  
        /// <param name="senha">The password for the new user.</param>  
        /// <param name="admin">Specifies whether the new user is an admin.</param>  
        public void SignupUser(string nome, string senha, bool admin)
        {
            // Loads the existing users from the JSON file.  
            List<User> usuarios = repositorio.LoadUsers();

            // Creates a new User object with the provided details.  
            User novoUsuario = new User(nome, senha, admin);

            // Adds the new user to the list.  
            usuarios.Add(novoUsuario);

            // Saves the updated user list back to the JSON file.  
            repositorio.SaveUser(usuarios);

            // Displays a success message indicating the user was created.  
            MessageBox.Show("User Created");
        }
    }
}
