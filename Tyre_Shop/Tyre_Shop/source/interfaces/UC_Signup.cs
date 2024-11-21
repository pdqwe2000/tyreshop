using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyre_Shop.classes;

namespace Tyre_Shop.source.interfaces
{
    public partial class UC_Signup : UserControl
    {
        public UC_Signup()
        {
            InitializeComponent();
        }

        private void bt_signup_Click(object sender, EventArgs e)
        {
            int counter = 0;
            UserRepo repositorio = new UserRepo();
            LoginService loginservice = new LoginService();

            List<User> usuarios = repositorio.LoadUsers();

            // Verifica se o usuário existe e a senha está correta
            foreach (User usuario in usuarios)
            {
                if (usuario.Name == Tb_UserSignup.Text)
                {
                    MessageBox.Show("User Already In Use!");
                    counter = 1;
                }
            }
            if (counter == 0)
            {
                loginservice.SignupUser(Tb_UserSignup.Text,TB_phone.Text ,Tb_PassSignup.Text, cb_admin.Checked);

            }
        }

        private void lb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
