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

        private void button1_Click(object sender, EventArgs e)
        {
            bool res;
            LoginService loginService = new LoginService();

            string name = tb_user.Text;
            string pass = tb_pass.Text;
            res=loginService.Login(name, pass);
            if (res == true)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog(); 
            }


        }

        private void lb_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup(); 
            signup.ShowDialog();
        }
    }
}
