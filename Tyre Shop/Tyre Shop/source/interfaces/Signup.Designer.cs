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
            this.SuspendLayout();
            // 
            // Tb_UserSignup
            // 
            this.Tb_UserSignup.Location = new System.Drawing.Point(265, 163);
            this.Tb_UserSignup.Name = "Tb_UserSignup";
            this.Tb_UserSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_UserSignup.TabIndex = 0;
            // 
            // Tb_PassSignup
            // 
            this.Tb_PassSignup.Location = new System.Drawing.Point(265, 228);
            this.Tb_PassSignup.Name = "Tb_PassSignup";
            this.Tb_PassSignup.Size = new System.Drawing.Size(270, 26);
            this.Tb_PassSignup.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(261, 138);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 20);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pass";
            // 
            // bt_signup
            // 
            this.bt_signup.Location = new System.Drawing.Point(265, 283);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(270, 40);
            this.bt_signup.TabIndex = 4;
            this.bt_signup.Text = "Signup";
            this.bt_signup.UseVisualStyleBackColor = true;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}