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
    
    public partial class User : Form
    {
        string currentTable = "dbo.asset";
        public User()
        {
            //initalize
            InitializeComponent();
            showdata();
        }

        void showdata()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            string query = "SELECT * FROM " + currentTable;
            bool flag = false;
            if (currentTable == "dbo.asset")
            {
                query += " where deleted = 0";
                flag = true;

            }

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
            if (flag)
                this.dataGridView1.Columns["deleted"].Visible = false;
        }

        //search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text != "")
            {

                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                this.dataGridView1.DataSource = connectionDB.ShowDataInGridView("SELECT * from " + currentTable + " WHERE " + this.comboBox1.Text +
                    " LIKE '%" + this.textBox1.Text + "%'");
            }
            else if (this.textBox1.Text == null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                this.dataGridView1.DataSource = connectionDB.ShowDataInGridView("SELECT * from " + currentTable + " WHERE " + this.comboBox1.Text +
                    " LIKE '%" + this.textBox1.Text + "%'");
            }
            else
            {
                DialogResult res = MessageBox.Show("Please select a column.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTable = "dbo.maintenance";
            showdata();
        }

        //refresh button
        private void txtRefresh_Click(object sender, EventArgs e)
        {
            showdata();
            this.textBox1.Text = "";
        }

        //switch table view
        private void assetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTable = "dbo.asset";
            showdata();
        }

        
        private void btnFilter_Execute(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }
        private void UserClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

  
    }
}
