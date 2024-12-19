using System;
using System.Collections;
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
            LoadTyresToListView(_facade.GetStock().OrderBy(t => t.Size).ToList());
            //tyreStock = stock.OrderBy(t => t.Size).ToList(); // Sort stock by Size
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            try
            {
                // Extract input values
                string clientName = txtClientName.Text.Trim();
                string clientNumber = txtClientNumber.Text.Trim();
                bool isCompany = chkIsCompany.Checked;
                var selectedTyre = lvTyres.SelectedItems.Count > 0 ? lvTyres.SelectedItems[0] : null;
                int quantity = (int)nudQuantity.Value;

                // Validation
                if (string.IsNullOrEmpty(clientName))
                    throw new ArgumentException("Client name cannot be empty.");

                if (string.IsNullOrEmpty(clientNumber))
                    throw new ArgumentException("Client contact number cannot be empty.");

                if (selectedTyre == null)
                    throw new InvalidOperationException("No tyre selected. Please select a tyre from the list.");

                if (quantity <= 0)
                    throw new ArgumentOutOfRangeException("Quantity must be greater than zero.");

                // Extract selected tyre data
                int tyreId = int.Parse(selectedTyre.SubItems[0].Text); // Assume the first column is the ID
                string brand = selectedTyre.SubItems[1].Text;
                string model = selectedTyre.SubItems[2].Text;

                // Perform the sale
                Client client = new Client(clientName, clientNumber, isCompany);

                // Assuming `_saleController.VerifyExistenceTyre` validates and processes the sale
                _saleController.VerifyExistenceTyre(tyreId, client, quantity);

                // Refresh the stock view
                LoadTyresToListView(_facade.GetStock().OrderBy(t => t.Size).ToList());

                // Show success message
                MessageBox.Show(
                    $"Sale completed:\nClient: {clientName} ({(isCompany ? "Company" : "Individual")})\nTyre: {brand} {model}\nQuantity: {quantity}",
                    "Sale Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                StockUpdated?.Invoke();
            }
            catch (InvalidOperationException ex)
            {
                // Handle invalid operations (e.g., no tyre selected)
                MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle invalid range inputs (e.g., invalid quantity)
                MessageBox.Show(ex.Message, "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                // Handle validation errors (e.g., empty fields)
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void LoadTyresToListView(List<TyreJson> tyres)
        {

            // Fetch tire data from the facade or service

            List<TyreJson> tyreList = _facade.GetStock()
                .OrderBy(t => GetWheelSize(t.Size)) // First by wheel size (e.g., "16")
                .ThenBy(t => GetWidth(t.Size))     // Then by width (e.g., "205")
                .ThenBy(t => GetHeight(t.Size))    // Finally by height (e.g., "55")
                .ToList();

            // Populate the ListView with tire data
            lvTyres.Items.Clear();
            foreach (var tyre in tyreList)
            {
                var item = new ListViewItem(tyre.Id.ToString());
                item.SubItems.Add(tyre.Brand);
                item.SubItems.Add(tyre.Model);
                item.SubItems.Add(tyre.Size);
                item.SubItems.Add(tyre.Price.ToString("C"));
                item.SubItems.Add(tyre.Quantity.ToString());
                lvTyres.Items.Add(item);
            }
        }
        /// <summary>
        /// Extracts the wheel size (last part) from the tire size string.
        /// Example: "205/55R16" -> 16
        /// </summary>
        private int GetWheelSize(string size)
        {
            var parts = size.Split('R');
            return parts.Length > 1 ? int.Parse(parts[1]) : 0;
        }

        /// <summary>
        /// Extracts the width (first part) from the tire size string.
        /// Example: "205/55R16" -> 205
        /// </summary>
        private int GetWidth(string size)
        {
            var parts = size.Split('/');
            return parts.Length > 0 ? int.Parse(parts[0]) : 0;
        }

        /// <summary>
        /// Extracts the height (middle part) from the tire size string.
        /// Example: "205/55R16" -> 55
        /// </summary>
        private int GetHeight(string size)
        {
            var parts = size.Split('/');
            return parts.Length > 1 ? int.Parse(parts[1].Split('R')[0]) : 0;
        }

    }
}
