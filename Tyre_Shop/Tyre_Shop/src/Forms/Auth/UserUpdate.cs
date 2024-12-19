using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.src.Forms.Auth
{
    public partial class UserUpdate : Form
    {
        public UserUpdate()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;
            string newPhone = txtNewPhone.Text;
            bool isAdmin = chkIsAdmin.Checked;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the service to update the user credentials
            bool success = await _authService.ChangeUserCredentialsAsync(username, newPassword, newPhone, isAdmin);

            if (success)
            {
                MessageBox.Show("User credentials updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User not found. Please check the username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
