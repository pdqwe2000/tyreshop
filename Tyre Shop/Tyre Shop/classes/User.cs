using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.classes
{
    public class User
    {
        public string Nome { get; set; }
        public string Senha { get; set; }  // Idealmente, use uma senha hash em um sistema real para segurança

        public User(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
    }
    
    
}
