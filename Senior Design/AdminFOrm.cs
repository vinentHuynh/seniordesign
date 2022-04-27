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
            connectionDB.OpenConection();
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
            connectionDB.OpenConection();
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
