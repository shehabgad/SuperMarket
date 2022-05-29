using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SuperMarket
{
    internal class Model
    {
        public Dictionary<int, string> month;
        public Dictionary<string, int> monthToDay;
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4KS522C;Initial Catalog=SuperMarket;Integrated Security=True");
        public Model()
        {
            month = new Dictionary<int, string>();
            monthToDay = new Dictionary<string, int>();
            month[1] = "January";
            month[2] = "February";
            month[3] = "March";
            month[4] = "April";
            month[5] = "May";
            month[6] = "June";
            month[7] = "July";
            month[8] = "August";
            month[9] = "September";
            month[10] = "October";
            month[11] = "November";
            month[12] = "December";

            monthToDay["January"] = 1;
            monthToDay["February"] = 2;
            monthToDay["March"] = 3;
            monthToDay["April"] = 4;
            monthToDay["May"] = 5;
            monthToDay["June"] = 6;
            monthToDay["July"] = 7;
            monthToDay["August"] = 8;
            monthToDay["September"] = 9;
            monthToDay["October"] = 10;
            monthToDay["November"] = 11;
            monthToDay["December"] = 12;
        }
        public DataRow getUser(string userName,string password)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter($"SELECT * FROM [User] WHERE UserName='{userName}' AND Password='{password}'", conn);
            sdp.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 0) return null;
            return dt.Rows[0];
        }
        public bool updateAdmin(string userName, string firstName, string lastName, string email, string password, int year, int monthi, int day)
        {
            try
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand($"UPDATE [User] SET " +
                    $"FirstName = '{firstName}'," +
                    $"LastName = '{lastName}'," +
                    $"Email = '{email}'," +
                    $"Password = '{password}'," +
                    $"Year = {year}," +
                    $"Month = '{month[monthi]}'," +
                    $"Day = {day}" +
                    $"WHERE UserName = '{userName}'", conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }
        public DataRow getUser(string userName)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter($"SELECT * FROM [User] WHERE UserName='{userName}'", conn);
            sdp.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 0) return null;
            return dt.Rows[0];
        }
        public bool uniqueUserName(string userName)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter($"SELECT UserName FROM [User] WHERE UserName='{userName}'", conn);
            sdp.Fill(dt);
            conn.Close();
            return dt.Rows.Count == 0;
        }
        public bool uniqueEmail(string email)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter($"SELECT email FROM [User] WHERE email='{email}'", conn);
            sdp.Fill(dt);
            conn.Close();
            
            return dt.Rows.Count == 0;
        }
        public bool uniqueEmpNum(int empNum)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter($"SELECT EmplyNumber FROM [Admin] WHERE EmplyNumber={empNum}", conn);
            sdp.Fill(dt);
            conn.Close();
            return dt.Rows.Count == 0;
        }
        public bool addPromoCode(string useName, int percentage)
        {
            string promoCode = this.randomPromoCode();
            conn.Open();
            try
            {
                SqlCommand cmnd = new SqlCommand($"INSERT INTO PromoCode VALUES('{promoCode}','{percentage}','{useName}')", conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
            } catch(Exception ex)
            {
                conn.Close();
                return false;
            }
            return true;
        }
        public DataTable getCustomers(bool srtOrders)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "";
            if (srtOrders)
                query = "SELECT A.FirstName, A.LastName, A.UserName, A.Email, A.Year, A.Month, A.Day, B.NOrders FROM [User] as A, Customer as B WHERE A.UserName = B.Cu_UserName ORDER BY B.NOrders DESC";
            else
                query = "SELECT A.FirstName, A.LastName, A.UserName, A.Email, A.Year, A.Month, A.Day, B.NOrders FROM [User] as A, Customer as B WHERE A.UserName = B.Cu_UserName";
            SqlDataAdapter sdp = new SqlDataAdapter(query, conn);
            sdp.Fill(dt);
            conn.Close();
            return dt;

        }
        public bool deleteCustomer(string userName)
        {
            conn.Open();
            try
            {

                SqlCommand cmnd = new SqlCommand($"DELETE FROM PromoCode WHERE Cu_UserName = '{userName}'", conn);
                cmnd.ExecuteNonQuery();
                cmnd = new SqlCommand($"DELETE FROM [User] WHERE UserName = '{userName}'", conn);
                cmnd.ExecuteNonQuery();
                cmnd = new SqlCommand($"DELETE FROM Customer WHERE Cu_UserName = '{userName}'", conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
            } 
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public string randomPromoCode()
        {
            Random rand = new Random();
            const string promo_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(promo_chars, 15)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
        public bool addNewAdmin(string userName, int empNum, string fstName, string lstName, string password, string email, int birthYear, int birthMonth, int birthDay)
        {
            try
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand("INSERT INTO Admin(Ad_UserName,EmplyNumber) VALUES('" + userName + "', '" + empNum + "')", conn);
                cmnd.ExecuteNonQuery();
                cmnd = new SqlCommand($"INSERT INTO [User] VALUES ('{fstName}','{lstName}','{password}','{userName}','{email}',{birthYear}, '{month[birthMonth]}', {birthDay}, 'ADMIN')",conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
            }
            catch(SqlException ex)
            {
                conn.Close();
                return false;
            }
            return true;
        }
        public DataTable getProducts(string name, string category,bool restock)
        {
            conn.Open();
            DataTable dt = new DataTable();
            if(restock)
            {
                SqlDataAdapter sdp = new SqlDataAdapter($"SELECT A.ProductID,A.Price,A.Quantity,A.Name,A.ReStock_Qt,A.Description, A.Category FROM Product A, Product B WHERE A.ProductID = B.ProductID AND A.Quantity <= B.ReStock_Qt AND A.Name LIKE '%{name}%' AND A.Category LIKE '%{category}%';", conn);
                sdp.Fill(dt);
            }
            else
            {
                SqlDataAdapter sdp = new SqlDataAdapter($"SELECT * FROM Product WHERE Name Like '%{name}%' AND Category Like '%{category}%'", conn);
                sdp.Fill(dt);
            }
         
            conn.Close();
            return dt;
        }
        public bool updateProduct(int pid,string name, string description, string category, float price, int quantity, int restockQt)
        {
            conn.Open();
            try
            {
                SqlCommand cmnd = new SqlCommand($"UPDATE Product " +
                    $"SET Price = {price}," +
                    $"Quantity = {quantity}," +
                    $"Name = '{name}'," +
                    $"ReStock_Qt = {restockQt}," +
                    $"Description = '{description}'," +
                    $"Category = '{category}'" +
                    $"WHERE ProductID = {pid}", conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
            }
           catch(Exception ex)
           {
              conn.Close();
              return false;
            }
            return true;
        }
        public bool addProduct(string name, string description, string category, float price, int quantity, int restockQt)
        {
            conn.Open();
            try
            {
                SqlCommand cmnd = new SqlCommand($"INSERT INTO Product(Price,Quantity,Name,ReStock_Qt,Description" +
                    $",Category) VALUES({price},{quantity},'{name}',{restockQt},'{description}','{category}')", conn);
                cmnd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }
        public bool addNewCustomer(string userName, string cardNumber, string cvv, int clsYear,int clsMonth, string fstName, string lstName, string password, string email, int birthYear, int birthMonth, int birthDay)
        {

            try
            {
                conn.Open();
                SqlCommand cmnd = new SqlCommand($"INSERT INTO Customer VALUES(0,'{cardNumber}','{cvv}',{clsYear},{clsMonth},'{userName}')", conn);
                cmnd.ExecuteNonQuery();
                cmnd = new SqlCommand($"INSERT INTO [User] VALUES ('{fstName}','{lstName}','{password}','{userName}','{email}',{birthYear}, '{month[birthMonth]}', {birthDay}, 'CUSTOMER')", conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                return false;
            }
            return true;
        }
    }
}
