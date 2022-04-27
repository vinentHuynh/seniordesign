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

namespace Senior_Design
{
    public partial class AdminForm : Form
    {
       

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
            this.dgvAssets.DataSource = connectionDB.ShowDataInGridView("SELECT * from dbo.asset where deleted = 0");
            SqlDataReader dr = connectionDB.DataReader("SELECT * from dbo.asset");
            dr.Read();
            var columns = new List<string>();
            columns.Add("");
            for (int i = 0; i < dr.FieldCount; i++)
            {
                columns.Add(dr.GetName(i));
            }
            this.cmbFields.DataSource = columns;
            connectionDB.CloseConnection();
            
        }
        
        //delete button
        private void Button2_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = this.dgvAssets.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                // display confirmation message with list of selected records
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.Append("Are you sure you want to delete the following records?\n");

                for (int i = selectedRowCount - 1; i >= 0; i--)
                {
                    sb.Append(this.dgvAssets.SelectedRows[i].Cells["id"].Value.ToString());
                    sb.Append(" ");

                    // display different fields depending on the current table
                    if (currentTable == "dbo.asset")
                    {

                    }
                    else if (currentTable == "dbo.user")
                    {

                    }
                    sb.Append(this.dgvAssets.SelectedRows[i].Cells["name"].Value.ToString());

                    sb.Append(Environment.NewLine);
                }

                DialogResult confirmDelete = MessageBox.Show(sb.ToString(), "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                // if user clicks OK then delete assets, else do nothing
                if (confirmDelete == DialogResult.OK)
                {
                    ConnectionDB connectionDB = new ConnectionDB();
                    connectionDB.OpenConnection();

                    // change deleted column to 1 for selected assets (soft delete)
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        string query = "UPDATE asset SET deleted = 1 WHERE id = " + this.dgvAssets.SelectedRows[i].Cells["id"].Value.ToString();
                        connectionDB.ExecuteQueries(query);
                    }

                    connectionDB.CloseConnection();
                }
            }
            else
            {
                DialogResult noneSelected = MessageBox.Show("No rows selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.dgvAssets.DataSource = connectionDB.ShowDataInGridView("SELECT * from dbo.asset_location WHERE " + this.cmbFields.Text +
                " LIKE '%" + this.txtFilter.Text + "%'");
            }
            
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
