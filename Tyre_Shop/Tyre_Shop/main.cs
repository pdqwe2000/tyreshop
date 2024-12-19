using System;
using System.Windows.Forms;
using Tyre_Shop.Classes;
using Tyre_Shop.source.interfaces;
using Tyre_Shop.Classes.Controller;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Interfaces;
using System.Collections.Generic;
using Tyre_Shop.Classes.Facade;
using System.Linq;
using Tyre_Shop.src.Forms;


namespace Tyre_Shop
{
    // Main class that serves as the entry point for the Tyre Shop application.  
    public class Program
    {
        private static TyreController _tyreController;
        private static SaleController _saleController;
        

        // Main method where the application begins execution.  
        static async Task Main()
        {
            await InitializeProgram();
            // Initializes and starts the Windows Forms application.  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            _tyreController.ShowTyres();

            // Creating sample Clients
            Client client1 = new Client("Pedro", "1111",false);
            // Creating sample tyres for the stock.  
            TyreJson tyreA = new TyreJson(5, "Continental", "PremiumContact 5", "205/55R16", Quality.AA, 105, 20);
            TyreJson tyreB = new TyreJson(1, "Michelin", "X123", "205/55R16", Quality.AA, 110, 30);
           
            await _tyreController.AddOrUpdateTyreAsync(tyreA);
            await _tyreController.AddOrUpdateTyreAsync(tyreB);

            int quantity = 4;
            int tyreId = 13;

            await _saleController.VerifyExistenceTyre(tyreId, client1,quantity);

            _tyreController.ShowTyres();

            Console.ReadLine();
        }
        private static async Task InitializeProgram()
        {
            Console.WriteLine("Initializing program...");

            // Initialize Controllers
            _tyreController = new TyreController();
            _saleController = new SaleController();

            // Load tyre data
            await _tyreController.LoadTyresAsync();

            Console.WriteLine("Initialization complete.");
        }



    }

}
