namespace SuperMarket
{
    partial class CustomersList
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
            this.dtCustomerList = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.inPer = new System.Windows.Forms.TextBox();
            this.btnSortOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCustomerList
            // 
            this.dtCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCustomerList.Location = new System.Drawing.Point(30, 298);
            this.dtCustomerList.Name = "dtCustomerList";
            this.dtCustomerList.RowHeadersWidth = 51;
            this.dtCustomerList.RowTemplate.Height = 29;
            this.dtCustomerList.Size = new System.Drawing.Size(1262, 253);
            this.dtCustomerList.TabIndex = 0;
            this.dtCustomerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCustomerList_CellDoubleClick);
            this.dtCustomerList.DoubleClick += new System.EventHandler(this.dtCustomerList_DoubleClick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(30, 56);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(143, 20);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Customer username:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(190, 56);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 20);
            this.lbUsername.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(30, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inPer
            // 
            this.inPer.Location = new System.Drawing.Point(946, 246);
            this.inPer.Name = "inPer";
            this.inPer.Size = new System.Drawing.Size(149, 27);
            this.inPer.TabIndex = 3;
            this.inPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inPer.TextChanged += new System.EventHandler(this.inPer_TextChanged);
            // 
            // btnSortOrders
            // 
            this.btnSortOrders.BackColor = System.Drawing.Color.Green;
            this.btnSortOrders.ForeColor = System.Drawing.Color.White;
            this.btnSortOrders.Location = new System.Drawing.Point(201, 240);
            this.btnSortOrders.Name = "btnSortOrders";
            this.btnSortOrders.Size = new System.Drawing.Size(116, 38);
            this.btnSortOrders.TabIndex = 4;
            this.btnSortOrders.Text = "Sort Orders";
            this.btnSortOrders.UseVisualStyleBackColor = false;
            this.btnSortOrders.Click += new System.EventHandler(this.btnSortOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Percentage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1101, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Promo Code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortOrders);
            this.Controls.Add(this.inPer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dtCustomerList);
            this.Name = "CustomersList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtCustomerList;
        private Label lb1;
        private Label lbUsername;
        private Button btnDelete;
        private TextBox inPer;
        private Button btnSortOrders;
        private Label label1;
        private Button button1;
    }
}