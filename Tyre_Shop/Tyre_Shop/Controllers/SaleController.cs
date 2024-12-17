using System;
using System.Collections.Generic;
using System.Linq;
using Tyre_Shop.Classes.Interfaces;
using Tyre_Shop.Classes.Facade;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.Classes.Controller
{
    internal class SaleController
    {
        private readonly SaleServices _saleService;
        private readonly SaleFacade _saleFacade;
        private readonly TyreFacade _facade;
        private readonly TyreService _serviceTyre;

        public SaleController()
        {
            _saleFacade= new SaleFacade();
            _facade = new TyreFacade(); // Serviço do stock
            _serviceTyre = TyreService.Instance;
            _saleService=SaleServices.Instance;
        }

        public async Task RegisterSale(Client client, List<TyreJson> tyresToSell)
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
                TotalPrice = _saleFacade.CalculateTotal(tyresToSell)
            };

            _saleFacade.AddSale(sale);

            Console.WriteLine($"Sale completed. Total: {sale.TotalPrice:C}");
            await _facade.SaveToJson(); // Salvar o stock atualizado
        }
    }
}
