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
            this.panel2.Controls.Add(this.lb_registar);
            this.panel2.Controls.Add(this.bt_login);
            this.panel2.Controls.Add(this.lb_pass);
            this.panel2.Controls.Add(this.lb_user);
            this.panel2.Controls.Add(this.tb_pass);
            this.panel2.Controls.Add(this.tb_user);
            this.panel2.Location = new System.Drawing.Point(11, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 584);
            this.panel2.TabIndex = 7;
            // 
            // lb_registar
            // 
            this.lb_registar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_registar.AutoSize = true;
            this.lb_registar.Location = new System.Drawing.Point(159, 374);
            this.lb_registar.Name = "lb_registar";
            this.lb_registar.Size = new System.Drawing.Size(69, 20);
            this.lb_registar.TabIndex = 17;
            this.lb_registar.TabStop = true;
            this.lb_registar.Text = "Registar";
            // 
            // bt_login
            // 
            this.bt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login.Location = new System.Drawing.Point(68, 337);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(249, 34);
            this.bt_login.TabIndex = 16;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            // 
            // lb_pass
            // 
            this.lb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(64, 261);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(78, 20);
            this.lb_pass.TabIndex = 15;
            this.lb_pass.Text = "Password";
            // 
            // lb_user
            // 
            this.lb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(64, 190);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(43, 20);
            this.lb_user.TabIndex = 14;
            this.lb_user.Text = "User";
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pass.Location = new System.Drawing.Point(68, 288);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(249, 26);
            this.tb_pass.TabIndex = 13;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Location = new System.Drawing.Point(68, 218);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(249, 26);
            this.tb_user.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 598);
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
    }
}