//-----------------------------------------------------------------​
//    <copyright file="TyreFacade.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.Classes.Facade
{
    public class TyreFacade
    {

        //private readonly Tsms _service;
        private readonly TyreService _service;

        public TyreFacade()
        {
            _service = TyreService.Instance; // Singleton instance
        }

        /// <summary>
        /// Adds or updates a tyre in the stock.
        /// </summary>
        /// <param name="newTyre">The tyre to be added or updated.</param>
        public async Task AddOrUpdateTyreAsync(TyreJson newTyre)
        {
            await _service.AddOrUpdateTyreAsync(newTyre);
        }

        /// <summary>
        /// Loads tyres from the JSON file.
        /// </summary>
        public async Task LoadTyresFromFileAsync()
        {
            await _service.LoadTyresFromJsonAsync();
        }

        /// <summary>
        /// Displays all tyres in the stock.
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
                Console.WriteLine($"- {tyre.Brand} {tyre.Model}, Size: {tyre.Size}, Quality: {tyre.Quality}, Quantity: {tyre.Quantity}, Price: {tyre.Price}");
            }
        }
        public List<TyreJson> GetStock()
        {
            return _service.GetTyreStock();
        }

        public async Task SaveToJson()
        {
            await _service.SaveTyresToJsonAsync();
        }
    }
}
