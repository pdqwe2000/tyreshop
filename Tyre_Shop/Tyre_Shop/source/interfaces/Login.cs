using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.classes;

namespace Tyre_Shop.source.interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            User res;
            LoginService loginService = new LoginService();

            string name = tb_user.Text;
            string pass = tb_pass.Text;
            bool admin = false;
            res=loginService.Login(name, pass, admin);
            if (res.Admin== false)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog(); 
            }
            else if (res.Admin == true)
            {
                Dashboard_Admin  dashboard_admin = new Dashboard_Admin();
                dashboard_admin.ShowDialog();
            }


        }

        private void lb_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().ShowDialog();
        }

        private void lb_pass_Click(object sender, EventArgs e)
        {

        }

        private void lb_user_Click(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
