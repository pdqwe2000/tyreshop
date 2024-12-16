using System;
using System.Collections.Generic;
using Tyre_Shop.Classes.Data;

namespace Tyre_Shop.Classes
{
    internal class Shop
    {
        #region Properties
        private Stock stock;
        private List<Sell> sellings;
        private int nextIdSell = 1;
        #endregion

        #region Constructors
        public Shop()
        {
            stock = new Stock();
            sellings = new List<Sell>();
        }
        #endregion

        #region Methods
        public async void LoadStockFromJson() => await stock.LoadStockFromJson();

        public async void AddNewTyre(TyreJson newTyre)
        {
            var stockManager = TyreService.Instance;
            await stockManager.AddOrUpdateTyreAsync(newTyre);
            Console.WriteLine("Novo pneu adicionado ao stock.");
        }

        public void ShowStock()
        {
            Console.WriteLine("Stock:");
            stock.ShowTyres();
        }

        public void ShowSellings()
        {
            Console.WriteLine("Sellings Made:");
            foreach (var sell in sellings)
            {
                Console.WriteLine(sell);
            }
        }
        #endregion
    }
}
