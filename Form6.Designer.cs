namespace SuperMarket
{
    partial class AdminProfile
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
            this.inBirthDate = new System.Windows.Forms.DateTimePicker();
            this.inEmail = new System.Windows.Forms.TextBox();
            this.inLastName = new System.Windows.Forms.TextBox();
            this.inFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.inPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inBirthDate
            // 
            this.inBirthDate.Location = new System.Drawing.Point(468, 315);
            this.inBirthDate.Name = "inBirthDate";
            this.inBirthDate.Size = new System.Drawing.Size(423, 27);
            this.inBirthDate.TabIndex = 19;
            // 
            // inEmail
            // 
            this.inEmail.Location = new System.Drawing.Point(467, 262);
            this.inEmail.Name = "inEmail";
            this.inEmail.Size = new System.Drawing.Size(422, 27);
            this.inEmail.TabIndex = 14;
            // 
            // inLastName
            // 
            this.inLastName.Location = new System.Drawing.Point(468, 157);
            this.inLastName.Name = "inLastName";
            this.inLastName.Size = new System.Drawing.Size(422, 27);
            this.inLastName.TabIndex = 17;
            // 
            // inFirstName
            // 
            this.inFirstName.Location = new System.Drawing.Point(468, 93);
            this.inFirstName.Name = "inFirstName";
            this.inFirstName.Size = new System.Drawing.Size(422, 27);
            this.inFirstName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birth-Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(384, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(507, 53);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(625, 44);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 20);
            this.lbUserName.TabIndex = 22;
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // inPassword
            // 
            this.inPassword.Location = new System.Drawing.Point(468, 213);
            this.inPassword.Name = "inPassword";
            this.inPassword.Size = new System.Drawing.Size(422, 27);
            this.inPassword.TabIndex = 15;
            this.inPassword.UseSystemPasswordChar = true;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 531);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.inBirthDate);
            this.Controls.Add(this.inEmail);
            this.Controls.Add(this.inPassword);
            this.Controls.Add(this.inLastName);
            this.Controls.Add(this.inFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker inBirthDate;
        private TextBox inEmail;
        private TextBox inLastName;
        private TextBox inFirstName;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnUpdate;
        private Label lbUserName;
        private TextBox inPassword;
    }
}