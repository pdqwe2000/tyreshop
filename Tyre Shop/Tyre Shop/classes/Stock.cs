using System;
using System.Collections.Generic;
using Tyre_Shop.classes;

public class Stock
{
    private Dictionary<Tyre, int> tyresInStock;

    public Stock()
    {
        tyresInStock = new Dictionary<Tyre, int>();
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
        if (tyresInStock.ContainsKey(tyre))
        {
            return tyresInStock[tyre];
        }

        return 0;
    }

    public void ShowTyres()
    {
        foreach (var tyre in tyresInStock)
        {
            Console.WriteLine($"Produto: {tyre.Key.Brand} - Quantidade: {tyre.Value}");
        }
    }
}
