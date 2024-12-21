//-----------------------------------------------------------------​
//    <copyright file="Tyre.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

namespace Tyre_Shop.Classes
{
    /// <summary>
    /// This class represents a Tyre entity in the Tyre Shop system.
    /// </summary>
    public class Tyre
    {
        #region Properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public Quality Quality { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor for creating a Tyre object with no initial data.
        /// <param name="">Empty constructer</param>
        /// </summary>
        public Tyre()
        {
        }
        /// <summary>
        /// Parameterized constructor to create a Tyre object with specific details.
        /// <param name="id"> Unique identifier for the tyre.</param>
        /// <param name="brand">Brand of the tyre (e.g., Michelin, Bridgestone).</param>
        /// <param name="model">Model of the tyre (e.g., Pilot Sport 4, Turanza T005).</param>
        /// <param name="size">Size of the tyre (e.g., 205/55 R16).</param>
        /// <param name="quality">Quality of the tyre, represented by an enum (e.g., AAA, AA, etc.).</param>
        /// <param name="price">Price of the tyre in the system.</param>
        /// </summary>
        public Tyre(int id, string brand, string model, string size, Quality quality, decimal price)
        {
            this.Id = id;          // Assigns the unique ID to the tyre.
            this.Brand = brand;    // Assigns the brand name.
            this.Model = model;    // Assigns the model name.
            this.Size = size;      // Assigns the tyre size.
            this.Quality = quality;// Assigns the tyre's quality.
            this.Price = price;    // Assigns the tyre's price.
        }
        #endregion
    }
}