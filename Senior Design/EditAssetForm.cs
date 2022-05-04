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
    public partial class EditAssetForm : Form
    {
        public EditAssetForm(string id)
        {
            InitializeComponent();

            ConnectionDB connectionDB = new ConnectionDB();

            // populate fields with existing asset data
            connectionDB.OpenConnection();
            SqlDataReader drAsset = connectionDB.DataReader(
                "SELECT " +
                "asset.id                   AS asset_id, " +
                "asset.asset_name           AS asset_name, " +
                "asset.status_last_updated  AS asset_status_last_updated, " +
                "asset.model_number         AS asset_model_number, " +
                "asset.serial_number        AS asset_serial_number, " +
                "asset.manufacturer         AS asset_manufacturer, " +
                "asset.os_version           AS asset_os_version, " +
                "asset.client_version       AS asset_client_version, " +
                "asset.borrow               AS asset_borrow, " +
                "asset.notes                AS asset_notes, " +
                "loc.id                     AS asset_loc_id, " +
                "loc.description            AS asset_loc_description, " +
                "stat.id                    AS asset_stat_id, " +
                "stat.description           AS asset_stat_description, " +
                "type.id                    AS asset_type_id, " +
                "type.description           AS asset_type_description " +
                "FROM asset " + 
                "JOIN asset_location loc ON loc.id = asset.asset_location_id " +
                "JOIN asset_status stat ON stat.id = asset.asset_status_id " +
                "JOIN asset_type type ON type.id = asset.asset_type_id " +
                "WHERE asset.id = " + id + " AND asset.deleted = 0"
                );
            drAsset.Read();
            this.assetName.Text = drAsset["asset_name"].ToString();
            this.statusLastUpdated.SetDate(DateTime.Parse(drAsset["asset_status_last_updated"].ToString()));
            this.modelNumber.Text = drAsset["asset_model_number"].ToString();
            this.serialNumber.Text = drAsset["asset_serial_number"].ToString();
            this.manufacturer.Text = drAsset["asset_manufacturer"].ToString();
            this.osVersion.Text = drAsset["asset_os_version"].ToString();
            this.clientVersion.Text = drAsset["asset_client_version"].ToString();
            this.borrow.Checked = (drAsset["asset_borrow"].ToString() == "True") ? true : false;
            this.notes.Text = drAsset["asset_notes"].ToString();
            connectionDB.CloseConnection();

            // fetch locations for drop-down
            connectionDB.OpenConnection();
            SqlDataReader drLocList = connectionDB.DataReader("SELECT description FROM asset_location");
            var locations = new List<string>();
            while (drLocList.Read())
            {
                locations.Add(drLocList["description"].ToString());
            }
            this.location.DataSource = locations;
            connectionDB.CloseConnection();
            
            // set location to existing location
            connectionDB.OpenConnection();
            SqlDataReader drExistingLoc = connectionDB.DataReader("SELECT description FROM asset_location JOIN asset ON asset.asset_location_id = asset_location.id WHERE asset.id = " + id + " AND asset.deleted = 0");
            drExistingLoc.Read();
            this.location.Text = drExistingLoc["description"].ToString();
            connectionDB.CloseConnection();

            // fetch statuses for drop-down
            connectionDB.OpenConnection();
            SqlDataReader drStat = connectionDB.DataReader("SELECT description FROM asset_status");
            var statuses = new List<string>();
            while (drStat.Read())
            {
                statuses.Add(drStat["description"].ToString());
            }
            this.status.DataSource = statuses;
            connectionDB.CloseConnection();

            // set status to existing status
            connectionDB.OpenConnection();
            SqlDataReader drExistingStat = connectionDB.DataReader("SELECT description FROM asset_status JOIN asset ON asset.asset_status_id = asset_status.id WHERE asset.id = " + id + " AND asset.deleted = 0");
            drExistingStat.Read();
            this.status.Text = drExistingStat["description"].ToString();
            connectionDB.CloseConnection();

            // fetch types for drop-down
            connectionDB.OpenConnection();
            SqlDataReader drType = connectionDB.DataReader("SELECT description FROM asset_type");
            var types = new List<string>();
            while (drType.Read())
            {
                types.Add(drType["description"].ToString());
            }
            this.type.DataSource = types;
            connectionDB.CloseConnection();

            // set type to existing type
            connectionDB.OpenConnection();
            SqlDataReader drExistingType = connectionDB.DataReader("SELECT description FROM asset_type JOIN asset ON asset.asset_type_id = asset_type.id WHERE asset.id = " + id + " AND asset.deleted = 0");
            drExistingType.Read();
            this.type.Text = drExistingType["description"].ToString();
            connectionDB.CloseConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();   // closes edit asset dialog and re-enables admin form
        }
    }
}
