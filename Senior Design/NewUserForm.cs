using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

namespace Senior_Design
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
            lblError.Hide();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAcct_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            string rePassword;
            string phone_number = null;
            string email = null;

            username = this.txtUsername.Text;
            password = this.txtPassword.Text;
            rePassword = this.txtRePassword.Text;
            phone_number = this.txtPhone.Text;
            email = this.txtEmail.Text;

            //verify matching passwords
            if (password != rePassword)
            {
                lblError.Show();
                lblError.Text = "Passwords do not match";
            }

     
            bool verify = ReadUsernames(username);
            if (verify)
            {
                //encrypt password and email
                string Epass = Helper.ComputeHash(password, "SHA512", null);
                string Eemail = Helper.ComputeHash(email, "SHA512", null);
                string Ephone = Helper.ComputeHash(phone_number, "SHA512", null);



                //create new user acct
                string userCount = "SELECT COUNT(id) FROM users";
                ConnectionDB newID = new ConnectionDB();
                newID.OpenConnection();
                int newUserID = newID.ExecuteScalar(userCount);
                newID.CloseConnection();

                string newIDQuery = "INSERT INTO users(id, username, phone_number, email, password, approved)" +
                    " VALUES ('" + newUserID + "', '" + username + "', '" + phone_number + "', '" + email + "', '" + password + "', NULL)";
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                connectionDB.ExecuteQueries(newIDQuery);
                connectionDB.CloseConnection();

                //dialogue box confirming acct creation
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("New account created. Please log in from the main menu.");
                DialogResult confirmAcct = MessageBox.Show(sb.ToString(), "Account Created", MessageBoxButtons.OK);
                this.Close();
                MainMenu mainmenu = new MainMenu();
                mainmenu.Show();
            }
            else
            {
                lblError.Show();
                lblError.Text = "Username taken";
            }

           
        }

      
        bool ReadUsernames(string username)

        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            SqlDataReader dr = connectionDB.DataReader("SELECT username FROM users");    
            var usernames = new List<string>();           
            while(dr.Read())
            {
              usernames.Add(dr["username"].ToString());
            }
            for(int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i] == username)
                    return false;
            }
            return true;
        }
      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
