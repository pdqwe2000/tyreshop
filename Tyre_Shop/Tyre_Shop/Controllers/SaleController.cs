using System;
using System.Collections.Generic;
using System.Linq;
using Tyre_Shop.Classes.Interfaces;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.Classes.Controller
{
    internal class SaleController
    {
        private readonly ISale _saleService;
        private readonly TyreFacade _facade;

        public SaleController(ISale saleService)
        {
            _saleService = saleService;
            _facade = new TyreFacade(); // Serviço do stock
        }

        public async void RegisterSale(Client client, List<TyreJson> tyresToSell)
        {
            // Atualizar stock
            foreach (var tyre in tyresToSell)
            {
                var existingTyre = _facade.GetStock()
                    .FirstOrDefault(t => t.Id == tyre.Id);

                if (existingTyre != null && existingTyre.Quantity >= tyre.Quantity)
                {
                    existingTyre.Quantity -= tyre.Quantity;
                }
                else
                {
                    Console.WriteLine($"Stock insuficiente para {tyre.Brand} {tyre.Model}");
                    return;
                }
            }

            // Registrar venda
            var sale = new Sale
            {
                Date = DateTime.Now,
                Client = client,
                TyreSold = tyresToSell,
                TotalPrice = _saleService.CalculateTotal(tyresToSell)
            };

            _saleService.AddSale(sale);

            Console.WriteLine($"Sale completed. Total: {sale.TotalPrice:C}");
            await _facade.SaveToJson(); // Salvar o stock atualizado
        }
    }
}
