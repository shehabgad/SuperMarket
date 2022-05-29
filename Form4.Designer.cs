namespace SuperMarket
{
    partial class AdminPanal
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
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnShowCustmrs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtProducts = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.lbPid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inQt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inPdName = new System.Windows.Forms.TextBox();
            this.inReQt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inDescp = new System.Windows.Forms.TextBox();
            this.btnUpdatePd = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.inSCtgry = new System.Windows.Forms.TextBox();
            this.inSName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbWelcom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(55, 45);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(157, 46);
            this.btnUpdateProfile.TabIndex = 0;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnShowCustmrs
            // 
            this.btnShowCustmrs.BackColor = System.Drawing.Color.Blue;
            this.btnShowCustmrs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowCustmrs.ForeColor = System.Drawing.Color.White;
            this.btnShowCustmrs.Location = new System.Drawing.Point(55, 366);
            this.btnShowCustmrs.Name = "btnShowCustmrs";
            this.btnShowCustmrs.Size = new System.Drawing.Size(157, 46);
            this.btnShowCustmrs.TabIndex = 0;
            this.btnShowCustmrs.Text = "Show Customers";
            this.btnShowCustmrs.UseVisualStyleBackColor = false;
            this.btnShowCustmrs.Click += new System.EventHandler(this.btnShowCustmrs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnShowCustmrs);
            this.panel1.Controls.Add(this.btnUpdateProfile);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 663);
            this.panel1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 427);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 29);
            this.button6.TabIndex = 1;
            this.button6.Text = "full product info";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(55, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "category compare";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "highestPurchase";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "customer didnt buy since1 year";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "no customers month";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "most bought";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtProducts
            // 
            this.dtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProducts.Location = new System.Drawing.Point(330, 311);
            this.dtProducts.Name = "dtProducts";
            this.dtProducts.RowHeadersWidth = 51;
            this.dtProducts.RowTemplate.Height = 29;
            this.dtProducts.Size = new System.Drawing.Size(896, 354);
            this.dtProducts.TabIndex = 2;
            this.dtProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProducts_CellContentClick);
            this.dtProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProducts_CellDoubleClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(330, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 20);
            this.label.TabIndex = 3;
            this.label.Text = "Product ID: ";
            // 
            // lbPid
            // 
            this.lbPid.AutoSize = true;
            this.lbPid.Location = new System.Drawing.Point(422, 73);
            this.lbPid.Name = "lbPid";
            this.lbPid.Size = new System.Drawing.Size(79, 20);
            this.lbPid.TabIndex = 3;
            this.lbPid.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price: ";
            // 
            // inPrice
            // 
            this.inPrice.Location = new System.Drawing.Point(404, 103);
            this.inPrice.Name = "inPrice";
            this.inPrice.Size = new System.Drawing.Size(125, 27);
            this.inPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inQt
            // 
            this.inQt.Location = new System.Drawing.Point(404, 152);
            this.inQt.Name = "inQt";
            this.inQt.Size = new System.Drawing.Size(125, 27);
            this.inQt.TabIndex = 4;
            this.inQt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Restock quantity";
            // 
            // inPdName
            // 
            this.inPdName.Location = new System.Drawing.Point(739, 106);
            this.inPdName.Name = "inPdName";
            this.inPdName.Size = new System.Drawing.Size(125, 27);
            this.inPdName.TabIndex = 4;
            // 
            // inReQt
            // 
            this.inReQt.Location = new System.Drawing.Point(454, 193);
            this.inReQt.Name = "inReQt";
            this.inReQt.Size = new System.Drawing.Size(125, 27);
            this.inReQt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Category";
            // 
            // inCategory
            // 
            this.inCategory.Location = new System.Drawing.Point(739, 141);
            this.inCategory.Name = "inCategory";
            this.inCategory.Size = new System.Drawing.Size(125, 27);
            this.inCategory.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Description:";
            // 
            // inDescp
            // 
            this.inDescp.Location = new System.Drawing.Point(739, 73);
            this.inDescp.Name = "inDescp";
            this.inDescp.Size = new System.Drawing.Size(487, 27);
            this.inDescp.TabIndex = 4;
            // 
            // btnUpdatePd
            // 
            this.btnUpdatePd.BackColor = System.Drawing.Color.Blue;
            this.btnUpdatePd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePd.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePd.Location = new System.Drawing.Point(330, 272);
            this.btnUpdatePd.Name = "btnUpdatePd";
            this.btnUpdatePd.Size = new System.Drawing.Size(138, 33);
            this.btnUpdatePd.TabIndex = 0;
            this.btnUpdatePd.Text = "Update";
            this.btnUpdatePd.UseVisualStyleBackColor = false;
            this.btnUpdatePd.Click += new System.EventHandler(this.btnUpdatePd_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.Green;
            this.btnRestock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Location = new System.Drawing.Point(495, 272);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(138, 33);
            this.btnRestock.TabIndex = 0;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Blue;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(654, 272);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(138, 33);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // inSCtgry
            // 
            this.inSCtgry.Location = new System.Drawing.Point(814, 275);
            this.inSCtgry.Name = "inSCtgry";
            this.inSCtgry.Size = new System.Drawing.Size(195, 27);
            this.inSCtgry.TabIndex = 4;
            this.inSCtgry.TextChanged += new System.EventHandler(this.inSCtgry_TextChanged);
            // 
            // inSName
            // 
            this.inSName.Location = new System.Drawing.Point(1031, 275);
            this.inSName.Name = "inSName";
            this.inSName.Size = new System.Drawing.Size(195, 27);
            this.inSName.TabIndex = 4;
            this.inSName.TextChanged += new System.EventHandler(this.inSName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1069, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Search by Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(835, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Search by Category";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(739, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbWelcom
            // 
            this.lbWelcom.AutoSize = true;
            this.lbWelcom.Location = new System.Drawing.Point(703, 9);
            this.lbWelcom.Name = "lbWelcom";
            this.lbWelcom.Size = new System.Drawing.Size(71, 20);
            this.lbWelcom.TabIndex = 1;
            this.lbWelcom.Text = "Welcome";
            this.lbWelcom.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminPanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 678);
            this.Controls.Add(this.lbWelcom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inQt);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRestock);
            this.Controls.Add(this.btnUpdatePd);
            this.Controls.Add(this.inCategory);
            this.Controls.Add(this.inSCtgry);
            this.Controls.Add(this.inSName);
            this.Controls.Add(this.inReQt);
            this.Controls.Add(this.inDescp);
            this.Controls.Add(this.inPdName);
            this.Controls.Add(this.inPrice);
            this.Controls.Add(this.lbPid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dtProducts);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanal";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.AdminPanal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdateProfile;
        private Button btnShowCustmrs;
        private Panel panel1;
        private DataGridView dtProducts;
        private Label label;
        private Label lbPid;
        private Label label2;
        private TextBox inPrice;
        private Label label3;
        private TextBox inQt;
        private Label label4;
        private TextBox inPdName;
        private TextBox inReQt;
        private Label label5;
        private Label label7;
        private TextBox inCategory;
        private Label label6;
        private TextBox inDescp;
        private Button btnUpdatePd;
        private Button btnRestock;
        private Button btnAddNew;
        private TextBox inSCtgry;
        private TextBox inSName;
        private Label label8;
        private Label label9;
        private Label lbWelcom;
        private Button btnClear;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}