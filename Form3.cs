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
    public partial class CustomerReg : Form
    {
        Model model = new Model();
        public CustomerReg()
        {
            InitializeComponent();
        }

        private void CustomerReg_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fstName = inFirstName.Text.ToString().Trim();
            string lstName = inLastName.Text.ToString().Trim();
            string userName = inUserName.Text.ToString().Trim();
            string email = inEmail.Text.ToString().Trim();
            string password = inPassword.Text.ToString().Trim();
            int birthDay = inBirthDate.Value.Day;
            int birthYear = inBirthDate.Value.Year;
            int birthMonth = inBirthDate.Value.Month;

            int closingYear = inClsDate.Value.Year;
            int closingMonth = inClsDate.Value.Month;
            string cardNumber = inCdNum.Text.ToString().Trim();
            string cvv = inCVV.Text.ToString().Trim();
            if (fstName == "" || lstName == "" || userName == "" || email == "" || cvv == "" || password == "" || cardNumber == "")
            {
                MessageBox.Show("Please fill the whole form");
            }
            else
            {
                if (!model.uniqueUserName(userName))
                {
                    MessageBox.Show("This username already exists");
                    return;
                }
                if (!model.uniqueEmail(email))
                {
                    MessageBox.Show("This Email already exists!!");
                    return;
                }
                if(!model.addNewCustomer(userName, cardNumber, cvv, closingYear, closingMonth, fstName, lstName, password, email, birthYear, birthMonth, birthDay))
                {
                    MessageBox.Show("Some error occured in Database!");
                    return;
                }
                Form cuPanal = new CuPanal(fstName, lstName, userName);
                this.Hide();
                cuPanal.Show();
            }
        }
    }
}
