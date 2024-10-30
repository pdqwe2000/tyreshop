using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Tyre_Shop.classes;
using System.Runtime.Serialization.Formatters.Binary;


class Program
{
    static void Main(string[] args)
    {
        LoginService loginService = new LoginService();

        Console.WriteLine("1 - Registrar novo usuário");
        Console.WriteLine("2 - Fazer login");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Console.Write("Nome do usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

           // loginService.RegistrarUsuario(nome, senha);
        }
        else if (opcao == "2")
        {
            Console.Write("Nome do usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            loginService.Login(nome, senha);
        }
        Console.ReadLine();



        //Shop shop = new Shop();

        //// Criando alguns produtos
        //Tyre tyreA = new Tyre(1, "Continental","ContiSportContact2","235/45/17",90,120);
        //Tyre TyreB = new Tyre(2, "Michelin", "Primacy4", "235/45/17", 95, 120);

        //// Adicionando produtos ao estoque
        //shop.AddTyreToStock(tyreA, 11);
        //shop.AddTyreToStock(TyreB, 12);

        //// Listando estoque
        //shop.ShowStock();

        //// Criando cliente
        //Client cliente1 = new Client("João Silva", "99999-9999");

        //// Realizando uma venda
        //Dictionary<Tyre, int> produtosParaVenda = new Dictionary<Tyre, int>
        //{
        //    { tyreA, 2 },
        //    { TyreB, 1 }
        //};

        //shop.MakeSell(cliente1, produtosParaVenda);

        //// Listando vendas realizadas
        //shop.ShowSellings();

        //// Listando estoque após venda
        //shop.ShowStock();


        //// Caminho do arquivo JSON
        //string caminhoArquivo = @"C:\\Users\Pedro Duarte\Documents\GitHub\tyreshop\Tyre Shop\Tyre Shop\assets\Data.json";

        //// Verifica se o arquivo existe e realiza a leitura
        //if (File.Exists(caminhoArquivo))
        //{
        //    string conteudoJson = File.ReadAllText(caminhoArquivo);

        //    // Para um único objeto
        //    Tyre tyre= JsonConvert.DeserializeObject<Tyre>(conteudoJson);
        //    Console.WriteLine($"Brand: {tyre.Brand}, Model: {tyre.Model}, Size: {tyre.Size}, Quality: {tyre.Quality}, Price: {tyre.Price}");

        //    // Para uma lista de objetos, caso o JSON contenha um array
        //    List<Tyre> listTyres = JsonConvert.DeserializeObject<List<Tyre>>(conteudoJson);
        //    foreach (var t in listTyres)
        //    {
        //        Console.WriteLine($"Brand: {t.Brand}, Model: {t.Model}, Size: {t.Size}, Quality: {t.Quality}, Price: {t.Price}");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Arquivo JSON não encontrado.");
        //}
        //Console.ReadLine();


    }
        
}
