﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Tyre_Shop.classes;
using Tyre_Shop.classes.auth;
using Tyre_Shop.classes.data;

namespace Tyre_Shop.models.Data
{
    internal class Tsms
    {
        #region Singleton Implementation
        private static Tsms _instance; // Única instância da classe
        private static readonly object _lock = new object(); // Lock para threads simultâneas
        #endregion

        #region Public Properties
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
        private Tsms()
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
                    TyreStock = JsonSerializer.Deserialize<List<TyreJson>>(json) ?? new List<TyreJson>(); // Deserialize and return users
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
                t.Model.Equals(newTyre.Model, StringComparison.OrdinalIgnoreCase));

            if (existingTyre != null)
            {
                existingTyre.Quantity += newTyre.Quantity;
                Console.WriteLine($"Updated quantity for {existingTyre.Brand} {existingTyre.Model}. New quantity: {existingTyre.Quantity}");
            }
            else
            {
                TyreStock.Add(newTyre);
                Console.WriteLine($"Added new tyre: {newTyre.Brand} {newTyre.Model}");
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

        public static Tsms Instance
        {
            get
            {
                lock (_lock) // Garante thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new Tsms();
                    }
                    return _instance;
                }
            }
        }
    }
}
