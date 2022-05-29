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
    public partial class Form12 : Form
    {
        string month;
        Model model = new Model();
        public Form12()
        {
            InitializeComponent();
            month = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.month = textBox1.Text;
            dataGridView1.DataSource = model.noCustomersPr(month);
        }
    }
}
