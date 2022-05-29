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
    public partial class CustomersList : Form
    {
        Model model = new Model();
        string userName;
        int codePer;
        string codePerStr;
        bool sortOrd;
        public CustomersList()
        {
            InitializeComponent();
            userName = "";
            codePer = -1;
            sortOrd = false;
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {
            dtCustomerList.DataSource = model.getCustomers(sortOrd);
        }

        private void dtCustomerList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dtCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userName = dtCustomerList.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbUsername.Text = userName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(userName == "")
            {
                MessageBox.Show("You didnt select a customer!");
                return;
            }
            if(model.deleteCustomer(userName))
            {
                MessageBox.Show("User deleted successfully!");
                userName = "";
                lbUsername.Text = "";
                dtCustomerList.DataSource = model.getCustomers(sortOrd);
            }
            else
            {
                MessageBox.Show("Error in database!");
            }
        }

        private void btnSortOrders_Click(object sender, EventArgs e)
        {
            sortOrd = !sortOrd;
            if (sortOrd)
                btnSortOrders.BackColor = Color.Red;
            else
                btnSortOrders.BackColor = Color.Green;
            dtCustomerList.DataSource = model.getCustomers(sortOrd);
        }

        private void inPer_TextChanged(object sender, EventArgs e)
        {
            codePerStr = inPer.Text.ToString().Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName == "")
            {
                MessageBox.Show("select a user first");
                return;
            }
            if (codePerStr == "")
            {
                MessageBox.Show("code percentage cant be empty");
                return;
            }
            try
            {
                codePer = int.Parse(codePerStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("enter percentage in integer");
                return;
            }
            if(codePer <= 0 || codePer > 100)
            {
                MessageBox.Show("codePercentage must be between 1 and 100");
                return;
            }
            if(model.addPromoCode(userName, codePer))
            {
                MessageBox.Show("Promo code added successfully");
                userName = "";
                lbUsername.Text = "";
                inPer.Text = "";
            }
            else
            {
                MessageBox.Show("Error Happend in dataBase");
            }
        }
    }
}
