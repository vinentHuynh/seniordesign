using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Senior_Design
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            string str;
            //SqlConnection myConn = new SqlConnection("server connection");
            //myConn.Open();
            lblError.Hide();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "sam-database.database.windows.net";
                builder.UserID = "samadmin";
                builder.Password = "Seniordesign2022";
                builder.InitialCatalog = "Assets";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT description FROM dbo.asset_location";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lblError.Text=  reader.GetString(0);
                                lblError.Show();
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
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

            username = this.txtUsername.Text;
            //need to encrypt password
            password = this.txtPassword.Text;
            //password checking
            if (username == "admin" && password == "password")
            {
                AdminForm adminform = new AdminForm();
                adminform.Show();
                lblError.Hide();
                this.Hide();
            }
            else if(username == "user" && password == "password")
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

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.Show();
        }
    }
}
