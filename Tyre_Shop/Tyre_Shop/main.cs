using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Tyre_Shop.classes;
using Tyre_Shop.source.interfaces;
using Tyre_Shop.models;
using System.Reflection;

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
            
            // Displaying the current stock.  
            shop.ShowStock();

            // Creating sample tyres for the stock.  
            TyreJson tyreA = new TyreJson(5, "Continental", "PremiumContact 5", "205/55R16", Quality.AA, 105, 20);
            TyreJson tyreB = new TyreJson(1, "Michelin", "X123", "205/55R16", Quality.AA, 110, 30);
           
            shop.AddNewTyre(tyreA);
            shop.AddNewTyre(tyreB);



            //// Adding tyres to the shop's stock.  
            //shop.AddTyreToStock(tyreA, 11);
            //shop.AddTyreToStock(tyreB, 12);

            // Displaying the current stock.  
            shop.ShowStock();

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

            //    // Displaying the stock after the sale.  
            //    shop.ShowStock();

            //    Tyre Tyrec = new Tyre(1, "Michelin", "X123", "205/55R16", Quality.AA, 110);
            //    Dictionary<Tyre, int> produtosParaVenda1 = new Dictionary<Tyre, int>
            //    {
            //        { Tyrec, 4 }
            //    };
            //    shop.MakeSell(cliente1, produtosParaVenda1);
            //    // Displaying the list of completed sales.  
            //    shop.ShowSellings();

            //    shop.ShowStock();

            //    // Root path of the application, determined dynamically based on the location of the executing assembly.  
            //    string rootPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName).FullName).FullName;
            //    // Path to the JSON file where user data is stored.  
            //    string filePath = Path.Combine(rootPath, "assets", "Data.json");
            //    // Checking if the JSON file exists and reading its content.  
            //    if (File.Exists(filePath))
            //    {
            //        string contentJson = File.ReadAllText(filePath);

            //        // Deserializing a list of tyres from the JSON file if it contains an array.  
            //        List<Tyre> listTyres = JsonConvert.DeserializeObject<List<Tyre>>(contentJson);
            //        foreach (var t in listTyres)
            //        {
            //            Console.WriteLine($"Brand: {t.Brand}, Model: {t.Model}, Size: {t.Size}, Quality: {t.Quality}, Price: {t.Price}");
            //        }
            //    }
            //    else
            //    {
            //        // Displaying a message if the JSON file is not found.  
            //        Console.WriteLine("JSON Not Found.");
            //    }

            //    // Waiting for the user to close the console.  
            //    Console.ReadLine();
        }
    }
}
