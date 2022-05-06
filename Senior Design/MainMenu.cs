using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Senior_Design
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.txtPassword.PasswordChar = '*';
            string str;
            //SqlConnection myConn = new SqlConnection("server connection");
            //myConn.Open();
            lblError.Hide();

            try
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                builder.DataSource = "sam-database.database.windows.net";
                builder.UserID = "samadmin";
                builder.Password = "Seniordesign2022";
                builder.InitialCatalog = "Assets";

                
                
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            bool verify = false;
            
            username = this.txtUsername.Text;
            //need to encrypt password
            password = this.txtPassword.Text;

            string query = "SELECT password FROM users WHERE username = '" + username + "'";
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            Microsoft.Data.SqlClient.SqlDataReader dr = connectionDB.DataReader(query);
            dr.Read();
            for(int i = 0; i < dr.FieldCount; i++)
            {
                string check = dr.GetString(i);
                if (check == password)
                    verify = true;
            }
            connectionDB.CloseConnection();
            //DECRYPTION

            //query = "SELECT password,username from users where  username = '" + username + "'";
            
            //connectionDB.OpenConnection();
            //DataTable dt = new DataTable();
            //dt = connectionDB.DataAdapter(query, username);

            //string dUser = dt.Rows[0]["username"].ToString();
            //string dPassword = dt.Rows[0]["password"].ToString();

            //bool flag = Helper.VerifyHash(password, "SHA512", dPassword);

            //if (dUser == dPassword && flag == true)
            //{
            //    AdminForm adminform = new AdminForm();
            //    adminform.Show();
            //    lblError.Hide();
            //    this.Hide();
            //}
            //else
            //{
            //    lblError.Show();
            //    lblError.Text = "Incorrect username or password";
            //}

            //password checking
            if (verify && username == "admin")
            {
                AdminForm adminform = new AdminForm();
                adminform.Show();
                lblError.Hide();
                this.Hide();
            }
            else if(verify && username != "admin")
            {
                User user = new User();
                user.Show();
                lblError.Hide();
                this.Hide();
            }
            else
            {
                lblError.Show();
                lblError.Text = "Incorrect username or password";
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm newuserform = new NewUserForm();
            newuserform.Show(); 
        }


        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
        }


        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintform = new MaintenanceForm();
            maintform.Show();
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEnter_Click(this, new EventArgs());
            }

        }
    }
}
