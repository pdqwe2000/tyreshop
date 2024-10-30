using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.classes
{
    public class Tyre
    {
        public int Id { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Size { get; private set; }
        public int Quality { get; private set; }
        public int Price { get; private set; }
       // public int Quantity { get; private set; }

        public Tyre()
        {
        }

        public Tyre(int id, string brand, string model, string size, int quality, int price/*, int quantity*/)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Size = size;
            this.Quality = quality;
            this.Price = price;
            //this.Quantity = quantity;
        }
        //public int getId()
        //{
        //    return Id;
        //}
        //public string getBrand()
        //{
        //    return Brand;
        //}
        //public string getModel()
        //{
        //    return Model;
        //}
        //public string getSize()
        //{
        //    return Size;
        //}
        //public int getQuality()
        //{
        //    return Quality;
        //}
        //public int getPrice()
        //{
        //    return Price;
        //}
        //public int getQuantity()
        //{
        //    return Quantity;
        //}

    }
}
