using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.classes
{
    public class UserRepo
    {
        private readonly string caminhoArquivo = "usuarios.bin";

        // Método para salvar lista de usuários em um arquivo binário
        public void SalvarUsuarios(List<User> usuarios)
        {
            using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, usuarios);
            }
        }

        // Método para carregar lista de usuários do arquivo binário
        public List<User> CarregarUsuarios()
        {
            if (!File.Exists(caminhoArquivo))
                return new List<User>();

            using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<User>)formatter.Deserialize(fs);
            }
        }
    }
}
