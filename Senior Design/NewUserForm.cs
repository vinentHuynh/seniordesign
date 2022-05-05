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

            username = this.textBox1.Text;
            password = this.textBox2.Text;
            rePassword = this.textBox3.Text;


            //verify matching passwords
            if (password != rePassword)
            {
                lblError.Show();
                lblError.Text = "Passwords do not match";
            }

            //loop through users in database ->
            //compare new username, error msg if not unique
            bool verify = ReadUsernames(username);
            if (verify)
            {
                //create new user acct
                string query = "INSERT INTO users(id, username, phone_number, email) " +
                    "VALUES (6, '" + username + "', NULL, NULL)" ;
                CreateAcct(query);

                //temp
                lblError.Show();
                lblError.Text = "New account created. Return to log in";
            }
            else
            {
                lblError.Show();
                lblError.Text = "Username taken";
            }

   
        }

      
        bool ReadUsernames(string username)
        {
            bool verify = true;

            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();           
                        
            int userCount = connectionDB.rowCount("SELECT COUNT(username) FROM users");        

            SqlDataReader dr = connectionDB.DataReader("SELECT username FROM users"); //test; change for usernames 

            //loop through names, check if desired acct name already exists
            int count = 0;
            while(dr.Read())
            {
                
                string name = dr.GetString(count);
                if (name == username)
                {
                    verify = false;
                }
                else
                    verify = true;

                count++;
            }
            dr.Close();
            return verify;   
        }

        void CreateAcct(string query)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            connectionDB.ExecuteQueries(query);
            connectionDB.CloseConnection();
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
    }
}
