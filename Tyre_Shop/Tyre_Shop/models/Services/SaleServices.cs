using System;
using System.Collections.Generic;
using System.Linq;
using Tyre_Shop.Classes.Data;
using Tyre_Shop.Classes.Interfaces;

namespace Tyre_Shop.Classes.Services
{
    internal class SaleServices:ISale
    {
        #region Singleton Implementation
        private static SaleServices _instance; // Única instância da classe
        private static readonly object _lock = new object(); // Lock para threads simultâneas
        #endregion

        #region Private Fields
        private readonly string _dataFilePath = Fpm.Instance.DataFilePath; // Path to the users data file
        #endregion

        private readonly List<Sale> _sales = new List<Sale>();
        private static int _currentId = 1;


        private SaleServices()
        {
            _sales = new List<Sale>();
        }
        public void AddSale(Sale sale)
        {
            sale.Id = _currentId++;
            _sales.Add(sale);
            Console.WriteLine($"Sale recorded successfully. Sale ID: {sale.Id}");
        }

        public List<Sale> GetAllSales()
        {
            return _sales;
        }

        public Sale GetSaleById(int id)
        {
            return _sales.FirstOrDefault(s => s.Id == id);
        }

        public decimal CalculateTotal(List<TyreJson> items)
        {
            return items.Sum(t => t.Price * t.Quantity);
        }

        public static SaleServices Instance
        {
            get
            {
                lock (_lock) // Garante thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new SaleServices();
                    }
                    return _instance;
                }
            }
        }
    }
}

