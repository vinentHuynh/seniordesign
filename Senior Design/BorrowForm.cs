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
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            this.dataGridView1.DataSource = connectionDB.ShowDataInGridView("SELECT * FROM dbo.asset where borrow = 1 and deleted = 0");
            connectionDB.CloseConnection();
        }

        //request button
        private void RequestButton_click (object sender, EventArgs e) 
        { 
            BorrowInfoForm borrowInfo = new BorrowInfoForm();
            borrowInfo.ShowDialog();
            
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
