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
    public partial class AdminPanal : Form
    {
        Model model = new Model();
        string fstName;
        string lstName;
        string userName;
        int productID;
        float price;
        int quantity;
        int reStockQuantity;
        string productName;
        string category;
        string description;
        string searchName;
        string searchCategory;
        bool reStck;
        public AdminPanal(string fstName,string lstName, string userName)
        {
            InitializeComponent();
            productID = -1;
            reStck = false;
            lbWelcom.Text = $"Welcome {fstName} {lstName}";
            this.userName = userName;
            display();
        }

        void display()
        {
            dtProducts.DataSource = model.getProducts(searchName, searchCategory, reStck);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPanal_Load(object sender, EventArgs e)
        {
            lbPid.Text = "";

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(productID != -1)
            {
                MessageBox.Show("Clear the selection first then add a new product");
                return;
            }
            productName = inPdName.Text.ToString().Trim();
            string priceStr = inPrice.Text.ToString().Trim();
            string qtStr = inQt.Text.ToString().Trim();
            string resQtStr = inReQt.Text.ToString().Trim();
            description = inDescp.Text.ToString().Trim();
            category = inCategory.Text.ToString().Trim();   
            if(productName == ""|| priceStr =="" || qtStr == "" || resQtStr == "" || description == "" || category == "")
            {
                MessageBox.Show("Please fill the whole form");
                return;
            }
            try
            {
                price = float.Parse(priceStr);
            } catch(Exception ex)
            {
                MessageBox.Show("Price must be a float");
                return;
            }
            try { quantity = int.Parse(qtStr); } 
            catch(Exception ex) {
                MessageBox.Show("quantity must be an integer");
                return;
              }
            try { reStockQuantity = int.Parse(resQtStr); }
            catch (Exception ex)
            {
                MessageBox.Show("restock quantity must be an integer");
                return;
            }
            if (model.addProduct(productName, description, category, price, quantity, reStockQuantity))
            {
                MessageBox.Show("Product Added successfuly");
                display();
                clear();
            }
            else
                MessageBox.Show("Error in database");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            reStck = !reStck;
            if (reStck) btnRestock.BackColor = Color.Red;
            else btnRestock.BackColor =Color.Green;
            display();
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

        private void dtProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbPid.Text = dtProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            productID = int.Parse(lbPid.Text.ToString());

            inPrice.Text = dtProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            inQt.Text = dtProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            inPdName.Text = dtProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            inReQt.Text = dtProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            inDescp.Text = dtProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            inCategory.Text = dtProducts.Rows[e.RowIndex].Cells[6].Value.ToString();


        }
        void clear()
        {

            lbPid.Text = "";
            productID = -1;

            inPrice.Text = "";
            inQt.Text = "";
            inPdName.Text = "";
            inReQt.Text = "";
            inDescp.Text = "";
            inCategory.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
  
        private void btnUpdatePd_Click(object sender, EventArgs e)
        {
            if (productID == -1)
            {
                MessageBox.Show("Select a product first");
                return;
            }
            productName = inPdName.Text.ToString().Trim();
            string priceStr = inPrice.Text.ToString().Trim();
            string qtStr = inQt.Text.ToString().Trim();
            string resQtStr = inReQt.Text.ToString().Trim();
            description = inDescp.Text.ToString().Trim();
            category = inCategory.Text.ToString().Trim();
            if (productName == "" || priceStr == "" || qtStr == "" || resQtStr == "" || description == "" || category == "")
            {
                MessageBox.Show("Please fill the whole form for update");
                return;
            }
            try
            {
                price = float.Parse(priceStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Price must be a float");
                return;
            }
            try { quantity = int.Parse(qtStr); }
            catch (Exception ex)
            {
                MessageBox.Show("quantity must be an integer");
                return;
            }
            try { reStockQuantity = int.Parse(resQtStr); }
            catch (Exception ex)
            {
                MessageBox.Show("restock quantity must be an integer");
                return;
            }
            if (model.updateProduct(productID, productName, description, category, price, quantity, reStockQuantity))
            {
                MessageBox.Show("Product updated successfully");
                clear();
                display();
            }
            else
            {
                MessageBox.Show("error  in database");
            }
        }

        private void btnShowCustmrs_Click(object sender, EventArgs e)
        {
            Form customerList = new CustomersList();
            customerList.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Form adminProfile = new AdminProfile(userName);
            adminProfile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form11();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form = new Form12();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form13();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form14();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form15();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form16();
            form.Show();
        }
    }
}
