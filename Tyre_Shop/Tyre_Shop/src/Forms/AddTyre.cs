//-----------------------------------------------------------------​
//    <copyright file="AddTyre.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

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
using Tyre_Shop.Classes.Controller;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.src.Forms
{
    public partial class AddTyre : Form
    {
        public AddTyre()
        {
            _tyreController = new TyreController(); // Serviço do stock
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Retrieve input data
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string size = txtSize.Text;
            Quality quality = (Quality)cmbQuality.SelectedItem;
            decimal price = nudPrice.Value;
            int quantity = (int)nudQuantity.Value;

            // Validation
            if (string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show("Please enter the brand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Please enter the model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("Please enter the size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TyreJson tyreA = new TyreJson(5, brand, model, size, quality, price, quantity);
            _tyreController.AddOrUpdateTyreAsync(tyreA);
            // TODO: Add backend logic to save the tyre
            MessageBox.Show($"Tyre Added:\nBrand: {brand}\nModel: {model}\nSize: {size}\nQuality: {quality}\nPrice: {price:C}\nQuantity: {quantity}",
                "Tyre Added",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            StockUpdated?.Invoke();

            // Clear form for new entry
            txtBrand.Clear();
            txtModel.Clear();
            txtSize.Clear();
            cmbQuality.SelectedIndex = 0;
            nudPrice.Value = 0;
            nudQuantity.Value = 1;
        }
    }
}
