using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.models;

namespace Tyre_Shop.classes
{
    public class User:Person
    {
        
        public string Senha { get; set; } 
        public bool Admin { get; set; }
        public User(string name, string phone, string senha, bool admin) :base(name,phone) 
        {
            Senha = senha;
            Admin = admin;
        }
    }
    
    
}
