using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Tyre_Shop.classes
{
    public class Stock
    {
        #region Properties
        private TyreRepo repos = new TyreRepo();

        private Dictionary<Tyre, int> tyresInStock;
        // Root path of the application, determined dynamically based on the location of the executing assembly.  
        private static string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;
        // Path to the JSON file where user data is stored.  
        private static string path = Path.Combine(rootPath, "assets", "Data.json");
        #endregion

        #region Constructors
        public Stock()
        {
            tyresInStock = new Dictionary<Tyre, int>();
        }
        #endregion

        #region Methods

        public void LoadStockFromJson()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("JSON Not Found.");
                return;
            }

            try
            {

                //// Lê o conteúdo do arquivo JSON
                //string json = File.ReadAllText(path);

                //// Desserializa o JSON para uma lista temporária de pneus com quantidade
                //var tyreList = JsonConvert.DeserializeObject<List<TyreJson>>(json);

                var tyreList = repos.LoadTyres();

                foreach (var tyreJson in tyreList)
                {
                    // Converte TyreJson para Tyre e adiciona ao estoque
                    var tyre = new Tyre
                    {
                        Id = tyreJson.Id,
                        Brand = tyreJson.Brand,
                        Model = tyreJson.Model,
                        Size = tyreJson.Size,
                        Quality = tyreJson.Quality,
                        Price = tyreJson.Price,
                    };

                    AddTyre(tyre, tyreJson.Quantity);
                }

                Console.WriteLine("Stock Loaded From JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Loading JSON File: " + ex.Message);
            }
        }

        public void AddTyre(Tyre tyre, int quantity)
        {
            if (tyresInStock.ContainsKey(tyre))
            {
                tyresInStock[tyre] += quantity;
            }
            else
            {
                tyresInStock[tyre] = quantity;
            }
        }

        public bool RemoveTyre(Tyre tyre, int quantity)
        {
            if (tyresInStock.ContainsKey(tyre) && tyresInStock[tyre] >= quantity)
            {
                tyresInStock[tyre] -= quantity;
                return true;
            }

            Console.WriteLine($"Insuficient Stock: {tyre.Brand}");
            return false;
        }

        public int VerifyQuantity(Tyre tyre)
        {
            return tyresInStock.ContainsKey(tyre) ? tyresInStock[tyre] : 0;
        }

        public void ShowTyres()
        {
            foreach (var tyre in tyresInStock)
            {
                Console.WriteLine($"Tyre: {tyre.Key.Brand} {tyre.Key.Model} Size: {tyre.Key.Size} Quality: {tyre.Key.Quality} - Quantity: {tyre.Value} Price: {tyre.Key.Price} ");
            }
        }
        #endregion
    }
}

//public void AddTyre(Tyre tyre, int quantidade)
//{
//    if (tyresInStock.ContainsKey(tyre))
//    {
//        tyresInStock[tyre] += quantidade;
//    }
//    else
//    {
//        tyresInStock[tyre] = quantidade;
//    }
//}

//public bool RemoveTyre(Tyre tyre, int quantidade)
//{
//    if (tyresInStock.ContainsKey(tyre) && tyresInStock[tyre] >= quantidade)
//    {
//        tyresInStock[tyre] -= quantidade;
//        return true;
//    }

//    Console.WriteLine($"Estoque insuficiente para o produto: {tyre.Brand}");
//    return false;
//}

//public int VerifyQuantity(Tyre tyre)
//{
//    if (tyresInStock.ContainsKey(tyre))
//    {
//        return tyresInStock[tyre];
//    }

//    return 0;
//}

//public void ShowTyres()
//{
//    foreach (var tyre in tyresInStock)
//    {
//        Console.WriteLine($"Produto: {tyre.Key.Brand} - Quantidade: {tyre.Value}");
//    }
//}
