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
using Tyre_Shop.Controllers;
using Tyre_Shop.models.Interfaces;

namespace Tyre_Shop.source.interfaces
{
    public partial class Signup : Form, IRegister
    {
        #region Constructor
        /// <summary>
        /// Initializes the registration form.
        /// </summary>
        public Signup()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the entered username from the input field.
        /// </summary>
        public string Username => Tb_UserSignup.Text;

        /// <summary>
        /// Gets the entered password from the input field.
        /// </summary>
        public string Password => Tb_PassSignup.Text;

        /// <summary>
        /// Gets the entered confirmation password from the input field.
        /// </summary>
        public string ConfirmPassword => TB_ConfPass.Text;

        public string Phone => TB_phone.Text;

        public bool IsAdmin=> cb_admin.Checked;

        #endregion


        #region Public Methods (IRegister Implementation)
        /// <summary>
        /// Displays a message box with the specified message, caption, and icon.
        /// </summary>
        public void DisplayMessage(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Clears the username, password, and confirm password input fields and sets focus to the username field.
        /// </summary>
        public void ClearInputs()
        {
            Tb_UserSignup.Text = string.Empty;
            Tb_PassSignup.Text = string.Empty;
            TB_phone.Text = string.Empty;
            TB_ConfPass.Text = string.Empty;
            Tb_UserSignup.Focus();
        }

        /// <summary>
        /// Navigates to the login form.
        /// </summary>
        public void NavigateToLogin()
        {
            new Login().Show();
            this.Hide();
        }
        #endregion

        private async void bt_signup_Click(object sender, EventArgs e)
        {
            RegisterController controller = new RegisterController(this);
            await controller.HandleRegistrationAsync();
            //int counter=0;
            //UserRepo repositorio = new UserRepo();
            //LoginService loginservice = new LoginService();

            //List<User> usuarios = repositorio.LoadUsersAsync();

            //// Verifica se o usuário existe e a senha está correta
            //foreach (User usuario in usuarios)
            //{
            //    if (usuario.Name == Tb_UserSignup.Text)
            //    {
            //        MessageBox.Show("User Already In Use!");
            //        counter=1;
            //    }
            //}
            //if (counter == 0)
            //{
            //    loginservice.SignupUser(Tb_UserSignup.Text, TB_phone.Text,Tb_PassSignup.Text, cb_admin.Checked);

            //}
        }

        private void lb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToLogin();        
        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }

        
    }
}
