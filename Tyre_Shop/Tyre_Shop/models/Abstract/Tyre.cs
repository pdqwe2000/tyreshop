namespace Tyre_Shop.classes
{
    // This class represents a Tyre entity in the Tyre Shop system.
    public class Tyre
    {
        #region Properties
        // Unique identifier for the tyre.
        public int Id { get; set; }
        // Brand of the tyre (e.g., Michelin, Bridgestone).
        public string Brand { get; set; }
        // Model of the tyre (e.g., Pilot Sport 4, Turanza T005).
        public string Model { get; set; }
        // Size of the tyre (e.g., 205/55 R16).
        public string Size { get; set; }
        // Quality of the tyre, represented by an enum (e.g., AAA, AA, etc.).
        public Quality Quality { get; set; }
        // Price of the tyre in the system.
        public int Price { get; set; }
        #endregion

        #region Constructors
        // Default constructor for creating a Tyre object with no initial data.
        public Tyre()
        {
        }
        // Parameterized constructor to create a Tyre object with specific details.
        public Tyre(int id, string brand, string model, string size, Quality quality, int price)
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