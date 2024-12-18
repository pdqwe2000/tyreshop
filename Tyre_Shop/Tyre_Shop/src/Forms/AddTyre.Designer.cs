using System;
using System.Windows.Forms;
using Tyre_Shop.Classes;
using Tyre_Shop.Classes.Controller;

namespace Tyre_Shop.src.Forms
{
    partial class AddTyre
    {
        private static TyreController _tyreController;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtSize;
        private ComboBox cmbQuality;
        private NumericUpDown nudPrice;
        private NumericUpDown nudQuantity;
        private Button btnAdd;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // TextBox for Brand
            this.txtBrand = new TextBox();
            this.txtBrand.Location = new System.Drawing.Point(20, 20);
            this.txtBrand.Size = new System.Drawing.Size(300, 20);
           // this.txtBrand.PlaceholderText = "Brand";

            // TextBox for Model
            this.txtModel = new TextBox();
            this.txtModel.Location = new System.Drawing.Point(20, 60);
            this.txtModel.Size = new System.Drawing.Size(300, 20);
           // this.txtModel.PlaceholderText = "Model";

            // TextBox for Size
            this.txtSize = new TextBox();
            this.txtSize.Location = new System.Drawing.Point(20, 100);
            this.txtSize.Size = new System.Drawing.Size(300, 20);
            //this.txtSize.PlaceholderText = "Size (e.g., 225/45R17)";

            // ComboBox for Quality
            this.cmbQuality = new ComboBox();
            this.cmbQuality.Location = new System.Drawing.Point(20, 140);
            this.cmbQuality.Size = new System.Drawing.Size(300, 20);
            this.cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var quality in Enum.GetValues(typeof(Quality)))
            {
                this.cmbQuality.Items.Add(quality);
            }
            this.cmbQuality.SelectedIndex = 0; // Default selection

            // NumericUpDown for Price
            this.nudPrice = new NumericUpDown();
            this.nudPrice.Location = new System.Drawing.Point(20, 180);
            this.nudPrice.Size = new System.Drawing.Size(300, 20);
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Minimum = 0;
            this.nudPrice.Maximum = 10000;
            this.nudPrice.Increment = 0.50M;

            // NumericUpDown for Quantity
            this.nudQuantity = new NumericUpDown();
            this.nudQuantity.Location = new System.Drawing.Point(20, 220);
            this.nudQuantity.Size = new System.Drawing.Size(300, 20);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 1000;

            // Add Button
            this.btnAdd = new Button();
            this.btnAdd.Location = new System.Drawing.Point(20, 260);
            this.btnAdd.Size = new System.Drawing.Size(300, 40);
            this.btnAdd.Text = "Add Tyre";
            this.btnAdd.Click += BtnAdd_Click;

            // Add controls to the form
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbQuality);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAdd);

            // Configure the form
            this.Text = "Add Tyre";
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion
    }
}