//-----------------------------------------------------------------​
//    <copyright file="Sale.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;


namespace Tyre_Shop.Classes
{
    /// <summary>
    /// This class represents a Sale in the Tyre Shop system.
    /// </summary>
    public class Sale
    {
        #region Properties
        public int Id { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public List<TyreJson> TyreSold { get; set; }
        public decimal TotalPrice { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Sale"/> class.
        /// Has the sold tyres.
        /// </summary>
        public Sale()
        {
            TyreSold = new List<TyreJson>();
        }
        #endregion

       
    }
}
