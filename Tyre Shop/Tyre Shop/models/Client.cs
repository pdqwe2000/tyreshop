using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.models;

namespace Tyre_Shop.classes
{
    public class Client:Person
    {
        private bool Empresa { get;  set; }

        public Client(string name, string phone, bool empresa):base(name,phone)
        {
            Empresa = empresa;
          
        }

        public override string ToString()
        {
            return $"{Name} - Telefone: {Phone}";
        }
    }

}
