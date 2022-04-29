using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Design
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();

            ConnectionDB connectionDB = new ConnectionDB();

            // fetch locations for drop-down
            connectionDB.OpenConnection();
            SqlDataReader drLoc = connectionDB.DataReader("SELECT description FROM asset_location");
            drLoc.Read();
            var locations = new List<string>();
            locations.Add("");
            while (drLoc.Read())
            {
                locations.Add(drLoc["description"].ToString());
            }
            this.location.DataSource = locations;
            connectionDB.CloseConnection();

            // fetch statuses for drop-down
            connectionDB.OpenConnection();
            SqlDataReader drStat = connectionDB.DataReader("SELECT description FROM asset_status");
            drStat.Read();
            var statuses = new List<string>();
            statuses.Add("");
            while (drStat.Read())
            {
                statuses.Add(drStat["description"].ToString());
            }
            this.status.DataSource = statuses;
            connectionDB.CloseConnection();

            // fetch types for drop-down
            connectionDB.OpenConnection();
            SqlDataReader drType = connectionDB.DataReader("SELECT description FROM asset_type");
            drType.Read();
            var types = new List<string>();
            types.Add("");
            while (drType.Read())
            {
                types.Add(drType["description"].ToString());
            }
            this.type.DataSource = types;
            connectionDB.CloseConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
