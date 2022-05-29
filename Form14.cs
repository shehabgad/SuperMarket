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
    public partial class Form14 : Form
    {
        Model model = new Model();
        string month;
        public Form14()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string monthStr = textBox1.Text;
            dataGridView1.DataSource = model.highestPurchaseCustomer(monthStr);
        }
    }
}
