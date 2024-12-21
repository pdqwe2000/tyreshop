//-----------------------------------------------------------------​
//    <copyright file="ISale.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System.Collections.Generic;

namespace Tyre_Shop.Classes.Interfaces
{
    internal interface ISale

    {
        /// <summary>
        /// Adds a Sale.
        /// </summary>
        /// <param name="sale">The message content.</param>
        void AddSale(Sale sale);

        /// <summary>
        /// gets sales .
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="caption">The message box caption.</param>
        /// <param name="icon">The icon to display in the message box.</param>
        List<Sale> GetAllSales();

        /// <summary>
        /// Displays a message to the user.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="caption">The message box caption.</param>
        /// <param name="icon">The icon to display in the message box.</param>
        Sale GetSaleById(int id);

        /// <summary>
        /// Displays a message to the user.
        /// </summary>
        /// <param name="message">The message content.</param>
        /// <param name="caption">The message box caption.</param>
        /// <param name="icon">The icon to display in the message box.</param>
        decimal CalculateTotal(List<TyreJson> items);
    }
}
