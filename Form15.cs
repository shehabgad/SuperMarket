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
    public partial class Form15 : Form
    {
        Model model = new Model();
        string cat1;
        string cat2;
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cat1 = textBox1.Text;
            dataGridView1.DataSource = model.categoryCompare(cat1, cat2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cat2 = textBox2.Text;
            dataGridView1.DataSource = model.categoryCompare(cat1, cat2);
        }
    }
}
