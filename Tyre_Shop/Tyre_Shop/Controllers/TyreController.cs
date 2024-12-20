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
        #region Private Fields
        private readonly TyreFacade _facade; // Facade to handle tyre operations.
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TyreController"/> class.
        /// </summary>
        public TyreController()
        {
            _facade = new TyreFacade();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds or updates a tyre in the stock asynchronously.
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
        /// Loads tyres from the JSON file asynchronously.
        /// </summary>
        public async Task LoadTyresAsync()
        {
            Console.WriteLine("Loading tyre stock from file...");
            await _facade.LoadTyresFromFileAsync();
        }

        #endregion
    }
}
