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
            this.Tb_PassSignup = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_signup = new System.Windows.Forms.Button();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.lb_login = new System.Windows.Forms.LinkLabel();
            this.lb_phone = new System.Windows.Forms.Label();
            this.TB_phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tb_UserSignup
            // 
            this.Tb_UserSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_UserSignup.Location = new System.Drawing.Point(319, 56);
            this.Tb_UserSignup.Name = "Tb_UserSignup";
            this.Tb_UserSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_UserSignup.TabIndex = 0;
            this.Tb_UserSignup.TextChanged += new System.EventHandler(this.Tb_UserSignup_TextChanged);
            // 
            // Tb_PassSignup
            // 
            this.Tb_PassSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_PassSignup.Location = new System.Drawing.Point(319, 164);
            this.Tb_PassSignup.Name = "Tb_PassSignup";
            this.Tb_PassSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_PassSignup.TabIndex = 1;
            this.Tb_PassSignup.TextChanged += new System.EventHandler(this.Tb_PassSignup_TextChanged);
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(315, 31);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 20);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "User";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pass";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_signup
            // 
            this.bt_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_signup.Location = new System.Drawing.Point(319, 226);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(270, 40);
            this.bt_signup.TabIndex = 4;
            this.bt_signup.Text = "Signup";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // cb_admin
            // 
            this.cb_admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(319, 196);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(80, 24);
            this.cb_admin.TabIndex = 5;
            this.cb_admin.Text = "Admin";
            this.cb_admin.UseVisualStyleBackColor = true;
            this.cb_admin.CheckedChanged += new System.EventHandler(this.cb_admin_CheckedChanged);
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(421, 269);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(48, 20);
            this.lb_login.TabIndex = 6;
            this.lb_login.TabStop = true;
            this.lb_login.Text = "Login";
            this.lb_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_login_LinkClicked);
            // 
            // lb_phone
            // 
            this.lb_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(315, 85);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(55, 20);
            this.lb_phone.TabIndex = 8;
            this.lb_phone.Text = "Phone";
            this.lb_phone.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_phone
            // 
            this.TB_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_phone.Location = new System.Drawing.Point(319, 110);
            this.TB_phone.Name = "TB_phone";
            this.TB_phone.Size = new System.Drawing.Size(270, 26);
            this.TB_phone.TabIndex = 7;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 336);
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
    }
}