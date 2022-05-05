using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Senior_Design
{
    public partial class BorrowInfoForm : Form
    {
        public BorrowInfoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            int user_id;
            int asset_id = int.Parse(txtAssetID.Text);
            string date = txtDate.Text;

            //dialogue box displaying entered info
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Confirm the following information:\nUsername: " + txtUsername.Text);
            sb.Append("\nRequesting: " + txtAssetID.Text);
            DialogResult confirmInfo = MessageBox.Show(sb.ToString(), "Confirm Info", MessageBoxButtons.OKCancel);

            if(confirmInfo == DialogResult.OK)
            {
                //determine PK id from new entry
                string rowCount = "SELECT COUNT(id) FROM borrow_history";
                ConnectionDB countConn = new ConnectionDB();
                int count = countConn.ExecuteScalar(rowCount) + 1;
                countConn.CloseConnection();

                //fetch user id with entered username
                string userQuery = "SELECT id FROM users WHERE username = '" + user + "'";
                ConnectionDB getUserId = new ConnectionDB();
                user_id = getUserId.ExecuteScalar(userQuery);
                getUserId.CloseConnection();

                //create new borrow record
                string query = "INSERT INTO borrow_history(id, user_id, asset_id, date_borrowed, date_returned)" +
                    " VALUES(" + count + ", " + user_id + ", " + asset_id + ", " + "'" + date + "',  NULL)";
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                connectionDB.ExecuteQueries(query);
                connectionDB.CloseConnection();

                //dialogue box confirming borrow request
                System.Text.StringBuilder sb2 = new System.Text.StringBuilder();
                sb2.Append("Request created. Please contact system administrator for further detail.");
                DialogResult confirmRequest = MessageBox.Show(sb2.ToString(), "Confirm Request", MessageBoxButtons.OK);
                this.Close();
                
            }
           
                
           
            
        }
    }
}
