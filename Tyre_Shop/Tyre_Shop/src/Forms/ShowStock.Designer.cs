using System.Windows.Forms;

namespace Tyre_Shop.src.Forms
{
    public partial class ShowStock
    {
        private DataGridView dgvStock;
        private void InitializeComponent()
        {
            this.dgvStock = new DataGridView();

            // Configure the DataGridView
            this.dgvStock.Location = new System.Drawing.Point(12, 12);
            this.dgvStock.Size = new System.Drawing.Size(760, 400);
            this.dgvStock.ReadOnly = true;
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add Controls to the Form
            this.Controls.Add(this.dgvStock);

            // Configure the Form
            this.Text = "View Stock";
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
       
    }
}