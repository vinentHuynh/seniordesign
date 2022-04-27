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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();

    

            //establish connection to database, only pull borrowable assets
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConection();
            this.dataGridView1.DataSource = connectionDB.ShowDataInGridView("SELECT * FROM 'dbo.asset'"/*WHERE borrow = 1*/);
            connectionDB.CloseConnection();
        }

        //request button
        private void RequestButton_click (object sender, EventArgs e) { 
            
        }

        private void MainMenuClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
