namespace Tyre_Shop.source.interfaces
{
    partial class UC_Signup
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
            this.lb_login = new System.Windows.Forms.LinkLabel();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.bt_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.Tb_PassSignup = new System.Windows.Forms.TextBox();
            this.Tb_UserSignup = new System.Windows.Forms.TextBox();
            this.LB_phone = new System.Windows.Forms.Label();
            this.TB_phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(260, 293);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(48, 20);
            this.lb_login.TabIndex = 13;
            this.lb_login.TabStop = true;
            this.lb_login.Text = "Login";
            this.lb_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_login_LinkClicked);
            // 
            // cb_admin
            // 
            this.cb_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(158, 220);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(80, 24);
            this.cb_admin.TabIndex = 12;
            this.cb_admin.Text = "Admin";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // bt_signup
            // 
            this.bt_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_signup.Location = new System.Drawing.Point(158, 250);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(270, 40);
            this.bt_signup.TabIndex = 11;
            this.bt_signup.Text = "Signup";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pass";
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(154, 48);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 20);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "User";
            // 
            // Tb_PassSignup
            // 
            this.Tb_PassSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_PassSignup.Location = new System.Drawing.Point(158, 188);
            this.Tb_PassSignup.MaxLength = 30;
            this.Tb_PassSignup.Name = "Tb_PassSignup";
            this.Tb_PassSignup.PasswordChar = '*';
            this.Tb_PassSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_PassSignup.TabIndex = 8;
            // 
            // Tb_UserSignup
            // 
            this.Tb_UserSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_UserSignup.Location = new System.Drawing.Point(158, 73);
            this.Tb_UserSignup.Name = "Tb_UserSignup";
            this.Tb_UserSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_UserSignup.TabIndex = 7;
            // 
            // LB_phone
            // 
            this.LB_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_phone.AutoSize = true;
            this.LB_phone.Location = new System.Drawing.Point(154, 106);
            this.LB_phone.Name = "LB_phone";
            this.LB_phone.Size = new System.Drawing.Size(55, 20);
            this.LB_phone.TabIndex = 15;
            this.LB_phone.Text = "Phone";
            // 
            // TB_phone
            // 
            this.TB_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_phone.Location = new System.Drawing.Point(158, 131);
            this.TB_phone.Name = "TB_phone";
            this.TB_phone.Size = new System.Drawing.Size(270, 26);
            this.TB_phone.TabIndex = 14;
            // 
            // UC_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LB_phone);
            this.Controls.Add(this.TB_phone);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.cb_admin);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.Tb_PassSignup);
            this.Controls.Add(this.Tb_UserSignup);
            this.Name = "UC_Signup";
            this.Size = new System.Drawing.Size(586, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lb_login;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox Tb_PassSignup;
        private System.Windows.Forms.TextBox Tb_UserSignup;
        private System.Windows.Forms.Label LB_phone;
        private System.Windows.Forms.TextBox TB_phone;
    }
}
