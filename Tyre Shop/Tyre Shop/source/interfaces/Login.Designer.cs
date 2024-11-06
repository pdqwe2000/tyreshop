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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_registar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(253, 192);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(249, 26);
            this.tb_user.TabIndex = 0;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(253, 262);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(249, 26);
            this.tb_pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_registar
            // 
            this.lb_registar.AutoSize = true;
            this.lb_registar.Location = new System.Drawing.Point(337, 360);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_registar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lb_registar;
    }
}