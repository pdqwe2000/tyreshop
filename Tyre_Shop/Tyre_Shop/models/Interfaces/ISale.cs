//-----------------------------------------------------------------​
//    <copyright file="ISale.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

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
