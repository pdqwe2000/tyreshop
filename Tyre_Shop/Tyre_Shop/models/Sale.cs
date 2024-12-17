using System;
using System.Collections.Generic;


namespace Tyre_Shop.Classes
{
    internal class Sale
    {
        #region Properties
        public int Id { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public List<TyreJson> TyreSold { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion

        #region Constructors
        public Sale()
        {
            TyreSold = new List<TyreJson>();
        }
        #endregion

        #region Methods
        //public void AddTyre(Tyre tyre)
        //{
        //    TyreSold.Add(tyre);
        //    TotalPrice += tyre.Price;
        //}

        //public override string ToString()
        //{
        //    return $"Selling #{Id} - Client: {Client.Name} - Date: {SellDate} - Total: {TotalPrice}E";
        //}
        #endregion
    }
}
