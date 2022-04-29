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

            username = this.txtUsername.Text;
            password = this.txtPassword.Text;
            rePassword = this.txtRePassword.Text;

            //need to verify unique username
            //loop through users in database ->
            //compare new username, error msg if not unique
            bool verify = ReadUsernames(username);
            if (verify)
            {
                //create new user acct

                //temp
                lblError.Show();
                lblError.Text = "New account created";
            }
            else
            {
                lblError.Show();
                lblError.Text = "Username taken";
            }

            //verify matching passwords
            if(password != rePassword)
            {
                lblError.Show();
                lblError.Text = "Passwords do not match";
            }
        }

      
        bool ReadUsernames(string username)

        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            SqlDataReader dr = connectionDB.DataReader("SELECT first_name from dbo.users"); //test; change for usernames                  
            for(int i = 0; i < dr.FieldCount; i++)
            {
                string name = dr.GetString(i);
                if(name == username)
                {
                    return false;
                }
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
    }
}
