using System;
using System.Windows.Forms;
using Tyre_Shop.Classes.Controller;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.src.Forms
{
    partial class Sales
    {
        private static SaleController _saleController;
        private readonly TyreFacade _facade;
        private TextBox txtClientName;
        private TextBox txtClientNumber;
        private CheckBox chkIsCompany;
        private ListView lvTyres;
        private NumericUpDown nudQuantity;
        private Button btnSell;
        public event Action StockUpdated;

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
            _saleController = new SaleController();
            // TextBox for Client Name
            this.txtClientName = new TextBox();
            this.txtClientName.Location = new System.Drawing.Point(20, 20);
            this.txtClientName.Size = new System.Drawing.Size(300, 20);
            //this.txtClientName.PlaceholderText = "Client Name";

            // TextBox for Client Number
            this.txtClientNumber = new TextBox();
            this.txtClientNumber.Location = new System.Drawing.Point(20, 60);
            this.txtClientNumber.Size = new System.Drawing.Size(300, 20);
            //this.txtClientNumber.PlaceholderText = "Client Contact Number";

            // CheckBox for Is Company
            this.chkIsCompany = new CheckBox();
            this.chkIsCompany.Location = new System.Drawing.Point(20, 100);
            this.chkIsCompany.Size = new System.Drawing.Size(150, 20);
            this.chkIsCompany.Text = "Is this a Company?";

            // ListView for Tyres
            this.lvTyres = new ListView();
            this.lvTyres.Location = new System.Drawing.Point(20, 140);
            this.lvTyres.Size = new System.Drawing.Size(600, 200);
            this.lvTyres.View = View.Details;
            this.lvTyres.FullRowSelect = true;
            this.lvTyres.MultiSelect = false;

            // Add columns to ListView
            this.lvTyres.Columns.Add("ID", 50);
            this.lvTyres.Columns.Add("Brand", 100);
            this.lvTyres.Columns.Add("Model", 150);
            this.lvTyres.Columns.Add("Size", 80);
            this.lvTyres.Columns.Add("Price", 80);
            this.lvTyres.Columns.Add("Quantity Available", 120);

            // NumericUpDown for Quantity
            this.nudQuantity = new NumericUpDown();
            this.nudQuantity.Location = new System.Drawing.Point(20, 360);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 1000;

            // Sell Button
            this.btnSell = new Button();
            this.btnSell.Location = new System.Drawing.Point(20, 400);
            this.btnSell.Size = new System.Drawing.Size(200, 40);
            this.btnSell.Text = "Perform Sale";
            this.btnSell.Click += BtnSell_Click;

            // Add controls to the form
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtClientNumber);
            this.Controls.Add(this.chkIsCompany);
            this.Controls.Add(this.lvTyres);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnSell);

            // Configure the form
            this.Text = "Perform Sale";
            this.ClientSize = new System.Drawing.Size(650, 470);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion
    }
}