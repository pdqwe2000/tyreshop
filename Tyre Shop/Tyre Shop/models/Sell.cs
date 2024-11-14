using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.classes
{
    internal class Sell
    {
        public int Id { get; private set; }
        public Client Client { get; private set; }
        public DateTime SellDate { get; private set; }
        public List<Tyre> TyreSold { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Sell(int id, Client cliente)
        {
            Id = id;
            Client = cliente;
            SellDate = DateTime.Now;
            TyreSold = new List<Tyre>();
            TotalPrice = 0;
        }

        public void AddTyre(Tyre tyre)
        {
            TyreSold.Add(tyre);
            TotalPrice += tyre.Price;
        }

        public override string ToString()
        {
            return $"Venda #{Id} - Cliente: {Client.Name} - Data: {SellDate} - Valor Total: {TotalPrice:C}";
        }
    }
}
