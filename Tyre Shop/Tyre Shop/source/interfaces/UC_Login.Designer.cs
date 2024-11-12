namespace Tyre_Shop.source.interfaces
{
    partial class UC_Login
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_registar = new System.Windows.Forms.LinkLabel();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_registar
            // 
            this.lb_registar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_registar.AutoSize = true;
            this.lb_registar.Location = new System.Drawing.Point(254, 292);
            this.lb_registar.Name = "lb_registar";
            this.lb_registar.Size = new System.Drawing.Size(69, 20);
            this.lb_registar.TabIndex = 11;
            this.lb_registar.TabStop = true;
            this.lb_registar.Text = "Registar";
            this.lb_registar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_registar_LinkClicked);
            // 
            // bt_login
            // 
            this.bt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login.Location = new System.Drawing.Point(163, 255);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(249, 34);
            this.bt_login.TabIndex = 10;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(159, 179);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(78, 20);
            this.lb_pass.TabIndex = 9;
            this.lb_pass.Text = "Password";
            // 
            // lb_user
            // 
            this.lb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(159, 108);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(43, 20);
            this.lb_user.TabIndex = 8;
            this.lb_user.Text = "User";
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pass.Location = new System.Drawing.Point(163, 206);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(249, 26);
            this.tb_pass.TabIndex = 7;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Location = new System.Drawing.Point(163, 136);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(249, 26);
            this.tb_user.TabIndex = 6;
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_registar);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(572, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lb_registar;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
    }
}
