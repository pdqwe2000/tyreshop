namespace Tyre_Shop.source.interfaces
{
    partial class Signup
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
            this.Tb_UserSignup = new System.Windows.Forms.TextBox();
            this.TB_phone = new System.Windows.Forms.TextBox();
            this.Tb_PassSignup = new System.Windows.Forms.TextBox();
            this.TB_ConfPass = new System.Windows.Forms.TextBox();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.bt_signup = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.LinkLabel();
            this.lb_phone = new System.Windows.Forms.Label();
            this.LB_ConfPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_UserSignup
            // 
            this.Tb_UserSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_UserSignup.Location = new System.Drawing.Point(157, 81);
            this.Tb_UserSignup.Name = "Tb_UserSignup";
            this.Tb_UserSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_UserSignup.TabIndex = 0;
            // 
            // TB_phone
            // 
            this.TB_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_phone.Location = new System.Drawing.Point(157, 138);
            this.TB_phone.Name = "TB_phone";
            this.TB_phone.Size = new System.Drawing.Size(270, 26);
            this.TB_phone.TabIndex = 1;
            // 
            // Tb_PassSignup
            // 
            this.Tb_PassSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_PassSignup.Location = new System.Drawing.Point(157, 196);
            this.Tb_PassSignup.Name = "Tb_PassSignup";
            this.Tb_PassSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_PassSignup.TabIndex = 2;
            // 
            // TB_ConfPass
            // 
            this.TB_ConfPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_ConfPass.Location = new System.Drawing.Point(157, 254);
            this.TB_ConfPass.Name = "TB_ConfPass";
            this.TB_ConfPass.Size = new System.Drawing.Size(270, 26);
            this.TB_ConfPass.TabIndex = 3;
            // 
            // cb_admin
            // 
            this.cb_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(157, 288);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(80, 24);
            this.cb_admin.TabIndex = 4;
            this.cb_admin.Text = "Admin";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // bt_signup
            // 
            this.bt_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_signup.Location = new System.Drawing.Point(157, 318);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(270, 40);
            this.bt_signup.TabIndex = 5;
            this.bt_signup.Text = "Signup";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(153, 56);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 20);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "User";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pass";
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(259, 361);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(48, 20);
            this.lb_login.TabIndex = 8;
            this.lb_login.TabStop = true;
            this.lb_login.Text = "Login";
            this.lb_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_login_LinkClicked);
            // 
            // lb_phone
            // 
            this.lb_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(153, 113);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(55, 20);
            this.lb_phone.TabIndex = 9;
            this.lb_phone.Text = "Phone";
            // 
            // LB_ConfPass
            // 
            this.LB_ConfPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_ConfPass.AutoSize = true;
            this.LB_ConfPass.Location = new System.Drawing.Point(153, 229);
            this.LB_ConfPass.Name = "LB_ConfPass";
            this.LB_ConfPass.Size = new System.Drawing.Size(103, 20);
            this.LB_ConfPass.TabIndex = 10;
            this.LB_ConfPass.Text = "Confirm Pass";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 435);
            this.Controls.Add(this.LB_ConfPass);
            this.Controls.Add(this.TB_ConfPass);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.TB_phone);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.cb_admin);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.Tb_PassSignup);
            this.Controls.Add(this.Tb_UserSignup);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_UserSignup;
        private System.Windows.Forms.TextBox Tb_PassSignup;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.LinkLabel lb_login;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox TB_phone;
        private System.Windows.Forms.Label LB_ConfPass;
        private System.Windows.Forms.TextBox TB_ConfPass;
    }
}