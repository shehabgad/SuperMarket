namespace SuperMarket
{
    partial class PromoCodes
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
            this.dtPromoCodes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPromoCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPromoCodes
            // 
            this.dtPromoCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPromoCodes.Location = new System.Drawing.Point(53, 46);
            this.dtPromoCodes.Name = "dtPromoCodes";
            this.dtPromoCodes.RowHeadersWidth = 51;
            this.dtPromoCodes.RowTemplate.Height = 29;
            this.dtPromoCodes.Size = new System.Drawing.Size(526, 313);
            this.dtPromoCodes.TabIndex = 0;
            // 
            // PromoCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 401);
            this.Controls.Add(this.dtPromoCodes);
            this.Name = "PromoCodes";
            this.Text = "PromoCodes";
            this.Load += new System.EventHandler(this.PromoCodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPromoCodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtPromoCodes;
    }
}