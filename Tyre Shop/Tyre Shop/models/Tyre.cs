using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.models;

namespace Tyre_Shop.classes
{
    public class Tyre
    {
        public int Id { get;  set; }
        public string Brand { get;  set; }
        public string Model { get;  set; }
        public string Size { get; set; }
        
        public Quality Quality { get;  set; }
        public int Price { get; set; }
        public Tyre()
        {
        }

        public Tyre(int id, string brand, string model, string size, Quality quality, int price)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Size = size;
            this.Quality = quality;
            this.Price = price;
        }
     

    }
}
