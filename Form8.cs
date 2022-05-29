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
    public partial class PromoCodes : Form
    {
        Model model = new Model();
        public PromoCodes(string userName)
        {
            InitializeComponent();
            dtPromoCodes.DataSource = model.getPromoCodes(userName);
        }

        private void PromoCodes_Load(object sender, EventArgs e)
        {

        }
    }
}
