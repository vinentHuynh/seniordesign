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

namespace Senior_Design
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            int asset_id = int.Parse(txtAssetID.Text);
            string desc = txtDesc.Text;
            

            string checkAssetID = "SELECT id FROM asset";
            ConnectionDB checkID = new ConnectionDB();
            checkID.OpenConnection();
            SqlDataReader dr = checkID.DataReader(checkAssetID);
            var assetID = new List<int>();
            bool verify = false;
            while(dr.Read())
            {
                assetID.Add(Convert.ToInt32(dr["id"].ToString()));
            }
            for (int i = 0; i< assetID.Count; i++)
            {
                if (assetID[i] == asset_id)
                    verify = true;
            }
            if (verify)
            {
                string maintIDq = "SELECT COUNT(id) FROM maintenance";
                ConnectionDB getMaintID = new ConnectionDB();
                int maintID = getMaintID.ExecuteScalar(maintIDq) + 1;
                getMaintID.CloseConnection();

                string newMaintReq = "INSERT INTO maintenance(id, asset_id, maintenance_status_id, date_out, date_in, description) " +
                    "VALUES(" + maintID + ", " + asset_id + ", 2, NULL, NULL, '" + desc + "')";
                ConnectionDB createMaintReq = new ConnectionDB();
                createMaintReq.OpenConnection();
                createMaintReq.ExecuteQueries(newMaintReq);
                createMaintReq.CloseConnection();

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Maintenance request filed. Please contact system administrator for further details.");
                DialogResult confirmRequest = MessageBox.Show(sb.ToString(), "Request confirmed", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Invalid Asset Id");
                DialogResult confirmRequest = MessageBox.Show(sb.ToString(), "Confirm Request", MessageBoxButtons.OK);
            }
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
