using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.source.interfaces;

namespace Tyre_Shop.models
{
    public abstract class Person
    {
        #region Private Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        
        #endregion

        public Person(string nome, string phone) {
            Name = nome;
            Phone = phone;
        } 


    }
}
