namespace SuperMarket
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuperMarket = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.inUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.Label();
            this.inPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegCustomer = new System.Windows.Forms.Button();
            this.btnRegAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SuperMarket
            // 
            this.SuperMarket.AutoSize = true;
            this.SuperMarket.BackColor = System.Drawing.Color.Red;
            this.SuperMarket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SuperMarket.ForeColor = System.Drawing.Color.White;
            this.SuperMarket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SuperMarket.Location = new System.Drawing.Point(370, 29);
            this.SuperMarket.Name = "SuperMarket";
            this.SuperMarket.Padding = new System.Windows.Forms.Padding(120, 10, 120, 10);
            this.SuperMarket.Size = new System.Drawing.Size(428, 61);
            this.SuperMarket.TabIndex = 0;
            this.SuperMarket.Text = "SuperMarket";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserName.Location = new System.Drawing.Point(370, 151);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(82, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "User Name";
            // 
            // inUserName
            // 
            this.inUserName.Location = new System.Drawing.Point(458, 148);
            this.inUserName.Name = "inUserName";
            this.inUserName.Size = new System.Drawing.Size(340, 27);
            this.inUserName.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPass.Location = new System.Drawing.Point(370, 224);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(70, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Password";
            // 
            // inPassword
            // 
            this.inPassword.Location = new System.Drawing.Point(458, 224);
            this.inPassword.Name = "inPassword";
            this.inPassword.Size = new System.Drawing.Size(340, 27);
            this.inPassword.TabIndex = 2;
            this.inPassword.UseSystemPasswordChar = true;
            this.inPassword.TextChanged += new System.EventHandler(this.inPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(370, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(428, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegCustomer
            // 
            this.btnRegCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegCustomer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegCustomer.ForeColor = System.Drawing.Color.White;
            this.btnRegCustomer.Location = new System.Drawing.Point(370, 373);
            this.btnRegCustomer.Name = "btnRegCustomer";
            this.btnRegCustomer.Size = new System.Drawing.Size(428, 51);
            this.btnRegCustomer.TabIndex = 3;
            this.btnRegCustomer.Text = "Register Customer";
            this.btnRegCustomer.UseVisualStyleBackColor = false;
            this.btnRegCustomer.Click += new System.EventHandler(this.btnRegCustomer_Click);
            // 
            // btnRegAdmin
            // 
            this.btnRegAdmin.BackColor = System.Drawing.Color.Blue;
            this.btnRegAdmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegAdmin.ForeColor = System.Drawing.Color.White;
            this.btnRegAdmin.Location = new System.Drawing.Point(370, 442);
            this.btnRegAdmin.Name = "btnRegAdmin";
            this.btnRegAdmin.Size = new System.Drawing.Size(428, 51);
            this.btnRegAdmin.TabIndex = 3;
            this.btnRegAdmin.Text = "Register Admin";
            this.btnRegAdmin.UseVisualStyleBackColor = false;
            this.btnRegAdmin.Click += new System.EventHandler(this.btnRegAdmin_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 627);
            this.Controls.Add(this.btnRegAdmin);
            this.Controls.Add(this.btnRegCustomer);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inPassword);
            this.Controls.Add(this.inUserName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.SuperMarket);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SuperMarket;
        private Label txtUserName;
        private TextBox inUserName;
        private Label txtPass;
        private TextBox inPassword;
        private Button btnLogin;
        private Button btnRegCustomer;
        private Button btnRegAdmin;
    }
}