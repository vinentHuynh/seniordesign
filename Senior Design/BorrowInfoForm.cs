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
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

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
            string date = txtDate.Text;
            int user_id;
            int asset_id = 0;
            try
            {
                asset_id = int.Parse(txtAssetID.Text);
            }
            catch (System.FormatException) { }

            //validate date format
            bool dateFormat = VerifyDateFormat(date);

            //validate username
            bool checkUsername = false;
            string checkUserq = "SELECT username FROM users";
            ConnectionDB checkUser = new ConnectionDB();
            checkUser.OpenConnection();
            SqlDataReader dr2 = checkUser.DataReader(checkUserq);
            var userIDs = new List<string>();
            while(dr2.Read())
            {
                userIDs.Add(dr2["username"].ToString());
            }
            for(int j = 0; j < userIDs.Count; j++)
            {
                if (userIDs[j] == user)
                    checkUsername = true;
            }
            checkUser.CloseConnection();

            //validate asset id
            bool checkAssetID = false;
            string assetQuery = "SELECT id FROM asset WHERE borrow = 1";
            ConnectionDB checkAsset = new ConnectionDB();
            checkAsset.OpenConnection();
            SqlDataReader dr = checkAsset.DataReader(assetQuery);
            var assetIDs = new List<int>();
           while(dr.Read())
            {
                assetIDs.Add(Convert.ToInt32(dr["id"].ToString()));                
            }
           for (int i = 0; i < assetIDs.Count; i++)
            {
                if (assetIDs[i] == asset_id)
                    checkAssetID = true;
            }
            checkAsset.CloseConnection();

   

            if (checkAssetID && checkUsername && dateFormat)
            {
                //dialogue box displaying entered info
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Confirm the following information:\nUsername: " + txtUsername.Text);
                sb.Append("\nRequesting: " + txtAssetID.Text);
                DialogResult confirmInfo = MessageBox.Show(sb.ToString(), "Confirm Info", MessageBoxButtons.OKCancel);

                if (confirmInfo == DialogResult.OK)
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

                    //update borrow status
                    string updateq = "UPDATE asset SET borrow = 0 WHERE id = " + asset_id;
                    ConnectionDB updateConn = new ConnectionDB();
                    updateConn.OpenConnection();
                    updateConn.ExecuteQueries(updateq);
                    updateConn.CloseConnection();

                    //dialogue box confirming borrow request
                    System.Text.StringBuilder sb2 = new System.Text.StringBuilder();
                    sb2.Append("Request created. Please contact system administrator for further detail.");
                    DialogResult confirmRequest = MessageBox.Show(sb2.ToString(), "Confirm Request", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                if (checkAssetID == false)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("Invalid Asset ID");
                    DialogResult confirmRequest = MessageBox.Show(sb.ToString(), "Confirm Request", MessageBoxButtons.OK);
                }
                if (checkUsername == false)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("Invalid Username");
                    DialogResult confirmRequest = MessageBox.Show(sb.ToString(), "Confirm Request", MessageBoxButtons.OK);
                }
                if (dateFormat == false)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("Invalid date");
                    DialogResult confirmRequest = MessageBox.Show(sb.ToString(), "Confirm Request", MessageBoxButtons.OK);
                }
            }          
            
        }

        private static readonly Regex dateFormatRegex = new Regex(@"^\d{4}-\d{2}-\d{2}$");

        private static bool VerifyDateFormat(string date)
        {
            return dateFormatRegex.IsMatch(date);
        }
    }
}
