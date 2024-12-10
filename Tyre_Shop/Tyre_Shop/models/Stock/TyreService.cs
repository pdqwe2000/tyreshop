using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Tyre_Shop.classes.data;

namespace Tyre_Shop.classes
{
    public class TyreService
    {
        #region Private Fields
        private readonly string _dataFilePath = Fpm.Instance.DataFilePath; // Path to the users data file
        #endregion
        #region Properties
        
        #endregion

        #region Methods

        /// <summary>  
        /// Method to save a list of users to a JSON file.  
        /// </summary>  
        /// <param name="tyres">List of Users to save in JSON.</param>  

        public void SaveTyres(List<Tyre> tyres)
        {
            // Serializes the list of users into a JSON-formatted string.  
            string jsonString = System.Text.Json.JsonSerializer.Serialize(tyres, new JsonSerializerOptions
            {
                WriteIndented = true  // Formats the JSON with indentation for better readability.  
            });

            // Writes the JSON string to the file specified by the path variable.  
            File.WriteAllText(_dataFilePath, jsonString);
        }

        /// <summary>  
        /// Method to load a list of users from the JSON file.
        /// </summary>  

        public async Task<List<TyreJson>> LoadTyresAsync()
        {
           
            // Checks if the JSON file exists at the specified path.  
            if (!File.Exists(_dataFilePath))
                return new List<TyreJson>();

            // Read the file and deserialize the JSON content into a list of users
            using (StreamReader reader = new StreamReader(_dataFilePath))
            {
                string json = await reader.ReadToEndAsync();
                var tyreStock = JsonSerializer.Deserialize<List<TyreJson>>(json) ?? new List<TyreJson>(); // Deserialize and return users
                return tyreStock;
            }

            

            //// Reads the content of the JSON file into a string.  
            //string jsonString = File.ReadAllText(_dataFilePath);

            //var tyreStock = JsonConvert.DeserializeObject<List<TyreJson>>(jsonString);

            //// Deserializes the JSON string into a list of User objects and returns it.  
            //return tyreStock;
        }
        #endregion
    }
}
