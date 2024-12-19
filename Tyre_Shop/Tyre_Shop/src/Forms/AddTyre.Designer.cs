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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(20, 20);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(300, 20);
            this.txtBrand.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(20, 60);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(300, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(20, 100);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(300, 20);
            this.txtSize.TabIndex = 2;
            // 
            // cmbQuality
            // 
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.Items.AddRange(new object[] {50,60,70,80,90,100});
            this.cmbQuality.Location = new System.Drawing.Point(20, 140);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(300, 21);
            this.cmbQuality.TabIndex = 3;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {50,0,0,131072});
            this.nudPrice.Location = new System.Drawing.Point(20, 180);
            this.nudPrice.Maximum = new decimal(new int[] {10000,0,0,0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(300, 20);
            this.nudPrice.TabIndex = 4;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(20, 220);
            this.nudQuantity.Maximum = new decimal(new int[] {1000,0,0,0});
            this.nudQuantity.Minimum = new decimal(new int[] {1,0,0,0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(300, 20);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {1,0,0,0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Tyre";
            this.btnAdd.Click += BtnAdd_Click;
            // 
            // AddTyre
            // 
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbQuality);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddTyre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Tyre";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}