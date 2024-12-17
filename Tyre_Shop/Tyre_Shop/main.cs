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
using Tyre_Shop.Classes.Services;

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
            ISale sale;
            TyreController tyreController = new TyreController();
            SaleController saleController = new SaleController();

            SaleFacade _saleFacade = new SaleFacade();
            //SaleController saleController = new SaleController(sale);
            TyreFacade _tyreFacade = new TyreFacade();
            await tyreController.LoadTyresAsync();

            tyreController.ShowTyres();
            Client client1 = new Client("Pedro", "1111",false);

            // Creating sample tyres for the stock.  
            TyreJson tyreA = new TyreJson(5, "Continental", "PremiumContact 5", "205/55R16", Quality.AA, 105, 20);
            TyreJson tyreB = new TyreJson(1, "Michelin", "X123", "205/55R16", Quality.AA, 110, 30);
           
            await tyreController.AddOrUpdateTyreAsync(tyreA);
            await tyreController.AddOrUpdateTyreAsync(tyreB);

            int quantity = 4;
            int tyreId = 13;

            // Obter pneu do stock
            var tyreToSell = _tyreFacade.GetStock().FirstOrDefault(t => t.Id == tyreId);

                

            // Criar uma lista com os itens vendidos
            var tyresToSell = new List<TyreJson>
            {
                new TyreJson
                {
                    Id = tyreToSell.Id,
                    Brand = tyreToSell.Brand,
                    Model = tyreToSell.Model,
                    Size = tyreToSell.Size,
                    Price = tyreToSell.Price,
                    Quantity = quantity
                }
            };

            // Realizar a venda usando a fachada
            await saleController.RegisterSale(client1, tyresToSell);
            MessageBox.Show("Venda realizada com sucesso!");

                //// Atualizar UI
                //LoadStockToListView();
            tyreController.ShowTyres();
            
            //RegisterSale(Client client, List < TyreJson > tyresToSell)

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
