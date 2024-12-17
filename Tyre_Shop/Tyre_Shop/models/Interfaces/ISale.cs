using System.Collections.Generic;

namespace Tyre_Shop.Classes.Interfaces
{
    internal interface ISale
    {
        void AddSale(Sale sale);
        List<Sale> GetAllSales();
        Sale GetSaleById(int id);
        decimal CalculateTotal(List<TyreJson> items);
    }
}
