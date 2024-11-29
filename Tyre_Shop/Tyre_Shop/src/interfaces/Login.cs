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
using Tyre_Shop.models.Interfaces;

namespace Tyre_Shop.source.interfaces
{
    public partial class Login : Form,Ilogin
    {
        /// <summary>
        /// Gets the entered username from the input field.
        /// </summary>
        public string User => tb_user.Text;

        /// <summary>
        /// Gets the entered password from the input field.
        /// </summary>
        public string Password => tb_pass.Text;
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the login process asynchronously.
        /// </summary>
        public async void HandleLoginAsync()
        {
            LoginController controller = new LoginController(this);
            await controller.HandleLoginAsync();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            HandleLoginAsync();

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
            NavigateToRegister();
        }

        /// <summary>
        /// Handles the key down event for the password input field to trigger the login process on Enter key press.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //HandleLoginAsync();
            }
        }
        public void NavigateToRegister()
        {
            new Signup().Show();
            Hide();
        }
    }
}
