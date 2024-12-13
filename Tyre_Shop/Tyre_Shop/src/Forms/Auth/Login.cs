using Tyre_Shop.Classes.Controller;
using System;
using System.Windows.Forms;
using Tyre_Shop.Classes.Interfaces;

namespace Tyre_Shop.source.interfaces
{
    public partial class Login : Form,ILogin
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
        /// Displays a message box with the specified message, caption, and icon.
        /// </summary>
        public void DisplayMessage(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Toggles the visibility of the password field.
        /// </summary>
        public void TogglePasswordVisibility(bool showPassword)
        {
            
            tb_pass.PasswordChar = showPassword ? '\0' : '*';
        }

        /// <summary>
        /// Clears the username and password input fields and sets focus to the username field.
        /// </summary>
        public void ClearInputs()
        {
            tb_user.Text = string.Empty;
            tb_pass.Text = string.Empty;
            tb_user.Focus();
        }

        /// <summary>
        /// Handles the login process asynchronously.
        /// </summary>
        public async void HandleLoginAsync()
        {
            LoginController controller = new LoginController(this);
            await controller.HandleLoginAsync();
        }

        /// <summary>
        /// Navigates to the main form and updates the username label.
        /// </summary>
        public void NavigateToMainForm(string username, bool admin)
        {
            if (admin)
            {
                Dashboard_Admin adminForm = new Dashboard_Admin();
                adminForm.Show();
                //Dashboard.instance.lbl.Text = username;
                Hide();
            }
            else
            {
                Dashboard normalForm = new Dashboard();
                normalForm.Show();
                //Dashboard.instance.lbl.Text = username;
                Hide();
            }
        }

        /// <summary>
        /// Navigates to the registration form.
        /// </summary>
        public void NavigateToRegister()
        {
            new Signup().Show();
            Hide();
        }
        /// <summary>
        /// Handles the "Show Password" checkbox state change to toggle password visibility.
        /// </summary>
        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(checkboxShowPass.Checked);
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            HandleLoginAsync();

            //User res;
            //LoginService loginService = new LoginService();

            //string name = tb_user.Text;
            //string pass = tb_pass.Text;
            //bool admin = false;
            //res=loginService.LoginAsync(name, pass, admin);
            //if (res.Admin== false)
            //{
            //    Dashboard dashboard = new Dashboard();
            //    dashboard.ShowDialog(); 
            //}
            //else if (res.Admin == true)
            //{
            //    Dashboard_Admin  dashboard_admin = new Dashboard_Admin();
            //    dashboard_admin.ShowDialog();
            //}


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
                HandleLoginAsync();
            }
        }
    }
}
