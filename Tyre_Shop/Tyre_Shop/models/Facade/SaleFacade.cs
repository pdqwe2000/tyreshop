using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Controller;
using Tyre_Shop.Classes.Interfaces;
using Tyre_Shop.Classes.Services;


namespace Tyre_Shop.Classes.Facade
{
    public class SaleFacade
    {
        private readonly SaleServices _service;

        public SaleFacade()
        {
            _service = SaleServices.Instance;
        }

        public async Task PerformSale(Client client, List<TyreJson> tyresToSell)
        {

            
        }
        public decimal CalculateTotal(List<TyreJson> items)
        {
            return _service.CalculateTotal(items);
        }

        public void AddSale(Sale sale)
        {
            _service.AddSale(sale);
        }
    }
}
