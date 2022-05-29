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
    public partial class CuProfile : Form
    {
        Model model = new Model();
        string userName;
        public CuProfile(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void CuProfile_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            DataRow customer = model.getUser(userName);
            lbUserName.Text = userName;
            inFirstName.Text = customer["FirstName"].ToString();
            inLastName.Text = customer["LastName"].ToString();
            inPassword.Text = customer["Password"].ToString();
            inEmail.Text = customer["Email"].ToString();
            int year = int.Parse(customer["Year"].ToString());
            int day = int.Parse(customer["Day"].ToString());
            int month = model.monthToDay[customer["Month"].ToString()];
            inBirthDate.Value = new DateTime(year, month, day);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fstName = inFirstName.Text.ToString().Trim();
            string lstName = inLastName.Text.ToString().Trim();
            string email = inEmail.Text.ToString().Trim();
            string password = inPassword.Text.ToString().Trim();
            int birthDay = inBirthDate.Value.Day;
            int birthYear = inBirthDate.Value.Year;
            int birthMonth = inBirthDate.Value.Month;

            if (fstName == "" || lstName == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill the whole form");
                return;
            }
            if (model.updateUser(userName, fstName, lstName, email, password, birthYear, birthMonth, birthDay))
            {
                MessageBox.Show("Data is updated successfully!");
            }
            else
            {
                MessageBox.Show("Error in database!");
            }
            loadData();
        }
    }
}
