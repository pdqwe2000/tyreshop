using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Tyre_Shop.classes;

public class Stock
{
    private Dictionary<Tyre, int> tyresInStock;
    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\Users\Pedro Duarte\Documents\GitHub\tyreshop\Tyre Shop\Tyre Shop\assets\Data.json");
    public Stock()
    {
        tyresInStock = new Dictionary<Tyre, int>();
    }

    public void LoadStockFromJson()
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Arquivo de estoque JSON não encontrado.");
            return;
        }

        try
        {
            // Lê o conteúdo do arquivo JSON
            string json = File.ReadAllText(path);

            // Desserializa o JSON para uma lista temporária de pneus com quantidade
            var tyreList = JsonConvert.DeserializeObject<List<TyreJson>>(json);

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
                    Price = tyreJson.Price
                };

                AddTyre(tyre, tyreJson.Quantity);
            }

            Console.WriteLine("Estoque carregado do arquivo JSON.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao carregar o estoque do arquivo JSON: " + ex.Message);
        }
    }

    public void AddTyre(Tyre tyre, int quantidade)
    {
        if (tyresInStock.ContainsKey(tyre))
        {
            tyresInStock[tyre] += quantidade;
        }
        else
        {
            tyresInStock[tyre] = quantidade;
        }
    }

    public bool RemoveTyre(Tyre tyre, int quantidade)
    {
        if (tyresInStock.ContainsKey(tyre) && tyresInStock[tyre] >= quantidade)
        {
            tyresInStock[tyre] -= quantidade;
            return true;
        }

        Console.WriteLine($"Estoque insuficiente para o produto: {tyre.Brand}");
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
            Console.WriteLine($"Produto: {tyre.Key.Brand} - Quantidade: {tyre.Value}");
        }
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
