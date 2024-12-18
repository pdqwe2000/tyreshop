using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Controller;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.src.Forms
{
    public partial class ShowStock : Form
    {
        private readonly TyreFacade _facade;
        
        public ShowStock()
        {
            _facade = new TyreFacade(); // Serviço do stock
            InitializeComponent();
            LoadStockToGrid(_facade.GetStock());
        }
        
        public void LoadStockToGrid(List<TyreJson> stock)
        {
            dgvStock.DataSource = stock;
        }
    }
}
