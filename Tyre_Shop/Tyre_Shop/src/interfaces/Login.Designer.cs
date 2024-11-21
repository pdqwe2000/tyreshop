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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_registar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Location = new System.Drawing.Point(249, 161);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(249, 26);
            this.tb_user.TabIndex = 0;
            this.tb_user.TextChanged += new System.EventHandler(this.tb_user_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pass.Location = new System.Drawing.Point(249, 231);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(249, 26);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // lb_user
            // 
            this.lb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(245, 133);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(43, 20);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "User";
            this.lb_user.Click += new System.EventHandler(this.lb_user_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(245, 204);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(78, 20);
            this.lb_pass.TabIndex = 3;
            this.lb_pass.Text = "Password";
            this.lb_pass.Click += new System.EventHandler(this.lb_pass_Click);
            // 
            // bt_login
            // 
            this.bt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login.Location = new System.Drawing.Point(249, 280);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(249, 34);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_registar
            // 
            this.lb_registar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_registar.AutoSize = true;
            this.lb_registar.Location = new System.Drawing.Point(340, 317);
            this.lb_registar.Name = "lb_registar";
            this.lb_registar.Size = new System.Drawing.Size(69, 20);
            this.lb_registar.TabIndex = 5;
            this.lb_registar.TabStop = true;
            this.lb_registar.Text = "Registar";
            this.lb_registar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_registar_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 467);
            this.Controls.Add(this.lb_registar);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.LinkLabel lb_registar;
    }
}