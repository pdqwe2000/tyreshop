using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Data;

namespace Tyre_Shop.Classes
{
    public class Stock
    {
        #region Properties

        private TyreService repos = new TyreService();
        private TyreJson tyresInStock;

        // Root path of the application, determined dynamically based on the location of the executing assembly.  
        private static string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;

        // Path to the JSON file where user data is stored.  
        private static string path = Path.Combine(rootPath, "assets", "Data.json");

        #endregion

        #region Constructors

        public Stock()
        {
            tyresInStock = new TyreJson();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load the stock from the JSON file.
        /// </summary>
        public async Task LoadStockFromJson()
        {
            // Obter a instância do TyreStockManager
            var stockManager = Tsms.Instance;

            // Carregar os pneus do JSON
            await stockManager.LoadTyresFromJsonAsync();

            // Exemplo: Exibir os pneus carregados
            var tyres = stockManager.GetTyreStock();
            foreach (var tyre in tyres)
            {
                Console.WriteLine($"Marca: {tyre.Brand}, Modelo: {tyre.Model}, Quantidade: {tyre.Quantity}, Preço: {tyre.Price}");
            }

            //if (!File.Exists(path))
            //{
            //    Console.WriteLine("JSON Not Found.");
            //    return;
            //}

            //try
            //{
            //    // Load the tyres from the repository or JSON
            //    var tyreList = await repos.LoadTyresAsync();

            //    tyreList.Add()

            //    foreach (var tyreJson in tyreList)
            //    {
            //        // Convert TyreJson to Tyre and add to the stock
            //        var tyre = new Tyre
            //        {
            //            Id = tyreJson.Id,
            //            Brand = tyreJson.Brand,
            //            Model = tyreJson.Model,
            //            Size = tyreJson.Size,
            //            Quality = tyreJson.Quality,
            //            Price = tyreJson.Price
            //        };

            //        AddTyre(tyre, tyreJson.Quantity);
            //    }

            //    Console.WriteLine("Stock Loaded From JSON.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error Loading JSON File: " + ex.Message);
            //}
        }

        /// <summary>
        /// Add a tyre to the stock and update the JSON file.
        /// </summary>
        /// <summary>
        /// Add a tyre to the stock and update the JSON file.
        /// If a tyre with the same properties exists, only update the quantity.
        /// </summary>
        //public void AddTyre(Tyre tyre, int quantity)
        //{
        //    // Check if an equivalent tyre already exists in stock
        //    var existingTyre = tyresInStock.Keys.FirstOrDefault(t =>
        //        t.Brand == tyre.Brand &&
        //        t.Model == tyre.Model &&
        //        t.Size == tyre.Size &&
        //        t.Quality == tyre.Quality &&
        //        t.Price == tyre.Price);

        //    if (existingTyre != null)
        //    {
        //        // Update quantity of the existing tyre
        //        tyresInStock[existingTyre] += quantity;
        //    }
        //    else
        //    {
        //        // Add new tyre to the stock
        //        tyresInStock[tyre] = quantity;
        //    }

        //    // Save the updated stock to JSON
        //    SaveStockToJson();
        //}

        /// <summary>
        /// Remove a tyre from the stock and update the JSON file.
        /// </summary>
        //public bool RemoveTyre(Tyre tyre, int quantity)
        //{
        //    if (tyresInStock.ContainsKey(tyre) && tyresInStock[tyre] >= quantity)
        //    {
        //        tyresInStock[tyre] -= quantity;

        //        SaveStockToJson(); // Save the updated stock to JSON
        //        return true;
        //    }

        //    Console.WriteLine($"Insufficient Stock: {tyre.Brand}");
        //    return false;
        //}

        /// <summary>
        /// Check the quantity of a tyre in stock.
        /// </summary>
        //public int VerifyQuantity(Tyre tyre)
        //{
        //    return tyresInStock.ContainsKey(tyre) ? tyresInStock[tyre] : 0;
        //}

        /// <summary>
        /// Display the current tyres in stock.
        /// </summary>
        //public void ShowTyres()
        //{
        //    foreach (var tyre in tyresInStock)
        //    {
        //        Console.WriteLine($"Tyre: {tyre.Key.Brand} {tyre.Key.Model} Size: {tyre.Key.Size} Quality: {tyre.Key.Quality} - Quantity: {tyre.Value} Price: {tyre.Key.Price}");
        //    }
        //}

        public void ShowTyres()
        {
            var stockManager = Tsms.Instance;
            var tyres = stockManager.GetTyreStock();

            Console.WriteLine("Pneus em Stock:");
            foreach (var tyre in tyres)
            {
                Console.WriteLine($"Tyre: {tyre.Brand} {tyre.Model}, Size: {tyre.Size}, Quality: {tyre.Quality}, Quantity: {tyre.Quantity}, Price: {tyre.Price}");
            }
        }

        /// <summary>
        /// Save the current stock to the JSON file.
        /// </summary>
        //private void SaveStockToJson()
        //{
        //    try
        //    {
        //        // Convert the stock dictionary to a list of TyreJson
        //        var stockList = tyresInStock.Select(item => new TyreJson
        //        {
        //            Id = item.Key.Id,
        //            Brand = item.Key.Brand,
        //            Model = item.Key.Model,
        //            Size = item.Key.Size,
        //            Quality = item.Key.Quality,
        //            Price = item.Key.Price,
        //            Quantity = item.Value
        //        }).ToList();

        //        // Serialize the list to JSON
        //        string json = JsonConvert.SerializeObject(stockList, Formatting.Indented);

        //        // Save the JSON to the file
        //        File.WriteAllText(path, json);

        //        Console.WriteLine("Stock saved to JSON.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error saving stock to JSON: " + ex.Message);
        //    }
        //}

        #endregion
    }
}


//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Reflection;
//using Newtonsoft.Json;

//namespace Tyre_Shop.classes
//{
//    public class Stock
//    {
//        #region Properties
//        private TyreRepo repos = new TyreRepo();

//        private Dictionary<Tyre, int> tyresInStock;
//        // Root path of the application, determined dynamically based on the location of the executing assembly.  
//        private static string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;
//        // Path to the JSON file where user data is stored.  
//        private static string path = Path.Combine(rootPath, "assets", "Data.json");
//        #endregion

//        #region Constructors
//        public Stock()
//        {
//            tyresInStock = new Dictionary<Tyre, int>();
//        }
//        #endregion

//        #region Methods

//        public void LoadStockFromJson()
//        {
//            if (!File.Exists(path))
//            {
//                Console.WriteLine("JSON Not Found.");
//                return;
//            }

//            try
//            {

//                //// Lê o conteúdo do arquivo JSON
//                //string json = File.ReadAllText(path);

//                //// Desserializa o JSON para uma lista temporária de pneus com quantidade
//                //var tyreList = JsonConvert.DeserializeObject<List<TyreJson>>(json);

//                var tyreList = repos.LoadTyres();

//                foreach (var tyreJson in tyreList)
//                {
//                    // Converte TyreJson para Tyre e adiciona ao estoque
//                    var tyre = new Tyre
//                    {
//                        Id = tyreJson.Id,
//                        Brand = tyreJson.Brand,
//                        Model = tyreJson.Model,
//                        Size = tyreJson.Size,
//                        Quality = tyreJson.Quality,
//                        Price = tyreJson.Price,
//                    };

//                    AddTyre(tyre, tyreJson.Quantity);
//                }

//                Console.WriteLine("Stock Loaded From JSON.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error Loading JSON File: " + ex.Message);
//            }
//        }

//        public void AddTyre(Tyre tyre, int quantity)
//        {
//            if (tyresInStock.ContainsKey(tyre))
//            {
//                tyresInStock[tyre] += quantity;
//            }
//            else
//            {
//                tyresInStock[tyre] = quantity;
//            }
//        }

//        public bool RemoveTyre(Tyre tyre, int quantity)
//        {
//            if (tyresInStock.ContainsKey(tyre) && tyresInStock[tyre] >= quantity)
//            {
//                tyresInStock[tyre] -= quantity;
//                return true;
//            }

//            Console.WriteLine($"Insuficient Stock: {tyre.Brand}");
//            return false;
//        }

//        public int VerifyQuantity(Tyre tyre)
//        {
//            return tyresInStock.ContainsKey(tyre) ? tyresInStock[tyre] : 0;
//        }

//        public void ShowTyres()
//        {
//            foreach (var tyre in tyresInStock)
//            {
//                Console.WriteLine($"Tyre: {tyre.Key.Brand} {tyre.Key.Model} Size: {tyre.Key.Size} Quality: {tyre.Key.Quality} - Quantity: {tyre.Value} Price: {tyre.Key.Price} ");
//            }
//        }
//        #endregion
//    }
//}

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
