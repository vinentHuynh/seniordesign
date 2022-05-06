using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var locations = new List<string>();
            while (drLoc.Read())
            {
                locations.Add(drLoc["description"].ToString());
            }
            this.location.DataSource = locations;
            this.location.DropDownStyle = ComboBoxStyle.DropDownList;
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
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // call validation
            if (ValidateForm())
            {
                return;     // go back to add form if there's an invalid field
            }
            
            ConnectionDB connectionDB = new ConnectionDB();

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
                "INSERT INTO asset (asset_name, asset_location_id, asset_status_id, asset_type_id, model_number, serial_number, notes, manufacturer, os_version, client_version, status_last_updated, borrow) " +
                "VALUES (" +
                    "'" + this.assetName.Text + "', " +
                    locId + ", " +
                    statId + ", " +
                    typeId + ", " +
                    "'" + this.modelNumber.Text + "', " +
                    "'" + this.serialNumber.Text + "', " +
                    "'" + this.notes.Text + "', " +
                    "'" + this.manufacturer.Text + "', " +
                    "'" + this.osVersion.Text + "', " +
                    "'" + this.clientVersion.Text + "', " +
                    "'" + dateQuery + "', " +
                    "'" + this.borrow.Checked + "'" +
                ")";

            connectionDB.OpenConnection();
            connectionDB.ExecuteQueries(query);
            connectionDB.CloseConnection();

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   // closes add asset dialog and re-enables admin form
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
            // check if asset name field is empty
            if (!ValidateAssetName())
            {
                MessageBox.Show("Please enter a name for the asset.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            // check table to make sure asset name is unique, even if asset has been "deleted"
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.OpenConnection();
            SqlDataReader drName = connectionDB.DataReader("SELECT asset_name, deleted FROM asset");
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
