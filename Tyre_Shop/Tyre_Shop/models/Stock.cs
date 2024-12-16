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
        private TyreService repos = TyreService.Instance;
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
            var stockManager = TyreService.Instance;

            // Carregar os pneus do JSON
            await stockManager.LoadTyresFromJsonAsync();

            // Exemplo: Exibir os pneus carregados
            var tyres = stockManager.GetTyreStock();
            foreach (var tyre in tyres)
            {
                Console.WriteLine($"Marca: {tyre.Brand}, Modelo: {tyre.Model}, Quantidade: {tyre.Quantity}, Preço: {tyre.Price}");
            }
        }

        public void ShowTyres()
        {
            var stockManager = TyreService.Instance;
            var tyres = stockManager.GetTyreStock();

            Console.WriteLine("Pneus em Stock:");
            foreach (var tyre in tyres)
            {
                Console.WriteLine($"Tyre: {tyre.Brand} {tyre.Model}, Size: {tyre.Size}, Quality: {tyre.Quality}, Quantity: {tyre.Quantity}, Price: {tyre.Price}");
            }
        }
        #endregion
    }
}

