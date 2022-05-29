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
    public partial class Card : Form
    {
        DataTable card;
        string userName;
        float totalPrice;
        Model model = new Model();
        static int discount = 0;
        public Card(string userName, DataTable card)
        {
            InitializeComponent();
            this.userName = userName;
            this.card = card;
            totalPrice = 0;
        }

        void calculateTotalPrice(int discount)
        {
            totalPrice = 0;
            foreach (DataRow row in card.Rows)
            {
                float price = float.Parse(row["Price"].ToString());
                totalPrice += price - (((float)discount/100) * price);
            }

        }
        private void Card_Load(object sender, EventArgs e)
        {
            calculateTotalPrice(discount);
            lbTotalPrice.Text = $"Total Price: {totalPrice}";
            dtCard.DataSource = card;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string promoCode = inCoupone.Text.ToString().ToLower();
            if(promoCode == "") return;
            int pdiscount = model.getPromoCode(promoCode);
            if(pdiscount == -1)
            {
                MessageBox.Show("There is no such promo code");
                return;
            }
            discount += pdiscount;
            calculateTotalPrice(discount);
            lbTotalPrice.Text = $"Total Price: {totalPrice}";
            MessageBox.Show($"Promo Code is Applied with {pdiscount}% discount, the new total price is {totalPrice}");
            model.deletePromoCode(promoCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(model.addOrder(userName, card, totalPrice))
            {
                MessageBox.Show("checkout is successfull");
                card.Clear();
                CuPanal.card.Clear();
                Card_Load(sender, e);
            } else
            {
                MessageBox.Show("checkout failed");
            }
        }
    }
}
