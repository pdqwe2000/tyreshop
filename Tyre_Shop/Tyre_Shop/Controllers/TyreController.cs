//-----------------------------------------------------------------​
//    <copyright file="TyreController.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------
using System;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.Classes.Controller
{
    public class TyreController
    {
        private readonly TyreFacade _facade;

        public TyreController()
        {
            _facade = new TyreFacade();
        }

        /// <summary>
        /// Adds or updates a tyre in the stock.
        /// </summary>
        /// <param name="newTyre">The tyre to be added or updated.</param>
        public async Task AddOrUpdateTyreAsync(TyreJson newTyre)
        {
            Console.WriteLine("Processing tyre addition or update...");
            await _facade.AddOrUpdateTyreAsync(newTyre);
        }

        /// <summary>
        /// Displays the current stock of tyres.
        /// </summary>
        public void ShowTyres()
        {
            Console.WriteLine("Fetching tyre stock...");
            _facade.DisplayTyres();
        }

        /// <summary>
        /// Loads tyres from the JSON file.
        /// </summary>
        public async Task LoadTyresAsync()
        {
            Console.WriteLine("Loading tyre stock from file...");
            await _facade.LoadTyresFromFileAsync();
        }
    }
}
