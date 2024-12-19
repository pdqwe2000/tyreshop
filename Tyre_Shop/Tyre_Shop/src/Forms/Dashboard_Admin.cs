using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Facade;
using Tyre_Shop.src.Forms;

namespace Tyre_Shop.source.interfaces
{
    public partial class Dashboard_Admin : Form
    {
        
        public Dashboard_Admin()
        {
            _facade = new TyreFacade(); // Serviço do stock
            InitializeComponent();
            
        }

        private void newSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales saleForm = new Sales();

            // Subscribe to the StockUpdated event
            saleForm.StockUpdated += RefreshStock;

            saleForm.Show();
        }

        private void addTyreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTyre addTyre = new AddTyre();

            // Subscribe to the StockUpdated event
            addTyre.StockUpdated += RefreshStock;

            addTyre.Show();
        }
        public void LoadStockToGrid(List<TyreJson> stock)
        {
            dgvStock.DataSource = null; // Reset the data source to avoid UI issues
            dgvStock.DataSource = stock;
        }
        private void RefreshStock()
        {
            // Reload the stock and update the grid
            var updatedStock = _facade.GetStock();
            LoadStockToGrid(updatedStock);
        }
    }
}
