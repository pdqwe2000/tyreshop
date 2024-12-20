using System.Windows.Forms;
using System;
using Tyre_Shop.Classes.Services;
using Tyre_Shop.Classes.Facade;

namespace Tyre_Shop.src.Forms.Auth
{
    partial class UserDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._facade = new RegisterFacade();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(460, 200);
            this.dgvUsers.TabIndex = 0;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(95, 230);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 20);
            this.txtUserId.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(210, 228);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 233);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(74, 13);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "Enter User ID:";
            // 
            // UserDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnDeleteUser);
            this.Name = "UserDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private RegisterFacade _facade;
        private DataGridView dgvUsers;
        private TextBox txtUserId;
        private Button btnDeleteUser;
        private Label lblUserId;

        #endregion
    }
}