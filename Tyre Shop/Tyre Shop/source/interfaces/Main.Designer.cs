namespace Tyre_Shop.source.interfaces
{
    partial class Main
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
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_signup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Login1 = new Tyre_Shop.source.interfaces.UC_Login();
            this.uC_Signup1 = new Tyre_Shop.source.interfaces.UC_Signup();
            this.panel1.SuspendLayout();
 
            // 
            // bt_login
            // 
            this.bt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_login.Location = new System.Drawing.Point(6, 162);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(259, 37);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_signup
            // 
            this.bt_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_signup.Location = new System.Drawing.Point(6, 219);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(259, 37);
            this.bt_signup.TabIndex = 2;
            this.bt_signup.Text = "Signup";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.bt_login);
            this.panel1.Controls.Add(this.bt_signup);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 426);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // uC_Login1
            // 
            this.uC_Login1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uC_Login1.Location = new System.Drawing.Point(283, 1);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(748, 426);
            this.uC_Login1.TabIndex = 3;
            this.uC_Login1.Visible = false;
            this.uC_Login1.Load += new System.EventHandler(this.uC_Login1_Load);
            // 
            // uC_Signup1
            // 
            this.uC_Signup1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uC_Signup1.Location = new System.Drawing.Point(283, 1);
            this.uC_Signup1.Name = "uC_Signup1";
            this.uC_Signup1.Size = new System.Drawing.Size(748, 426);
            this.uC_Signup1.TabIndex = 3;
            this.uC_Signup1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uC_Signup1);
            this.Controls.Add(this.uC_Login1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private UC_Login uC_Login1;
        private System.Windows.Forms.Button bt_signup;
        private UC_Signup uC_Signup1;
        private System.Windows.Forms.Panel panel1;
    }
}