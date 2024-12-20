//-----------------------------------------------------------------​
//    <copyright file="SaleController.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------​

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.Classes.Controller
{
    /// <summary>
    /// Controller responsible for handling sales operations, including verifying tyre stock,
    /// updating inventory, and registering sales.
    /// </summary>
    internal class SaleController
    {
        #region Private Fields

        private readonly SaleFacade _saleFacade;        // Facade for managing sale-related tasks.
        private readonly TyreFacade _facade;            // Facade for managing tyre stock.

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleController"/> class.
        /// Sets up services and facades required for sales operations.
        /// </summary>
        public SaleController()
        {
            _saleFacade = new SaleFacade();
            _facade = new TyreFacade();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Verifies if a tyre exists in stock, creates a sale, and updates the inventory.
        /// </summary>
        /// <param name="id">The ID of the tyre to sell.</param>
        /// <param name="client">The client purchasing the tyre.</param>
        /// <param name="quantity">The quantity of tyres being sold.</param>
        public async Task VerifyExistenceTyre(int id, Client client, int quantity)
        {
            // Get the tyre from the stock
            var tyreToSell = _facade.GetStock().FirstOrDefault(t => t.Id == id);

            if (tyreToSell == null || tyreToSell.Quantity < quantity)
            {
                MessageBox.Show("Stock insufficient or tyre not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a list with the items to sell
            var tyresToSell = new List<TyreJson>
            {
                new TyreJson
                {
                    Id = tyreToSell.Id,
                    Brand = tyreToSell.Brand,
                    Model = tyreToSell.Model,
                    Size = tyreToSell.Size,
                    Price = tyreToSell.Price,
                    Quantity = quantity
                }
            };

            // Perform the sale
            await RegisterSale(client, tyresToSell);
            MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Registers a sale, updates the stock, and saves the updated inventory to a file.
        /// </summary>
        /// <param name="client">The client purchasing the tyres.</param>
        /// <param name="tyresToSell">The list of tyres being sold.</param>
        public async Task RegisterSale(Client client, List<TyreJson> tyresToSell)
        {
            // Update stock quantities
            foreach (var tyre in tyresToSell)
            {
                var existingTyre = _facade.GetStock().FirstOrDefault(t => t.Id == tyre.Id);

                if (existingTyre != null && existingTyre.Quantity >= tyre.Quantity)
                {
                    existingTyre.Quantity -= tyre.Quantity;
                }
                else
                {
                    Console.WriteLine($"Insufficient stock for {tyre.Brand} {tyre.Model}.");
                    MessageBox.Show($"Insufficient stock for {tyre.Brand} {tyre.Model}.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Register the sale
            var sale = new Sale
            {
                Date = DateTime.Now,
                Client = client,
                TyreSold = tyresToSell,
                TotalPrice = _saleFacade.CalculateTotal(tyresToSell)
            };

            _saleFacade.AddSale(sale);

            // Log and save updates
            Console.WriteLine($"Sale completed. Total: {sale.TotalPrice:C}");
            MessageBox.Show($"Sale completed. Total: {sale.TotalPrice:C}", "Sale Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await _facade.SaveToJson(); // Save the updated stock
        }

        #endregion
    }
}
