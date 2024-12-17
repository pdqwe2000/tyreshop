using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyre_Shop.Classes.Controller;
using Tyre_Shop.Classes.Services;


namespace Tyre_Shop.Classes.Facade
{
    public class SaleFacade
    {
        private readonly SaleServices _service; 
        private readonly SaleController _saleController;

    public SaleFacade()
    {
        _service = SaleServices.Instance;
    }

    public void PerformSale(Client client, List<TyreJson> tyresToSell)
    {
        _saleController.RegisterSale(client, tyresToSell);
    }

    }
}
