
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.Reflection;


namespace Tyre_Shop.classes
{
    public class UserRepo
    {
        public static string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;
        public static string path = Path.Combine(rootPath, "assets", "Users.json");

        //public static string MainFolderPath = "models";

        //public static string path = Path.Combine(MainFolderPath, "Users.json");

        //Tyre Shop\assets\

        // Método para salvar lista de usuários em um arquivo JSON
        public void SaveUser(List<User> usuarios)
        {
            
            // Serializa a lista de usuários para JSON
            string jsonString = System.Text.Json.JsonSerializer.Serialize(usuarios, new JsonSerializerOptions
            {
                WriteIndented = true  // Indenta o JSON para melhor leitura
            });

            // Salva o JSON em um arquivo
            File.WriteAllText(path, jsonString);
        }

        // Método para carregar lista de usuários do arquivo JSON
        public List<User> LoadUsers()
        {
            
            // Verifica se o arquivo JSON existe
            if (!File.Exists(path))
            {
                MessageBox.Show("No path!");
                return new List<User>();
            }

            // Lê o conteúdo do arquivo JSON
            string jsonString = File.ReadAllText(path);

            // Desserializa o JSON para uma lista de objetos User
            return System.Text.Json.JsonSerializer.Deserialize<List<User>>(jsonString);
        }
    }
}
