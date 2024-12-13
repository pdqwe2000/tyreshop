using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyre_Shop.source.interfaces
{
    partial class Login2
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.btnRegister);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(394, 562);
            this.panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(112, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login Page";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(56, 125);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(99, 28);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(56, 162);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 34);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(56, 225);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 28);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(56, 262);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(281, 34);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(150)))), ((int)(((byte)(248)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(56, 338);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(281, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(150)))), ((int)(((byte)(248)))));
            this.btnRegister.Location = new System.Drawing.Point(56, 412);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(281, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 562);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }

    #endregion
}

//using System;
//using System.Drawing;
//using System.Windows.Forms;

//public partial class LoginForm : Form
//{
//    public LoginForm()
//    {
//        InitializeComponent();
//    }

//    private void InitializeComponent()
//    {
//        this.panelMain = new System.Windows.Forms.Panel();
//        this.lblTitle = new System.Windows.Forms.Label();
//        this.lblUsername = new System.Windows.Forms.Label();
//        this.txtUsername = new System.Windows.Forms.TextBox();
//        this.lblPassword = new System.Windows.Forms.Label();
//        this.txtPassword = new System.Windows.Forms.TextBox();
//        this.btnLogin = new System.Windows.Forms.Button();
//        this.btnRegister = new System.Windows.Forms.Button();

//        this.panelTop = new System.Windows.Forms.Panel();
//        this.btnClose = new System.Windows.Forms.Button();
//        this.btnMinimize = new System.Windows.Forms.Button();

