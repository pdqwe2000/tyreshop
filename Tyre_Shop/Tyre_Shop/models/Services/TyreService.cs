//-----------------------------------------------------------------
//    <copyright file="TyreService.cs" company="FujiSoft">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>19-12-2024</date>
//    <time>23:00</time>
//    <version>0.1</version>
//    <author>Pedro Duarte</author>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Data;

namespace Tyre_Shop.Classes.Services
{
    /// <summary>
    /// Provides services for managing tyres, including adding, removing, updating, and loading tyres.
    /// </summary>
    public class TyreService
    {
        #region Singleton Implementation

        private static TyreService _instance; // Singleton instance
        private static readonly object _lock = new object(); // Lock for thread safety

        /// <summary>
        /// Gets the singleton instance of the TyreService class.
        /// </summary>
        public static TyreService Instance
        {
            get
            {
                lock (_lock) // Ensures thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new TyreService();
                    }
                    return _instance; 
                }
            }
        }

        #endregion

        #region Private Fields

        private readonly string _dataFilePath = Fpm.Instance.DataFilePath; // Path to the tyre data file

        #endregion

        #region Public Properties

        /// <summary>
        /// The current stock of tyres.
        /// </summary>
        public List<TyreJson> TyreStock { get; private set; }

        #endregion

        #region Private Constructor

        /// <summary>
        /// Private constructor to initialize the TyreService and load an empty tyre stock.
        /// </summary>
        private TyreService()
        {
            TyreStock = new List<TyreJson>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Asynchronously loads tyres from a JSON file into memory.
        /// </summary>
        public async Task LoadTyresFromJsonAsync()
        {
            if (!File.Exists(_dataFilePath))
            {
                Console.WriteLine("JSON file not found.");
                return;
            }

            try
            {
                var reader = new StreamReader(_dataFilePath);
                string json = await reader.ReadToEndAsync();
                TyreStock = JsonSerializer.Deserialize<List<TyreJson>>(json) ?? new List<TyreJson>();
                Console.WriteLine("Tyre stock loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tyre stock: {ex.Message}");
            }
        }

        /// <summary>
        /// Asynchronously saves the current tyre stock to a JSON file.
        /// </summary>
        public async Task SaveTyresToJsonAsync()
        {
            try
            {
                string json = JsonSerializer.Serialize(TyreStock, new JsonSerializerOptions { WriteIndented = true });

                var writer = new StreamWriter(_dataFilePath);
                await writer.WriteAsync(json);

                Console.WriteLine("Tyre stock saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tyre stock: {ex.Message}");
            }
        }

        /// <summary>
        /// Asynchronously adds a new tyre to the stock or updates the quantity of an existing tyre.
        /// </summary>
        /// <param name="newTyre">The new tyre to be added or updated.</param>
        public async Task AddOrUpdateTyreAsync(TyreJson newTyre)
        {
            if (TyreStock.Count == 0)
            {
                Console.WriteLine("Stock is empty, loading from file...");
                await LoadTyresFromJsonAsync();
            }

            // Check if the tyre already exists in stock
            var existingTyre = TyreStock.Find(t =>
                t.Brand.Equals(newTyre.Brand, StringComparison.OrdinalIgnoreCase) &&
                t.Model.Equals(newTyre.Model, StringComparison.OrdinalIgnoreCase) &&
                t.Size.Equals(newTyre.Size, StringComparison.OrdinalIgnoreCase) &&
                t.Quality == newTyre.Quality &&
                t.Price == newTyre.Price);

            if (existingTyre != null)
            {
                existingTyre.Quantity += newTyre.Quantity; // Update quantity
                Console.WriteLine($"Updated quantity for {existingTyre.Brand} {existingTyre.Model}. New quantity: {existingTyre.Quantity}");
            }
            else
            {
                // Assign a unique ID for the new tyre
                newTyre.Id = TyreStock.Count > 0 ? TyreStock.Max(t => t.Id) + 1 : 1;

                // Add the new tyre to the stock
                TyreStock.Add(newTyre);
                Console.WriteLine($"Added new tyre: {newTyre.Brand} {newTyre.Model} with Id {newTyre.Id}");
            }

            // Save the updated tyre stock to the JSON file
            await SaveTyresToJsonAsync();
        }

        /// <summary>
        /// Retrieves the current tyre stock.
        /// </summary>
        /// <returns>The list of tyres in stock.</returns>
        public List<TyreJson> GetTyreStock()
        {
            return TyreStock;
        }

        #endregion
    }
}
