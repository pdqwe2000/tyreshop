using System;
using System.Windows.Forms;
using Tyre_Shop.Classes;
using Tyre_Shop.source.interfaces;
using Tyre_Shop.Classes.Controller;
using System.Threading.Tasks;

namespace Tyre_Shop
{
    // Main class that serves as the entry point for the Tyre Shop application.  
    static class Program
    {
        // Main method where the application begins execution.  
        static async Task Main()
        {
            // Initializes and starts the Windows Forms application.  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            // Initialize load stock from a JSON file.  
            TyreController tyreController = new TyreController();
            await tyreController.LoadTyresAsync();

            tyreController.ShowTyres();

            // Creating sample tyres for the stock.  
            TyreJson tyreA = new TyreJson(5, "Continental", "PremiumContact 5", "205/55R16", Quality.AA, 105, 20);
            TyreJson tyreB = new TyreJson(1, "Michelin", "X123", "205/55R16", Quality.AA, 110, 30);
           
            await tyreController.AddOrUpdateTyreAsync(tyreA);
            await tyreController.AddOrUpdateTyreAsync(tyreB);

            Console.ReadLine();


            //    // Creating a client.  
            //    Client cliente1 = new Client("João Silva", "99999-9999", false);

            //    // Performing a sale with a list of tyres and their quantities.  
            //    Dictionary<Tyre, int> produtosParaVenda = new Dictionary<Tyre, int>
            //    {
            //        { tyreA, 2 },
            //        { tyreB, 1 }
            //    };
            //    shop.MakeSell(cliente1, produtosParaVenda);

            //    // Displaying the list of completed sales.  
            //    shop.ShowSellings();

            //    shop.MakeSell(cliente1, produtosParaVenda1);
            //    // Displaying the list of completed sales.  
            //    shop.ShowSellings();           
        }
    }
}
