using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SuperMarket
{
    public partial class AdminRgs : Form
    {
        Model model = new Model();
        public AdminRgs()
        {
            InitializeComponent();
        }

        private void AdminRgs_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fstName = inFirstName.Text.ToString().Trim();
            string lstName = inLastName.Text.ToString().Trim();
            string userName = inUserName.Text.ToString().Trim();
            string email = inEmail.Text.ToString().Trim();
            string empNumStr = inEmplyNumber.Text.ToString().Trim();
            string password = inPassword.Text.ToString().Trim();
            int birthDay = inBirthDate.Value.Day;
            int birthYear = inBirthDate.Value.Year;
            int birthMonth = inBirthDate.Value.Month;
           
            if(fstName == "" || lstName == "" || userName == "" || email == "" || empNumStr == "" || password == "")
            {
                MessageBox.Show("Please fill the whole form");
            }
            else
            {

                try
                {
                    int empNum = int.Parse(empNumStr);
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
                    if (!model.uniqueEmpNum(empNum))
                    {
                        MessageBox.Show("This employment number already exists!!");
                        return;
                    }
                    if (!model.addNewAdmin(userName, empNum, fstName, lstName, password, email, birthYear, birthMonth, birthDay))
                    {
                        MessageBox.Show("Some error occured in Database!");
                        return;
                    }
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Employment number must be an integer");
                    return;

                }
                Form adminPanal = new AdminPanal(fstName, lstName,userName);
                adminPanal.Show();
                this.Close();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