//        this.SuspendLayout();
//        // 
//        // panelMain
//        // 
//        this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
//        this.panelMain.BackColor = Color.WhiteSmoke;
//        this.panelMain.Controls.Add(this.lblTitle);
//        this.panelMain.Controls.Add(this.lblUsername);
//        this.panelMain.Controls.Add(this.txtUsername);
//        this.panelMain.Controls.Add(this.lblPassword);
//        this.panelMain.Controls.Add(this.txtPassword);
//        this.panelMain.Controls.Add(this.btnLogin);
//        this.panelMain.Controls.Add(this.btnRegister);
//        this.Controls.Add(this.panelMain);
//        this.Controls.Add(this.panelTop);
//        // 
//        // panelTop
//        // 
//        this.panelTop.Dock = DockStyle.Top;
//        this.panelTop.BackColor = Color.FromArgb(58, 150, 248);
//        this.panelTop.Height = 40;
//        this.panelTop.Controls.Add(this.btnClose);
//        this.panelTop.Controls.Add(this.btnMinimize);
//        this.panelTop.MouseDown += new MouseEventHandler(this.PanelTop_MouseDown); // Arrastar janela
//        // 
//        // btnClose
//        // 
//        this.btnClose.BackColor = Color.FromArgb(220, 53, 69);
//        this.btnClose.FlatAppearance.BorderSize = 0;
//        this.btnClose.FlatStyle = FlatStyle.Flat;
//        this.btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//        this.btnClose.ForeColor = Color.White;
//        this.btnClose.Location = new Point(this.ClientSize.Width - 40, 0);
//        this.btnClose.Size = new Size(40, 40);
//        this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//        this.btnClose.Text = "X";
//        this.btnClose.UseVisualStyleBackColor = false;
//        this.btnClose.Click += new EventHandler(this.BtnClose_Click);
//        // 
//        // btnMinimize
//        // 
//        this.btnMinimize.BackColor = Color.FromArgb(40, 167, 69);
//        this.btnMinimize.FlatAppearance.BorderSize = 0;
//        this.btnMinimize.FlatStyle = FlatStyle.Flat;
//        this.btnMinimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//        this.btnMinimize.ForeColor = Color.White;
//        this.btnMinimize.Location = new Point(this.ClientSize.Width - 80, 0);
//        this.btnMinimize.Size = new Size(40, 40);
//        this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
//        this.btnMinimize.Text = "_";
//        this.btnMinimize.UseVisualStyleBackColor = false;
//        this.btnMinimize.Click += new EventHandler(this.BtnMinimize_Click);
//        // 
//        // lblTitle
//        // 
//        this.lblTitle.AutoSize = true;
//        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//        this.lblTitle.ForeColor = System.Drawing.Color.Black;
//        this.lblTitle.Location = new System.Drawing.Point(100, 50);
//        this.lblTitle.Name = "lblTitle";
//        this.lblTitle.Size = new System.Drawing.Size(150, 37);
//        this.lblTitle.TabIndex = 0;
//        this.lblTitle.Text = "Login Page";
//        this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
//        // 
//        // lblUsername
//        // 
//        this.lblUsername.AutoSize = true;
//        this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
//        this.lblUsername.ForeColor = System.Drawing.Color.Black;
//        this.lblUsername.Location = new System.Drawing.Point(50, 120);
//        this.lblUsername.Name = "lblUsername";
//        this.lblUsername.Size = new System.Drawing.Size(83, 23);
//        this.lblUsername.TabIndex = 1;
//        this.lblUsername.Text = "Username";
//        // 
//        // txtUsername
//        // 
//        this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
//        this.txtUsername.Location = new System.Drawing.Point(50, 150);
//        this.txtUsername.Name = "txtUsername";
//        this.txtUsername.Size = new System.Drawing.Size(250, 30);
//        this.txtUsername.TabIndex = 2;
//        // 
//        // lblPassword
//        // 
//        this.lblPassword.AutoSize = true;
//        this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
//        this.lblPassword.ForeColor = System.Drawing.Color.Black;
//        this.lblPassword.Location = new System.Drawing.Point(50, 200);
//        this.lblPassword.Name = "lblPassword";
//        this.lblPassword.Size = new System.Drawing.Size(79, 23);
//        this.lblPassword.TabIndex = 3;
//        this.lblPassword.Text = "Password";
//        // 
//        // txtPassword
//        // 
//        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
//        this.txtPassword.Location = new System.Drawing.Point(50, 230);
//        this.txtPassword.Name = "txtPassword";
//        this.txtPassword.PasswordChar = '•';
//        this.txtPassword.Size = new System.Drawing.Size(250, 30);
//        this.txtPassword.TabIndex = 4;
//        // 
//        // btnLogin
//        // 
//        this.btnLogin.BackColor = Color.FromArgb(58, 150, 248);
//        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//        this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//        this.btnLogin.ForeColor = System.Drawing.Color.White;
//        this.btnLogin.Location = new System.Drawing.Point(50, 280);
//        this.btnLogin.Name = "btnLogin";
//        this.btnLogin.Size = new System.Drawing.Size(250, 40);
//        this.btnLogin.TabIndex = 5;
//        this.btnLogin.Text = "Login";
//        this.btnLogin.UseVisualStyleBackColor = false;
//        this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
//        // 
//        // btnRegister
//        // 
//        this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//        this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//        this.btnRegister.ForeColor = Color.FromArgb(58, 150, 248);
//        this.btnRegister.Location = new System.Drawing.Point(50, 340);
//        this.btnRegister.Name = "btnRegister";
//        this.btnRegister.Size = new System.Drawing.Size(250, 40);
//        this.btnRegister.TabIndex = 6;
//        this.btnRegister.Text = "Register";
//        this.btnRegister.UseVisualStyleBackColor = true;
//        this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
//        // 
//        // LoginForm
//        // 
//        this.BackColor = Color.White;
//        this.ClientSize = new System.Drawing.Size(350, 450);
//        this.Controls.Add(this.panelMain);
//        this.FormBorderStyle = FormBorderStyle.None;
//        this.StartPosition = FormStartPosition.CenterScreen;
//        this.ResumeLayout(false);
//    }

//    // Event Handlers
//    private void BtnClose_Click(object sender, EventArgs e)
//    {
//        Application.Exit();
//    }

//    private void BtnMinimize_Click(object sender, EventArgs e)
//    {
//        this.WindowState = FormWindowState.Minimized;
//    }

//    private void PanelTop_MouseDown(object sender, MouseEventArgs e)
//    {
//        if (e.Button == MouseButtons.Left)
//        {
//            ReleaseCapture();
//            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
//        }
//    }

//    // DLL Imports for dragging window
//    [System.Runtime.InteropServices.DllImport("user32.dll")]
//    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
//    [System.Runtime.InteropServices.DllImport("user32.dll")]
//    public static extern bool ReleaseCapture();
//    private const int WM_NCLBUTTONDOWN = 0xA1;
//    private const int HT_CAPTION = 0x2;

//    private System.Windows.Forms.Panel panelMain;
//    private System.Windows.Forms.Panel panelTop;
//    private System.Windows.Forms.Button btnClose;
//    private System.Windows.Forms.Button btnMinimize;
//    private System.Windows.Forms.Label lblTitle;
//    private System.Windows.Forms.Label lblUsername;
//    private System.Windows.Forms.TextBox txtUsername;
//    private System.Windows.Forms.Label lblPassword;
//    private System.Windows.Forms.TextBox txtPassword;
//    private System.Windows.Forms.Button btnLogin;
//    private System.Windows.Forms.Button btnRegister;
//}
