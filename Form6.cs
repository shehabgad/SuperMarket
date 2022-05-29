using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace SuperMarket
{
    public partial class AdminProfile : Form
    {
        Model model = new Model();
        string userName;
        public AdminProfile(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            loadData();
        }
        public void loadData()
        {
            DataRow admin = model.getUser(userName);
            inFirstName.Text = admin["FirstName"].ToString();
            inLastName.Text = admin["LastName"].ToString();
            inPassword.Text = admin["Password"].ToString();
            inEmail.Text = admin["Email"].ToString();
            int year = int.Parse(admin["Year"].ToString());
            int day = int.Parse(admin["Day"].ToString());
            int month = model.monthToDay[admin["Month"].ToString()];
            inBirthDate.Value = new DateTime(year, month, day);
        }
        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void inEmplyNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            if(model.updateAdmin(userName, fstName, lstName, email, password, birthYear, birthMonth, birthDay))
            {
                MessageBox.Show("Data is updated successfully!");
            }
            else
            {
                MessageBox.Show("Error in database!");
            }
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
