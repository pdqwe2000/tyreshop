//-----------------------------------------------------------------​
//    <copyright file="TyreService.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Data;

namespace Tyre_Shop.Classes.Services

{
    /// <summary>
    /// Provides services related to tyre addition, removal and update.
    /// </summary>
    public class TyreService
    {
        #region Singleton Implementation
        private static TyreService _instance; // Única instância da classe
        private static readonly object _lock = new object(); // Lock para threads simultâneas
        #endregion

        #region Private Fields
        private readonly string _dataFilePath = Fpm.Instance.DataFilePath; // Path to the users data file
        #endregion

        #region Public Properties
        /// <summary>
        /// The base path where the application data files will be stored.
        /// </summary>
        public List<TyreJson> TyreStock { get; private set; } // Lista de pneus carregada
        #endregion

        #region Private Constructor
        /// <summary>
        /// Private constructor to initialize file paths and ensure the necessary directories exist.
        /// </summary>
        private TyreService()
        {
            TyreStock = new List<TyreJson>();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Carrega pneus de um arquivo JSON para memória.
        /// </summary>
        /// <param name="path">Caminho do arquivo JSON.</param>
        public async Task LoadTyresFromJsonAsync()
        {

            if (!File.Exists(_dataFilePath))
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(_dataFilePath))
                {
                    string json = await reader.ReadToEndAsync();
                    TyreStock = JsonSerializer.Deserialize<List<TyreJson>>(json) ?? new List<TyreJson>();
                }

                Console.WriteLine("Stock de pneus carregado com sucesso.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar stock de pneus: {ex.Message}");
            }

        }
        public async Task SaveTyresToJsonAsync()
        {
            try
            {
                // Serialize the list of users to JSON
                string json = JsonSerializer.Serialize(TyreStock, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON string to the file
                using (StreamWriter writer = new StreamWriter(_dataFilePath))
                {
                    await writer.WriteAsync(json);
                }

                Console.WriteLine("Stock de pneus salvo com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar stock de pneus: {ex.Message}");
            }
        }

        public async Task AddOrUpdateTyreAsync(TyreJson newTyre)
        {
            if (TyreStock.Count == 0)
            {
                Console.WriteLine("Stock is empty, loading from file...");
                await LoadTyresFromJsonAsync();
            }

            var existingTyre = TyreStock.Find(t =>
                t.Brand.Equals(newTyre.Brand, StringComparison.OrdinalIgnoreCase) &&
                t.Model.Equals(newTyre.Model, StringComparison.OrdinalIgnoreCase) &&
                t.Size.Equals(newTyre.Size, StringComparison.OrdinalIgnoreCase) &&
                t.Quality == newTyre.Quality &&
                t.Price == newTyre.Price);

            if (existingTyre != null)
            {
                existingTyre.Quantity += newTyre.Quantity;
                Console.WriteLine($"Updated quantity for {existingTyre.Brand} {existingTyre.Model}. New quantity: {existingTyre.Quantity}");
            }
            else
            {
                //TyreStock.Add(newTyre);
                //Console.WriteLine($"Added new tyre: {newTyre.Brand} {newTyre.Model}");
                // Assign a new unique Id for the new tyre (based on the maximum existing Id).
                newTyre.Id = TyreStock.Count > 0 ? TyreStock.Max(t => t.Id) + 1 : 1;

                // Add the new tyre to the stock.
                TyreStock.Add(newTyre);
                Console.WriteLine($"Added new tyre: {newTyre.Brand} {newTyre.Model} with Id {newTyre.Id}");
            }

            await SaveTyresToJsonAsync();
        }

        /// <summary>
        /// Obtém o stock de pneus atual.
        /// </summary>
        /// <returns>Lista de pneus.</returns>
        public List<TyreJson> GetTyreStock()
        {
            return TyreStock;
        }
        #endregion

        public static TyreService Instance
        {
            get
            {
                lock (_lock) // Garante thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new TyreService();
                    }
                    return _instance;
                }
            }
        }
    }
}
