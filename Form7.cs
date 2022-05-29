using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
  
    public partial class CuPanal : Form
    {
        string searchName;
        string searchCategory;
        float price;
        int quantity;
        int productID;
        string productName;
        float totalPrice;
        Model model = new Model();
        string userName;
        public static DataTable card = new DataTable();
    
        public CuPanal(string firstName, string lastName, string userName)
        {
            InitializeComponent();
            lbWelcom.Text = $"Welcome {firstName} {lastName}";
            productID = -1;
            quantity = -1;
            price = -1;
            this.userName = userName;
            card.Columns.Add("ID");
            card.Columns.Add("Name");
            card.Columns.Add("Price");
            card.Columns.Add("Quantity");
            display();
        }
        public void display()
        {
            dtProducts.DataSource = model.getProducts(searchName, searchCategory);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form cuProfile = new CuProfile(userName);
            cuProfile.Show();
        }

        private void CuPanal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form cardFrm = new Card(userName,card);
            cardFrm.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void inSCtgry_TextChanged(object sender, EventArgs e)
        {
            searchCategory = inSCtgry.Text.ToString().Trim();
            display();
        }

        private void inSName_TextChanged(object sender, EventArgs e)
        {
            searchName = inSName.Text.ToString().Trim();
            display();
        }
        void clear()
        {
            lbName.Text = $"Name:";
            lbPrice.Text = $"Price:";
            lbCategory.Text = $"Category:";
            lbDes.Text = $"Description:";
            productID = -1;
            quantity = -1;
            price = -1;
        }
        private void dtProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbName.Text = $"Name: {dtProducts.Rows[e.RowIndex].Cells[1].Value.ToString()}";
            productName = dtProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbPrice.Text = $"Price: {dtProducts.Rows[e.RowIndex].Cells[2].Value}";
            lbCategory.Text = $"Category: {dtProducts.Rows[e.RowIndex].Cells[3].Value.ToString()}";
            lbDes.Text = $"Description: {dtProducts.Rows[e.RowIndex].Cells[4].Value.ToString()}";
            productID = int.Parse(dtProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
            price = float.Parse(dtProducts.Rows[e.RowIndex].Cells[2].Value.ToString());
            quantity = 1;
            inQt.Text = "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string qtStr = inQt.Text.ToString().Trim();
            if (qtStr == "") return;
            try
            {
                quantity = int.Parse(qtStr);
            } catch(Exception ex)
            {
                return;
            }
            if (price != -1)
            {
                totalPrice = (price * quantity);
                lbPrice.Text = $"Price: {totalPrice}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form promoCodes = new PromoCodes(userName);
            promoCodes.Show();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            if (productID == -1)
            {
                MessageBox.Show("Select a product");
                return;
            };
            DataRow item = card.NewRow();
            foreach (DataRow row in card.Rows)
            {
                if (int.Parse(row["ID"].ToString()) == productID)
                {
                    int qt2 = int.Parse(row["Quantity"].ToString()) + quantity;
                    row["Quantity"] = qt2;

                    float tp2 = float.Parse(row["Price"].ToString()) + totalPrice;
                    row["Price"] = tp2;
                    MessageBox.Show("product added to card !!");
                    clear();
                    return;
                }
            }
            item["ID"] = productID;
            item["Name"] = productName;
            item["Price"] = totalPrice;
            item["Quantity"] = quantity;
            card.Rows.Add(item);
            MessageBox.Show("product added to card !!");
            clear();
        }
    }
}
