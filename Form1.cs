using System.Data;
namespace SuperMarket
{
    public partial class Home : Form
    {
        Model model = new Model();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnRegCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form cusReg = new CustomerReg();
            cusReg.Show();
        }

        private void btnRegAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form admReg = new AdminRgs();
            admReg.Show();
        }

        private void inPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = inUserName.Text.ToString().Trim();
            string password = inPassword.Text.ToString().Trim();   
            if(userName == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            DataRow user = model.getUser(userName,password);
            if(user == null)
            {
                MessageBox.Show("username or password are incorrect");
                return;
            }
            this.Hide();
            if (user["UserType"].ToString() == "ADMIN")
            {
                Form adminPanal = new AdminPanal(user["FirstName"].ToString(), user["LastName"].ToString(),userName);
                adminPanal.Show();
            }
            else
            {
           
            }

        }
    }
}