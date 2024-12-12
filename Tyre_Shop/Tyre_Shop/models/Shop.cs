using System;
using System.Collections.Generic;
using Tyre_Shop.models.Data;

namespace Tyre_Shop.classes
{
    internal class Shop
    {
        #region Properties

        private Stock stock;
        private List<Sell> sellings;
        private int nextIdSell = 1;
        #endregion

        #region Constructors
        public Shop()
        {
            stock = new Stock();
            sellings = new List<Sell>();
        }
        #endregion

        #region Methods
        public async void LoadStockFromJson() => await stock.LoadStockFromJson();

        //public void AddTyreToStock(Tyre tyre, int quantity)
        //{
        //    stock.AddTyre(tyre,quantity);
        //    Console.WriteLine($"Product {tyre.Brand} Added To Stock. Quantity: {quantity}");
        //}

        //public void MakeSell(Client client, Dictionary<Tyre, int> productsToSell)
        //{
        //    Sell newSell = new Sell(nextIdSell, client);
        //    bool sellMade = true;

        //    foreach (var item in productsToSell)
        //    {
        //        Tyre tyre = item.Key;
        //        int quantity = item.Value;

        //        if (stock.RemoveTyre(tyre,quantity))
        //        {
        //            for (int i = 0; i < quantity; i++)
        //            {
        //                newSell.AddTyre(tyre);
        //            }
        //        }
        //        else
        //        {
        //            sellMade = false;
        //            break;
        //        }
        //    }

        //    if (sellMade)
        //    {
        //        sellings.Add(newSell);
        //        nextIdSell++;
        //        Console.WriteLine($"Sold! {newSell}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Impossible To Finish Sell, Out Of Stock.");
        //    }
        //}
        public async void AddNewTyre(TyreJson newTyre)
        {
            var stockManager = Tsms.Instance;
            await stockManager.AddOrUpdateTyreAsync(newTyre);
            //stockManager.TyreStock.Add(newTyre);

            Console.WriteLine("Novo pneu adicionado ao stock.");
        }

        public void ShowStock()
        {
            Console.WriteLine("Stock:");
            stock.ShowTyres();
        }

        public void ShowSellings()
        {
            Console.WriteLine("Sellings Made:");
            foreach (var sell in sellings)
            {
                Console.WriteLine(sell);
            }
        }
        #endregion
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tyre_Shop.classes
//{
//    internal class Shop
//    {
//        private Stock stock;
//        private List<Sell> sellings;
//        private int nextIdSell = 1;

//        public Shop()
//        {
//            stock = new Stock();
//            sellings = new List<Sell>();
//        }

//        public void AddTyreToStock(Tyre tyre, int quantidade)
//        {
//            stock.AddTyre(tyre, quantidade);
//            Console.WriteLine($"Produto {tyre.Brand} adicionado ao estoque. Quantidade: {quantidade}");
//        }


//        public void MakeSell(Client client, Dictionary<Tyre, int> produtosParaVenda)
//        {
//            Sell novaVenda = new Sell(nextIdSell, client);
//            bool sellMade = true;

//            foreach (var item in produtosParaVenda)
//            {
//                Tyre tyre = item.Key;
//                int quantidade = item.Value;

//                if (stock.RemoveTyre(tyre, quantidade))
//                {
//                    for (int i = 0; i < quantidade; i++)
//                    {
//                        novaVenda.AddTyre(tyre);
//                    }
//                }
//                else
//                {
//                    sellMade = false;
//                    break;
//                }
//            }

//            if (sellMade)
//            {
//                sellings.Add(novaVenda);
//                nextIdSell++;
//                Console.WriteLine($"Venda realizada com sucesso! {novaVenda}");
//            }
//            else
//            {
//                Console.WriteLine("Venda não realizada devido à falta de estoque.");
//            }
//        }

//        public void ShowStock()
//        {
//            Console.WriteLine("Estoque atual:");
//            stock.ShowTyres();
//        }

//        public void ShowSellings()
//        {
//            Console.WriteLine("Vendas realizadas:");
//            foreach (var sell in sellings)
//            {
//                Console.WriteLine(sell);
//            }
//        }
//    }
//}
