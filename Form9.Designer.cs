namespace SuperMarket
{
    partial class Card
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
            this.dtCard = new System.Windows.Forms.DataGridView();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.inCoupone = new System.Windows.Forms.TextBox();
            this.btnCoupone = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCard
            // 
            this.dtCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCard.Location = new System.Drawing.Point(83, 244);
            this.dtCard.Name = "dtCard";
            this.dtCard.RowHeadersWidth = 51;
            this.dtCard.RowTemplate.Height = 29;
            this.dtCard.Size = new System.Drawing.Size(611, 227);
            this.dtCard.TabIndex = 0;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(83, 167);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(74, 20);
            this.lbTotalPrice.TabIndex = 1;
            this.lbTotalPrice.Text = "TotalPrice";
            // 
            // inCoupone
            // 
            this.inCoupone.Location = new System.Drawing.Point(476, 190);
            this.inCoupone.Name = "inCoupone";
            this.inCoupone.Size = new System.Drawing.Size(218, 27);
            this.inCoupone.TabIndex = 3;
            // 
            // btnCoupone
            // 
            this.btnCoupone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCoupone.ForeColor = System.Drawing.Color.White;
            this.btnCoupone.Location = new System.Drawing.Point(476, 155);
            this.btnCoupone.Name = "btnCoupone";
            this.btnCoupone.Size = new System.Drawing.Size(218, 29);
            this.btnCoupone.TabIndex = 4;
            this.btnCoupone.Text = "Apply Coupone";
            this.btnCoupone.UseVisualStyleBackColor = false;
            this.btnCoupone.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(736, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Checkout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCoupone);
            this.Controls.Add(this.inCoupone);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.dtCard);
            this.Name = "Card";
            this.Text = "Card";
            this.Load += new System.EventHandler(this.Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtCard;
        private Label lbTotalPrice;
        private TextBox inCoupone;
        private Button btnCoupone;
        private Button button2;
    }
}