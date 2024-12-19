using Tyre_Shop.Classes.Services;

namespace Tyre_Shop.src.Forms.Auth
{
    partial class UserUpdate
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
            this._authService=new AuthService();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPhone = new System.Windows.Forms.Label();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 50);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(100, 47);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 20);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPhone
            // 
            this.lblNewPhone.AutoSize = true;
            this.lblNewPhone.Location = new System.Drawing.Point(12, 85);
            this.lblNewPhone.Name = "lblNewPhone";
            this.lblNewPhone.Size = new System.Drawing.Size(66, 13);
            this.lblNewPhone.TabIndex = 4;
            this.lblNewPhone.Text = "New Phone:";
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(100, 82);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(200, 20);
            this.txtNewPhone.TabIndex = 5;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(100, 115);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(69, 17);
            this.chkIsAdmin.TabIndex = 6;
            this.chkIsAdmin.Text = "Is Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 30);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Changes";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ChangeUserCredentialsForm
            // 
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.txtNewPhone);
            this.Controls.Add(this.lblNewPhone);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "ChangeUserCredentialsForm";
            this.Text = "Change User Credentials";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private AuthService _authService;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPhone;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.Button btnSubmit;

        #endregion
    }
}