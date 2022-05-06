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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();

            //establish connection to database, only pull borrowable assets
            showData();
        }

        private void showData()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            string query = "SELECT * FROM dbo.asset WHERE borrow = 1 and deleted = 0";
            
            this.dataGridView1.DataSource = connectionDB.ShowDataInGridView(query);
            SqlDataReader dr = connectionDB.DataReader(query);

            dr.Read();
            var columns = new List<string>();
            columns.Add("");
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if(dr.GetName(i) != "deleted")
                    columns.Add(dr.GetName(i));
            }
            this.comboBox1.DataSource = columns;
            connectionDB.CloseConnection();
            this.dataGridView1.Columns["deleted"].Visible = false;
            this.dataGridView1.Columns["borrow"].Visible = false;
        }

        //request button
        private void RequestButton_click (object sender, EventArgs e) 
        { 
            BorrowInfoForm borrowInfo = new BorrowInfoForm();
            borrowInfo.ShowDialog();
            
        }

        //search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text != "")
            {

                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                this.dataGridView1.DataSource = connectionDB.ShowDataInGridView("SELECT * from asset WHERE borrow = 1 and deleted = 0 and " 
                    + this.comboBox1.Text + " LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (this.textBox1.Text == null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                this.dataGridView1.DataSource = connectionDB.ShowDataInGridView("SELECT * from asset WHERE borrow = 1 and deleted = 0 and" + this.comboBox1.Text +
                    " LIKE '%" + this.textBox1.Text + "%'");
            }
            else
            {
                DialogResult res = MessageBox.Show("Please select a column.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            showData();
            this.textBox1.Text = "";
        }


        private void btnFilter_Execute(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void BorrowMenuClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
