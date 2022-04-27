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
    public partial class AdminForm : Form
    {
        public void ListAllAssets()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            this.dgvAssets.DataSource = connectionDB.ShowDataInGridView(
                "SELECT * from dbo.asset WHERE deleted = 0"
            );
            connectionDB.CloseConnection();
        }

        public AdminForm()
        {
            InitializeComponent();
            //https://stackoverflow.com/questions/1054984/how-can-i-get-column-names-from-a-table-in-sql-server
            //create for loop to add columns for dataGrid and filters
            this.cmbFields.Items.Add("d");
            //for(int i = 0; i < numColumns; i++)
            //this.dgvAssets.columns[i].header = columnName[i]

            //OR automatically add data from sql 
            //https://stackoverflow.com/questions/18113278/populate-a-datagridview-with-sql-query-results

            ListAllAssets();
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

            ListAllAssets();    // refresh screen
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
    }
}
