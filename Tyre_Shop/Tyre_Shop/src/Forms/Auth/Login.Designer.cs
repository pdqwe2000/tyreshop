namespace Tyre_Shop.source.interfaces
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkboxShowPass = new System.Windows.Forms.CheckBox();
            this.lb_registar = new System.Windows.Forms.LinkLabel();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.checkboxShowPass);
            this.panel2.Controls.Add(this.lb_registar);
            this.panel2.Controls.Add(this.bt_login);
            this.panel2.Controls.Add(this.lb_pass);
            this.panel2.Controls.Add(this.lb_user);
            this.panel2.Controls.Add(this.tb_pass);
            this.panel2.Controls.Add(this.tb_user);
            this.panel2.Location = new System.Drawing.Point(98, -76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 584);
            this.panel2.TabIndex = 7;
            // 
            // checkboxShowPass
            // 
            this.checkboxShowPass.AutoSize = true;
            this.checkboxShowPass.Location = new System.Drawing.Point(68, 322);
            this.checkboxShowPass.Name = "checkboxShowPass";
            this.checkboxShowPass.Size = new System.Drawing.Size(148, 24);
            this.checkboxShowPass.TabIndex = 2;
            this.checkboxShowPass.Text = "Show Password";
            this.checkboxShowPass.UseVisualStyleBackColor = true;
            this.checkboxShowPass.CheckedChanged += new System.EventHandler(this.checkboxShowPass_CheckedChanged);
            // 
            // lb_registar
            // 
            this.lb_registar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_registar.AutoSize = true;
            this.lb_registar.Location = new System.Drawing.Point(159, 400);
            this.lb_registar.Name = "lb_registar";
            this.lb_registar.Size = new System.Drawing.Size(69, 20);
            this.lb_registar.TabIndex = 4;
            this.lb_registar.TabStop = true;
            this.lb_registar.Text = "Registar";
            this.lb_registar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_registar_LinkClicked);
            // 
            // bt_login
            // 
            this.bt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login.Location = new System.Drawing.Point(68, 363);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(249, 34);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(64, 261);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(78, 20);
            this.lb_pass.TabIndex = 5;
            this.lb_pass.Text = "Password";
            // 
            // lb_user
            // 
            this.lb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(64, 190);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(43, 20);
            this.lb_user.TabIndex = 6;
            this.lb_user.Text = "User";
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pass.Location = new System.Drawing.Point(68, 288);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(249, 26);
            this.tb_pass.TabIndex = 1;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Location = new System.Drawing.Point(68, 218);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(249, 26);
            this.tb_user.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 436);
            this.Controls.Add(this.panel2);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lb_registar;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.CheckBox checkboxShowPass;
    }
}