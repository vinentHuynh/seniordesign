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
            string str = "temp";    //delete after updating sql connection method

            username = this.txtUsername.Text;
            password = this.txtPassword.Text;
            rePassword = this.txtRePassword.Text;

            //need to verify unique username
            //loop through users in database ->
            //compare new username, error msg if not unique
<<<<<<< Updated upstream
           /* bool verify = ReadUsernames(str, username);
=======
           bool verify = ReadUsernames(username);
>>>>>>> Stashed changes
            if (verify)
            {
              //create new user acct
            }
            else
            {
                lblError.Show();
                lblError.Text = "Username taken";
            }*/

            //verify matching passwords
            if(password != rePassword)
            {
                lblError.Show();
                lblError.Text = "Passwords do not match";
            }
        }

<<<<<<< Updated upstream
       /* private static bool ReadUsernames(string connectionString, string username)
=======

        bool ReadUsernames(string username)
>>>>>>> Stashed changes
        {
            string query = "SELECT username FROM dbo.user";

<<<<<<< Updated upstream
            //don't need to establish a new connection, see borrow/adminForm for new connection
            using (SqlConnection connection = new SqlConnection(connectionString)) 
=======
            SqlDataReader dr = connectionDB.DataReader("SELECT first_name from dbo.users"); //test; change for usernames
          
            for(int i = 0; i < dr.FieldCount; i++)
>>>>>>> Stashed changes
            {
                SqlCommand command =
                    new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                //call read before accessing data
                while (reader.Read())
                {
                    string temp = reader[username].ToString();
                    if(temp == username)
                    {
                        //return false if new username is not unique
                        return false;
                    }
                    //ReadSingleRow((IDataRecord)reader);
                }

                //call close when done reading
                reader.Close();
            }
            //note: SqlConnection is automatically closed at end of 'using' block

            //return true if new username is unique
            return true;
        }   */

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
