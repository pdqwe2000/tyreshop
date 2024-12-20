//-----------------------------------------------------------------
//    <copyright file="TyreFacade.cs" company="FujiSoft">
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
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.Classes.Facade
{
    /// <summary>
    /// Facade class to manage tyre-related operations by interacting with the <see cref="TyreService"/> class.
    /// </summary>
    public class TyreFacade
    {
        #region Private Fields

        private readonly TyreService _service; // Singleton instance of TyreService

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TyreFacade"/> class.
        /// </summary>
        public TyreFacade()
        {
            _service = TyreService.Instance; // Initialize the singleton service
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a new tyre to the stock or updates an existing tyre asynchronously.
        /// </summary>
        /// <param name="newTyre">The tyre to be added or updated.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task AddOrUpdateTyreAsync(TyreJson newTyre)
        {
            if (newTyre == null)
                throw new ArgumentNullException(nameof(newTyre), "Tyre cannot be null.");

            await _service.AddOrUpdateTyreAsync(newTyre);
        }

        /// <summary>
        /// Loads tyres from the JSON file asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task LoadTyresFromFileAsync()
        {
            await _service.LoadTyresFromJsonAsync();
        }

        /// <summary>
        /// Displays all tyres currently available in the stock.
        /// </summary>
        public void DisplayTyres()
        {
            var tyres = GetStock();

            if (tyres.Count == 0)
            {
                Console.WriteLine("No tyres available in stock.");
                return;
            }

            Console.WriteLine("Current Tyre Stock:");
            foreach (var tyre in tyres)
            {
                Console.WriteLine($"- Brand: {tyre.Brand}, Model: {tyre.Model}, Size: {tyre.Size}, Quality: {tyre.Quality}, Quantity: {tyre.Quantity}, Price: {tyre.Price:C}");
            }
        }

        /// <summary>
        /// Retrieves the current stock of tyres.
        /// </summary>
        /// <returns>A list of tyres in stock.</returns>
        public List<TyreJson> GetStock()
        {
            return _service.GetTyreStock();
        }

        /// <summary>
        /// Saves the current tyre stock to the JSON file asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task SaveToJson()
        {
            await _service.SaveTyresToJsonAsync();
        }

        #endregion
    }
}
