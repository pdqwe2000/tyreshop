using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.src.Forms
{
    public partial class Sales : Form
    {
        public Sales()
        {
            _facade = new TyreFacade(); // Serviço do stock
            InitializeComponent();
            LoadTyresToListView(_facade.GetStock());
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            string clientName = txtClientName.Text;
            string clientNumber = txtClientNumber.Text;
            bool isCompany = chkIsCompany.Checked;
            var selectedTyre = lvTyres.SelectedItems.Count > 0 ? lvTyres.SelectedItems[0] : null;
            int quantity = (int)nudQuantity.Value;

            // Validation
            if (string.IsNullOrWhiteSpace(clientName))
            {
                MessageBox.Show("Please enter the client's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(clientNumber))
            {
                MessageBox.Show("Please enter the client's contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedTyre == null)
            {
                MessageBox.Show("Please select a tyre from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please specify a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Extract selected tyre data
            int tyreId = int.Parse(selectedTyre.SubItems[0].Text); // Assume the first column is the ID
            string brand = selectedTyre.SubItems[1].Text;
            string model = selectedTyre.SubItems[2].Text;

            TyreJson tyreA = new TyreJson(5, "Continental", "PremiumContact 5", "205/55R16", Quality.AA, 105, 20);
            Client client = new Client(clientName, clientNumber, isCompany);
            _saleController.VerifyExistenceTyre(tyreId,client, quantity);

            // TODO: Connect this to the backend logic to perform the sale
            MessageBox.Show($"Sale completed:\nClient: {clientName} ({(isCompany ? "Company" : "Individual")})\nTyre: {brand} {model}\nQuantity: {quantity}",
                "Sale Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void LoadTyresToListView(List<TyreJson> tyres)
        {
            lvTyres.Items.Clear(); // Clear existing items

            foreach (var tyre in tyres)
            {
                var item = new ListViewItem(tyre.Id.ToString());
                item.SubItems.Add(tyre.Brand);
                item.SubItems.Add(tyre.Model);
                item.SubItems.Add(tyre.Size);
                item.SubItems.Add(tyre.Price.ToString("C")); // Format price as currency
                item.SubItems.Add(tyre.Quantity.ToString());
                lvTyres.Items.Add(item);
            }
        }

    }
}
