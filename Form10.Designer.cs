namespace SuperMarket
{
    partial class CuProfile
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
            this.inPassword = new System.Windows.Forms.TextBox();
            this.inLastName = new System.Windows.Forms.TextBox();
            this.inFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inBirthDate
            // 
            this.inBirthDate.Location = new System.Drawing.Point(421, 343);
            this.inBirthDate.Name = "inBirthDate";
            this.inBirthDate.Size = new System.Drawing.Size(462, 27);
            this.inBirthDate.TabIndex = 34;
            // 
            // inEmail
            // 
            this.inEmail.Location = new System.Drawing.Point(421, 289);
            this.inEmail.Name = "inEmail";
            this.inEmail.Size = new System.Drawing.Size(461, 27);
            this.inEmail.TabIndex = 29;
            // 
            // inPassword
            // 
            this.inPassword.Location = new System.Drawing.Point(420, 241);
            this.inPassword.Name = "inPassword";
            this.inPassword.Size = new System.Drawing.Size(461, 27);
            this.inPassword.TabIndex = 30;
            this.inPassword.UseSystemPasswordChar = true;
            // 
            // inLastName
            // 
            this.inLastName.Location = new System.Drawing.Point(420, 194);
            this.inLastName.Name = "inLastName";
            this.inLastName.Size = new System.Drawing.Size(461, 27);
            this.inLastName.TabIndex = 32;
            // 
            // inFirstName
            // 
            this.inFirstName.Location = new System.Drawing.Point(420, 144);
            this.inFirstName.Name = "inFirstName";
            this.inFirstName.Size = new System.Drawing.Size(461, 27);
            this.inFirstName.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birth-Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "First Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(336, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(547, 40);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserName.Location = new System.Drawing.Point(588, 99);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 20);
            this.lbUserName.TabIndex = 39;
            // 
            // CuProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 729);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.inBirthDate);
            this.Controls.Add(this.inEmail);
            this.Controls.Add(this.inPassword);
            this.Controls.Add(this.inLastName);
            this.Controls.Add(this.inFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CuProfile";
            this.Text = "Customer Profile";
            this.Load += new System.EventHandler(this.CuProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker inBirthDate;
        private TextBox inEmail;
        private TextBox inPassword;
        private TextBox inLastName;
        private TextBox inFirstName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnUpdate;
        private Label lbUserName;
    }
}