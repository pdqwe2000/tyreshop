//-----------------------------------------------------------------
//    <copyright file="SaleServices.cs" company="FujiSoft">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>19-12-2024</date>
//    <time>23:00</time>
//    <version>0.1</version>
//    <author>Pedro Duarte</author>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Tyre_Shop.Classes.Data;
using Tyre_Shop.Classes.Interfaces;

namespace Tyre_Shop.Classes.Services
{
    /// <summary>
    /// Provides services related to sales management.
    /// </summary>
    internal class SaleServices : ISale
    {
        #region Singleton Implementation

        private static SaleServices _instance; // Singleton instance
        private static readonly object _lock = new object(); // Lock for thread safety

        /// <summary>
        /// Gets the singleton instance of the SaleServices class.
        /// </summary>
        public static SaleServices Instance
        {
            get
            {
                lock (_lock) // Ensures thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new SaleServices();
                    }
                    return _instance;
                }
            }
        }
        
        #endregion

        #region Private Fields

        private readonly List<Sale> _sales; // List to store sales
        private static int _currentId = 1; // Tracks the current ID for sales
        private readonly string _dataFilePath = Fpm.Instance.DataFilePath; // Path to sales data file

        #endregion

        #region Constructor

        /// <summary>
        /// Private constructor to enforce the Singleton pattern.
        /// </summary>
        private SaleServices()
        {
            _sales = new List<Sale>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Records a new sale and assigns a unique ID.
        /// </summary>
        /// <param name="sale">The sale object to be recorded.</param>
        public void AddSale(Sale sale)
        {
            sale.Id = _currentId++;
            _sales.Add(sale);
            Console.WriteLine($"Sale recorded successfully. Sale ID: {sale.Id}");
        }

        /// <summary>
        /// Retrieves all sales.
        /// </summary>
        /// <returns>A list of all recorded sales.</returns>
        public List<Sale> GetAllSales()
        {
            return _sales;
        }

        /// <summary>
        /// Retrieves a sale by its unique ID.
        /// </summary>
        /// <param name="id">The ID of the sale to retrieve.</param>
        /// <returns>The sale object if found; otherwise, null.</returns>
        public Sale GetSaleById(int id)
        {
            return _sales.FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Calculates the total cost of a list of tyres.
        /// </summary>
        /// <param name="items">The list of tyres.</param>
        /// <returns>The total cost of the tyres.</returns>
        public decimal CalculateTotal(List<TyreJson> items)
        {
            return items.Sum(t => t.Price * t.Quantity);
        }

        #endregion
    }
}
