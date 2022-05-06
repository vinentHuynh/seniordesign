using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.assetID.Text += id;    // display asset id so that edit query has asset id
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
            this.location.DropDownStyle = ComboBoxStyle.DropDownList;
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
            this.status.DropDownStyle = ComboBoxStyle.DropDownList;
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
            this.type.DropDownStyle = ComboBoxStyle.DropDownList;
            connectionDB.CloseConnection();

            // set type to existing type
            connectionDB.OpenConnection();
            SqlDataReader drExistingType = connectionDB.DataReader("SELECT description FROM asset_type JOIN asset ON asset.asset_type_id = asset_type.id WHERE asset.id = " + id + " AND asset.deleted = 0");
            drExistingType.Read();
            this.type.Text = drExistingType["description"].ToString();
            connectionDB.CloseConnection();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // call validations
            if (ValidateForm())
            {
                return;     // go back to edit form if there's an invalid field
            }

            ConnectionDB connectionDB = new ConnectionDB();

            // get asset id from label
            string assetIDLbl = this.assetID.Text;
            char[] idSeparator = { ' ' };
            String[] idLblComponents = assetIDLbl.Split(idSeparator);
            string assetID = idLblComponents[2];

            // get asset location id from the location description that the user selected
            connectionDB.OpenConnection();
            SqlDataReader drLoc = connectionDB.DataReader("SELECT id FROM asset_location WHERE description = \'" + this.location.Text + "\'");
            drLoc.Read();
            string locId = drLoc["id"].ToString();
            connectionDB.CloseConnection();

            // get asset status id from the status description that the user selected
            connectionDB.OpenConnection();
            SqlDataReader drStat = connectionDB.DataReader("SELECT id FROM asset_status WHERE description = \'" + this.status.Text + "\'");
            drStat.Read();
            string statId = drStat["id"].ToString();
            connectionDB.CloseConnection();

            // get asset type id from the type description that the user selected
            connectionDB.OpenConnection();
            SqlDataReader drType = connectionDB.DataReader("SELECT id FROM asset_type WHERE description = \'" + this.type.Text + "\'");
            drType.Read();
            string typeId = drType["id"].ToString();
            connectionDB.CloseConnection();

            // get status last updated date from the MonthCalendar and convert to SQL date
            string selectedDate = this.statusLastUpdated.SelectionRange.Start.ToShortDateString();
            char[] separator = { '/' };
            String[] dateComponents = selectedDate.Split(separator);    // split into month, day, and year substrings
            string dateQuery = dateComponents[2].ToString() + "-" + dateComponents[0].ToString() + "-" + dateComponents[1].ToString();  // SQL date format = YYYY-MM-DD

            string query =
                "UPDATE asset " +
                "SET " +
                    "asset_name = '" + this.assetName.Text + "', " +
                    "asset_location_id = " + locId + ", " +
                    "asset_status_id = " + statId + ", " +
                    "asset_type_id = " + typeId + ", " +
                    "model_number = '" + this.modelNumber.Text + "', " +
                    "serial_number = '" + this.serialNumber.Text + "', " +
                    "notes = '" + this.notes.Text + "', " +
                    "manufacturer = '" + this.manufacturer.Text + "', " +
                    "os_version = '" + this.osVersion.Text + "', " +
                    "client_version = '" + this.clientVersion.Text + "', " +
                    "status_last_updated = '" + dateQuery + "', " +
                    "borrow = '" + this.borrow.Checked + "'" +
                "WHERE id = " + assetID;

            connectionDB.OpenConnection();
            connectionDB.ExecuteQueries(query);
            connectionDB.CloseConnection();

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   // closes edit asset dialog and re-enables admin form
        }

        // ***** VALIDATIONS *****
        // called as user tabs through asset name field
        private void AssetName_Validating(object sender, CancelEventArgs e)
        {
            ValidateAssetName();
        }

        private bool ValidateAssetName()
        {
            bool flag = true;

            if (string.IsNullOrWhiteSpace(assetName.Text))  // asset name field must contain text
            {
                assetName.Focus();
                errorProvider1.SetError(assetName, "Please enter a name for the asset.");
                flag = false;
            }
            else
            {
                errorProvider1.SetError(assetName, "");
            }

            return flag;
        }

        // called when user clicks save button
        private bool ValidateForm()
        {
            // get asset id from label for SQL query
            string assetIDLbl = this.assetID.Text;
            char[] idSeparator = { ' ' };
            String[] idLblComponents = assetIDLbl.Split(idSeparator);
            string assetID = idLblComponents[2];

            // check if asset name field is empty
            if (!ValidateAssetName())
            {
                MessageBox.Show("Please enter a name for the asset.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            // check table to make sure asset name is unique, even if asset has been "deleted"
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            SqlDataReader drName = connectionDB.DataReader("SELECT asset_name, deleted FROM asset WHERE id != " + assetID);     // fetch all other asset names
            while (drName.Read())
            {
                // if asset name exists in non-deleted list
                if (assetName.Text == drName["asset_name"].ToString() && drName["deleted"].ToString() == "False")
                {
                    MessageBox.Show("Asset name already exists. Please enter a unique asset name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                // else if asset name exists in recycling bin
                else if (assetName.Text == drName["asset_name"].ToString() && drName["deleted"].ToString() == "True")
                {
                    MessageBox.Show("Asset name already exists (in recycling bin). Please enter a unique asset name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            
            connectionDB.CloseConnection();

            return false;
        }
        // ***** END OF VALIDATIONS *****
    }
}
