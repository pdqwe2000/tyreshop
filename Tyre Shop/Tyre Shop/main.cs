using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Tyre_Shop.classes;
using Tyre_Shop.source.interfaces;
using Tyre_Shop.models;

namespace Tyre_Shop
{
    // Main class that serves as the entry point for the Tyre Shop application.  
    static class Program
    {
        // Main method where the application begins execution.  
        static void Main()
        {
            // Initializes and starts the Windows Forms application.  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            // The following commented-out section showcases a basic login flow for the application.  
            // It demonstrates the process of registering or logging in a user, though it is not currently active.  

            //LoginService loginService = new LoginService();  
            //Console.WriteLine("1 - Registrar novo usuário");  
            //Console.WriteLine("2 - Fazer login");  
            //Console.Write("Escolha uma opção: ");  
            //string opcao = Console.ReadLine();  

            //if (opcao == "1")  
            //{  
            //    Console.Write("Nome do usuário: ");  
            //    string nome = Console.ReadLine();  
            //    Console.Write("Senha: ");  
            //    string senha = Console.ReadLine();  

            //    // loginService.RegistrarUsuario(nome, senha);  
            //}  
            //else if (opcao == "2")  
            //{  
            //    Console.Write("Nome do usuário: ");  
            //    string nome = Console.ReadLine();  
            //    Console.Write("Senha: ");  
            //    string senha = Console.ReadLine();  

            //    loginService.Login(nome, senha);  
            //}  
            //Console.ReadLine();  

            // Initialize the shop and load stock from a JSON file.  
            Shop shop = new Shop();
            shop.LoadStockFromJson();

            // Example of creating a new tyre object.  
            Tyre tyre1 = new Tyre();
            tyre1.Brand = "PT";

            // Creating sample tyres for the stock.  
            Tyre tyreA = new Tyre(1, "Continental", "ContiSportContact2", "235/45/17", Quality.AA, 120);
            Tyre TyreB = new Tyre(2, "Michelin", "Primacy4", "235/45/17", Quality.AA, 120);

            // Adding tyres to the shop's stock.  
            shop.AddTyreToStock(tyreA, 11);
            shop.AddTyreToStock(TyreB, 12);

            // Displaying the current stock.  
            shop.ShowStock();

            // Creating a client.  
            Client cliente1 = new Client("João Silva", "99999-9999", false);

            // Performing a sale with a list of tyres and their quantities.  
            Dictionary<Tyre, int> produtosParaVenda = new Dictionary<Tyre, int>
            {
                { tyreA, 2 },
                { TyreB, 1 }
            };
            shop.MakeSell(cliente1, produtosParaVenda);

            // Displaying the list of completed sales.  
            shop.ShowSellings();

            // Displaying the stock after the sale.  
            shop.ShowStock();

            Console.ReadLine();

            // Path to the JSON file containing tyre data.  
            string caminhoArquivo = @"C:\\Users\Pedro Duarte\Documents\GitHub\tyreshop\Tyre Shop\Tyre Shop\assets\Data.json";

            // Checking if the JSON file exists and reading its content.  
            if (File.Exists(caminhoArquivo))
            {
                string conteudoJson = File.ReadAllText(caminhoArquivo);

                // Deserializing a single tyre object from the JSON file.  
                Tyre tyre = JsonConvert.DeserializeObject<Tyre>(conteudoJson);
                Console.WriteLine($"Brand: {tyre.Brand}, Model: {tyre.Model}, Size: {tyre.Size}, Quality: {tyre.Quality}, Price: {tyre.Price}");

                // Deserializing a list of tyres from the JSON file if it contains an array.  
                List<Tyre> listTyres = JsonConvert.DeserializeObject<List<Tyre>>(conteudoJson);
                foreach (var t in listTyres)
                {
                    Console.WriteLine($"Brand: {t.Brand}, Model: {t.Model}, Size: {t.Size}, Quality: {t.Quality}, Price: {t.Price}");
                }
            }
            else
            {
                // Displaying a message if the JSON file is not found.  
                Console.WriteLine("Arquivo JSON não encontrado.");
            }

            // Waiting for the user to close the console.  
            Console.ReadLine();
        }
    }
}
