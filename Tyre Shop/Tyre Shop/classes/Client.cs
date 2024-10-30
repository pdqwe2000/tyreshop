using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.classes
{
    internal class Client
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }

        public Client(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name} - Telefone: {Phone}";
        }
    }

}
