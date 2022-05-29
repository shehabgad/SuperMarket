namespace SuperMarket
{
    partial class CuPanal
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
            this.btnUpdateProfie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inSCtgry = new System.Windows.Forms.TextBox();
            this.inSName = new System.Windows.Forms.TextBox();
            this.dtProducts = new System.Windows.Forms.DataGridView();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbWelcom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inQt = new System.Windows.Forms.TextBox();
            this.btnPurchaseList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateProfie
            // 
            this.btnUpdateProfie.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateProfie.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfie.Location = new System.Drawing.Point(30, 35);
            this.btnUpdateProfie.Name = "btnUpdateProfie";
            this.btnUpdateProfie.Size = new System.Drawing.Size(198, 53);
            this.btnUpdateProfie.TabIndex = 0;
            this.btnUpdateProfie.Text = "Update Profile";
            this.btnUpdateProfie.UseVisualStyleBackColor = false;
            this.btnUpdateProfie.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Card";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "PromoCodes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(957, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Search by Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1187, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Search by Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // inSCtgry
            // 
            this.inSCtgry.Location = new System.Drawing.Point(906, 298);
            this.inSCtgry.Name = "inSCtgry";
            this.inSCtgry.Size = new System.Drawing.Size(241, 27);
            this.inSCtgry.TabIndex = 10;
            this.inSCtgry.TextChanged += new System.EventHandler(this.inSCtgry_TextChanged);
            // 
            // inSName
            // 
            this.inSName.Location = new System.Drawing.Point(1153, 298);
            this.inSName.Name = "inSName";
            this.inSName.Size = new System.Drawing.Size(213, 27);
            this.inSName.TabIndex = 11;
            this.inSName.TextChanged += new System.EventHandler(this.inSName_TextChanged);
            // 
            // dtProducts
            // 
            this.dtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProducts.Location = new System.Drawing.Point(366, 336);
            this.dtProducts.Name = "dtProducts";
            this.dtProducts.RowHeadersWidth = 51;
            this.dtProducts.RowTemplate.Height = 29;
            this.dtProducts.Size = new System.Drawing.Size(1000, 258);
            this.dtProducts.TabIndex = 9;
            this.dtProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProducts_CellDoubleClick);
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.Color.Blue;
            this.btnAddCard.ForeColor = System.Drawing.Color.White;
            this.btnAddCard.Location = new System.Drawing.Point(746, 296);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(154, 29);
            this.btnAddCard.TabIndex = 14;
            this.btnAddCard.Text = "Add to Card";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(680, 126);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 20);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(680, 157);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(69, 20);
            this.lbCategory.TabIndex = 19;
            this.lbCategory.Text = "Category";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Location = new System.Drawing.Point(680, 89);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(88, 20);
            this.lbDes.TabIndex = 21;
            this.lbDes.Text = "Description:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(456, 89);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 22;
            this.lbPrice.Text = "Price: ";
            // 
            // lbWelcom
            // 
            this.lbWelcom.AutoSize = true;
            this.lbWelcom.Location = new System.Drawing.Point(784, 9);
            this.lbWelcom.Name = "lbWelcom";
            this.lbWelcom.Size = new System.Drawing.Size(71, 20);
            this.lbWelcom.TabIndex = 24;
            this.lbWelcom.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantity";
            // 
            // inQt
            // 
            this.inQt.Location = new System.Drawing.Point(527, 150);
            this.inQt.Name = "inQt";
            this.inQt.Size = new System.Drawing.Size(125, 27);
            this.inQt.TabIndex = 25;
            this.inQt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPurchaseList
            // 
            this.btnPurchaseList.BackColor = System.Drawing.Color.Blue;
            this.btnPurchaseList.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseList.Location = new System.Drawing.Point(30, 384);
            this.btnPurchaseList.Name = "btnPurchaseList";
            this.btnPurchaseList.Size = new System.Drawing.Size(198, 38);
            this.btnPurchaseList.TabIndex = 26;
            this.btnPurchaseList.Text = "Purchase List";
            this.btnPurchaseList.UseVisualStyleBackColor = false;
            // 
            // CuPanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 613);
            this.Controls.Add(this.btnPurchaseList);
            this.Controls.Add(this.inQt);
            this.Controls.Add(this.lbWelcom);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inSCtgry);
            this.Controls.Add(this.inSName);
            this.Controls.Add(this.dtProducts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateProfie);
            this.Name = "CuPanal";
            this.Text = "Customer Panal";
            this.Load += new System.EventHandler(this.CuPanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdateProfie;
        private Button button1;
        private Button button2;
        private Label label9;
        private Label label8;
        private TextBox inSCtgry;
        private TextBox inSName;
        private DataGridView dtProducts;
        private Button btnAddCard;
        private Label lbName;
        private Label lbCategory;
        private Label lbDes;
        private Label lbPrice;
        private Label lbWelcom;
        private Label label1;
        private TextBox inQt;
        private Button btnPurchaseList;
    }
}