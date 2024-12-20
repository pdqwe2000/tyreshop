//-----------------------------------------------------------------
//    <copyright file="SaleFacade.cs" company="FujiSoft">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>19-12-2024</date>
//    <time>23:00</time>
//    <version>0.1</version>
//    <author>Pedro Duarte</author>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Controller;
using Tyre_Shop.Classes.Interfaces;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.Classes.Facade
{
    /// <summary>
    /// Facade class to handle sales-related functionality by abstracting
    /// the interactions with the <see cref="SaleServices"/> class.
    /// </summary>
    public class SaleFacade
    {
        #region Private Fields

        private readonly SaleServices _service; // Singleton instance of SaleServices

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleFacade"/> class.
        /// </summary>
        public SaleFacade()
        {
            _service = SaleServices.Instance;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Performs a sale operation asynchronously, handling the provided client and tyres to sell.
        /// </summary>
        /// <param name="client">The client making the purchase.</param>
        /// <param name="tyresToSell">The list of tyres to be sold.</param>
        /// <returns>A task that represents the asynchronous sale operation.</returns>
        public async Task PerformSale(Client client, List<TyreJson> tyresToSell)
        {
            //try
            //{
            //    // Validate stock availability for each tyre
            //    foreach (var tyre in tyresToSell)
            //    {
            //        if (tyre.Quantity <= 0)
            //            throw new InvalidOperationException($"Invalid quantity for tyre ID {tyre.Id}.");

            //        var stockTyre = TyreService.Instance.GetTyreById(tyre.Id);

            //        if (stockTyre == null || stockTyre.Quantity < tyre.Quantity)
            //        {
            //            throw new InvalidOperationException($"Insufficient stock for tyre ID {tyre.Id}.");
            //        }

            //        // Deduct the sold quantity from stock
            //        stockTyre.Quantity -= tyre.Quantity;
            //    }

            //    // Register the sale
            //    var sale = new Sale
            //    {
            //        Client = client,
            //        TyreSold = tyresToSell,
            //        Date = DateTime.Now,
            //        TotalPrice = CalculateTotal(tyresToSell)
            //    };

            //    AddSale(sale);

            //    // Save updated stock and sales data
            //    await TyreService.Instance.SaveStockAsync();
            //    await SaleServices.Instance.SaveSalesAsync();

            //    Console.WriteLine("Sale successfully completed.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error performing sale: {ex.Message}");
            //    throw; // Optionally re-throw the exception to be handled upstream
            //}
        }

        /// <summary>
        /// Calculates the total cost of a sale based on the provided items.
        /// </summary>
        /// <param name="items">The list of tyres being sold.</param>
        /// <returns>The total cost as a decimal value.</returns>
        public decimal CalculateTotal(List<TyreJson> items)
        {
            return _service.CalculateTotal(items);
        }

        /// <summary>
        /// Adds a new sale to the system.
        /// </summary>
        /// <param name="sale">The sale object to be added.</param>
        public void AddSale(Sale sale)
        {
            _service.AddSale(sale);
        }

        #endregion
    }
}
