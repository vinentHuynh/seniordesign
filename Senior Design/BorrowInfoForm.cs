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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool verify;
            string user = textBox1.Text; ;
            int asset_id = int.Parse(textBox3.Text);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Confirm the following information:\nUsername: " + textBox1.Text);
            sb.Append("\nRequesting: " + textBox3.Text);
            sb.Append("");
            DialogResult confirmInfo = MessageBox.Show(sb.ToString(), "Confirm Info", MessageBoxButtons.OKCancel);
            if (confirmInfo == DialogResult.OK)
            {
                this.Close();
                verify = true;
            }
            else
                verify = false;
            if (verify == true)
            {
                string query = "INSERT INTO borrow_history(id, user_id, asset_id, date_borrowed, date_returned)" +
               " VALUES()"; 
               ConnectionDB connectionDB = new ConnectionDB();
               connectionDB.OpenConnection();
               connectionDB.ExecuteQueries(query);
               connectionDB.CloseConnection();

                System.Text.StringBuilder sb2 = new StringBuilder();
                sb2.Append("Request created. Please contact administrator for any further details.");
                DialogResult confirmRequest = MessageBox.Show(sb2.ToString(), "Confirm Request", MessageBoxButtons.OK);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

    }
}
