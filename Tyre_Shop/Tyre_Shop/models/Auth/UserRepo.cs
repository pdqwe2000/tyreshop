using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Reflection;

namespace Tyre_Shop.classes
{
    // This class is responsible for managing the persistence of User objects in the system.  
    // It provides methods to save and load user data to and from a JSON file.  
    public class UserRepo
    {
        #region Properties

        // Root path of the application, determined dynamically based on the location of the executing assembly.  
        private static string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;

        // Path to the JSON file where user data is stored.  
        private static string path = Path.Combine(rootPath, "assets", "Users.json");
        #endregion

        #region Methods

        /// <summary>  
        /// Method to save a list of users to a JSON file.  
        /// </summary>  
        /// <param name="usuarios">List of Users to save in JSON.</param>  

        public void SaveUser(List<User> usuarios)
        {
            // Serializes the list of users into a JSON-formatted string.  
            string jsonString = System.Text.Json.JsonSerializer.Serialize(usuarios, new JsonSerializerOptions
            {
                WriteIndented = true  // Formats the JSON with indentation for better readability.  
            });

            // Writes the JSON string to the file specified by the path variable.  
            File.WriteAllText(path, jsonString);
        }

        /// <summary>  
        /// Method to load a list of users from the JSON file.
        /// </summary>  
       
        public List<User> LoadUsers()
        {
            // Checks if the JSON file exists at the specified path.  
            if (!File.Exists(path))
            {
                // Displays a message box if the file does not exist and returns an empty list of users.  
                MessageBox.Show("No path!");
                return new List<User>();
            }

            // Reads the content of the JSON file into a string.  
            string jsonString = File.ReadAllText(path);

            // Deserializes the JSON string into a list of User objects and returns it.  
            return System.Text.Json.JsonSerializer.Deserialize<List<User>>(jsonString);
        }
        #endregion
    }
}
