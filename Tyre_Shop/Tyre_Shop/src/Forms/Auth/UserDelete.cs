//-----------------------------------------------------------------​
//    <copyright file="UserDelete.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyre_Shop.Classes.Auth;
using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.src.Forms.Auth
{
    public partial class UserDelete : Form
    {
        public UserDelete()
        {
            InitializeComponent();
            LoadUsers();

        }

        private async Task LoadUsers()
        {
            try
            {
                // Load the users using the AuthService
                List<User> users = await _facade.LoadUsersAsync();

                // Bind the users to the DataGridView
                dgvUsers.DataSource = users;

                // Optional: Adjust column headers for better readability
                dgvUsers.Columns["Password"].Visible = false; // Hide password column for security
                dgvUsers.Columns["Name"].HeaderText = "Username";
                dgvUsers.Columns["Phone"].HeaderText = "Phone Number";
                dgvUsers.Columns["Admin"].HeaderText = "Is Admin";

                // Auto-size columns
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button click event for deleting a user
        private async void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            string usernameToDelete = txtUserId.Text;
            bool isDeleted = await _facade.DeleteUserAsync(usernameToDelete);
            if (isDeleted)
            {
                Console.WriteLine($"User '{usernameToDelete}' was successfully deleted.");
            }
            else
            {
                Console.WriteLine($"User '{usernameToDelete}' was not found.");
            }
        }

        //private async void UserDelete_Load(object sender, EventArgs e)
        //{
        //   await 
        //}
    }
}
