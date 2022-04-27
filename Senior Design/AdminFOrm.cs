﻿using System;
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
    public partial class AdminForm : Form
    {
        string currentTable = "dbo.asset";

        public AdminForm()
        {
            InitializeComponent();
            //https://stackoverflow.com/questions/1054984/how-can-i-get-column-names-from-a-table-in-sql-server
            //create for loop to add columns for dataGrid and filters

            //for(int i = 0; i < numColumns; i++)
            //this.dgvAssets.columns[i].header = columnName[i]

            //OR automatically add data from sql 
            //https://stackoverflow.com/questions/18113278/populate-a-datagridview-with-sql-query-results

            showdata();


            
        }
       void showdata()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            string query = "SELECT * from " + currentTable;
            bool flag = false;
            if (currentTable == "dbo.asset")
            {
                query += " where deleted = 0";
                flag = true;

            }

            this.dgvAssets.DataSource = connectionDB.ShowDataInGridView("SELECT * from " + currentTable);
            SqlDataReader dr = connectionDB.DataReader("SELECT * from " + currentTable);
            
            dr.Read();
            var columns = new List<string>();
            columns.Add("");
            for (int i = 0; i < dr.FieldCount; i++)
            {
                columns.Add(dr.GetName(i));
            }
            this.cmbFields.DataSource = columns;
            connectionDB.CloseConnection();
            if (flag)
                this.dgvAssets.Columns["deleted"].Visible = false;
        }
        
        //delete button
        private void Button2_Click(object sender, EventArgs e)
        {

           
            Int32 selectedRowCount = this.dgvAssets.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                // change deleted column to 1 for selected assets (soft delete)
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                for (int i = 0; i < selectedRowCount; i++)
                {
                    // create command text with the selected row's id
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE asset" +
                        "SET deleted = 1" +
                        "WHERE id = @id"
                    );
                    cmd.Parameters.AddWithValue("@id", this.dgvAssets.SelectedRows[i].Cells["id"].Value.ToString());

                    // pass the command to ExecuteQueries() to be executed
                    connectionDB.ExecuteQueries(cmd.CommandText);
                }
                connectionDB.CloseConnection();
            }

            showdata();    // refresh screen
        }

        //add button
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void MainMenuClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if(this.cmbFields.Text !="")
            {
                
                ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            this.dgvAssets.DataSource = connectionDB.ShowDataInGridView("SELECT * from " +currentTable + " WHERE " + this.cmbFields.Text +
                " LIKE '%" + this.txtFilter.Text + "%'");
            }
            else if(this.txtFilter.Text == null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.OpenConnection();
                this.dgvAssets.DataSource = connectionDB.ShowDataInGridView("SELECT * from " + currentTable + " WHERE " + this.cmbFields.Text +
                    " LIKE '%" + this.txtFilter.Text + "%'");
            }
            else
            {
                DialogResult res = MessageBox.Show("Please select a column.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();

            SqlDataReader dr = connectionDB.DataReader("SELECT * from dbo.asset where deleted = 0");
                

            string fileName = "DatabaseOutput.csv";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw = new StreamWriter(Path.Combine(docPath,fileName));
            object[] output = new object[dr.FieldCount];

            for (int i = 0; i < dr.FieldCount; i++)
                output[i] = dr.GetName(i);

            sw.WriteLine(string.Join(",", output));

            while (dr.Read())
            {
                dr.GetValues(output);
                sw.WriteLine(string.Join(",", output));
            }
            DialogResult res = MessageBox.Show("Database exported in MyDocuments folder", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            sw.Close();
            dr.Close();
            connectionDB.CloseConnection();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTable = "dbo.maintenance";
            showdata();
        }

        private void assetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTable = "dbo.asset";
            showdata();
        }
    }
}
