using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Design
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lblError.Hide();
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
    }
}
