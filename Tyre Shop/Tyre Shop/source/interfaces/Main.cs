using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyre_Shop.source.interfaces
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            uC_Login1.Show();
            uC_Login1.BringToFront();
        }

        private void bt_signup_Click(object sender, EventArgs e)
        {
            uC_Signup1.Show();
            uC_Signup1.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_Login1_Load(object sender, EventArgs e)
        {

        }
    }
}
