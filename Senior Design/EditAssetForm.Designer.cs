namespace Senior_Design
{
    partial class EditAssetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.borrow = new System.Windows.Forms.CheckBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.clientVersion = new System.Windows.Forms.TextBox();
            this.osVersion = new System.Windows.Forms.TextBox();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.modelNumber = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.clientVersionLbl = new System.Windows.Forms.Label();
            this.osVersionLbl = new System.Windows.Forms.Label();
            this.manufacturerLbl = new System.Windows.Forms.Label();
            this.serialNumberLbl = new System.Windows.Forms.Label();
            this.modelNumberLbl = new System.Windows.Forms.Label();
            this.statusLastUpdatedLbl = new System.Windows.Forms.Label();
            this.statusLastUpdated = new System.Windows.Forms.MonthCalendar();
            this.type = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.locationLbl = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.assetNameLbl = new System.Windows.Forms.Label();
            this.assetName = new System.Windows.Forms.TextBox();
            this.assetID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cancel
            // 
            this.cancel.CausesValidation = false;
            this.cancel.Location = new System.Drawing.Point(609, 595);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 50;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(524, 595);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 49;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // borrow
            // 
            this.borrow.AutoSize = true;
            this.borrow.Location = new System.Drawing.Point(524, 398);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(160, 17);
            this.borrow.TabIndex = 47;
            this.borrow.Text = "Can this asset be borrowed?";
            this.borrow.UseVisualStyleBackColor = true;
            // 
            // notes
            // 
            this.notes.AcceptsReturn = true;
            this.notes.Location = new System.Drawing.Point(34, 476);
            this.notes.MaxLength = 255;
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(650, 85);
            this.notes.TabIndex = 48;
            // 
            // clientVersion
            // 
            this.clientVersion.Location = new System.Drawing.Point(524, 315);
            this.clientVersion.MaxLength = 30;
            this.clientVersion.Name = "clientVersion";
            this.clientVersion.Size = new System.Drawing.Size(100, 20);
            this.clientVersion.TabIndex = 46;
            // 
            // osVersion
            // 
            this.osVersion.Location = new System.Drawing.Point(524, 255);
            this.osVersion.MaxLength = 30;
            this.osVersion.Name = "osVersion";
            this.osVersion.Size = new System.Drawing.Size(100, 20);
            this.osVersion.TabIndex = 45;
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(524, 195);
            this.manufacturer.MaxLength = 30;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(100, 20);
            this.manufacturer.TabIndex = 44;
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(524, 134);
            this.serialNumber.MaxLength = 30;
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(100, 20);
            this.serialNumber.TabIndex = 43;
            // 
            // modelNumber
            // 
            this.modelNumber.Location = new System.Drawing.Point(524, 75);
            this.modelNumber.MaxLength = 30;
            this.modelNumber.Name = "modelNumber";
            this.modelNumber.Size = new System.Drawing.Size(100, 20);
            this.modelNumber.TabIndex = 42;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(37, 459);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(35, 13);
            this.notesLbl.TabIndex = 41;
            this.notesLbl.Text = "Notes";
            // 
            // clientVersionLbl
            // 
            this.clientVersionLbl.AutoSize = true;
            this.clientVersionLbl.Location = new System.Drawing.Point(526, 299);
            this.clientVersionLbl.Name = "clientVersionLbl";
            this.clientVersionLbl.Size = new System.Drawing.Size(71, 13);
            this.clientVersionLbl.TabIndex = 40;
            this.clientVersionLbl.Text = "Client Version";
            // 
            // osVersionLbl
            // 
            this.osVersionLbl.AutoSize = true;
            this.osVersionLbl.Location = new System.Drawing.Point(526, 239);
            this.osVersionLbl.Name = "osVersionLbl";
            this.osVersionLbl.Size = new System.Drawing.Size(60, 13);
            this.osVersionLbl.TabIndex = 39;
            this.osVersionLbl.Text = "OS Version";
            // 
            // manufacturerLbl
            // 
            this.manufacturerLbl.AutoSize = true;
            this.manufacturerLbl.Location = new System.Drawing.Point(526, 179);
            this.manufacturerLbl.Name = "manufacturerLbl";
            this.manufacturerLbl.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLbl.TabIndex = 38;
            this.manufacturerLbl.Text = "Manufacturer";
            // 
            // serialNumberLbl
            // 
            this.serialNumberLbl.AutoSize = true;
            this.serialNumberLbl.Location = new System.Drawing.Point(526, 117);
            this.serialNumberLbl.Name = "serialNumberLbl";
            this.serialNumberLbl.Size = new System.Drawing.Size(73, 13);
            this.serialNumberLbl.TabIndex = 37;
            this.serialNumberLbl.Text = "Serial Number";
            // 
            // modelNumberLbl
            // 
            this.modelNumberLbl.AutoSize = true;
            this.modelNumberLbl.Location = new System.Drawing.Point(526, 59);
            this.modelNumberLbl.Name = "modelNumberLbl";
            this.modelNumberLbl.Size = new System.Drawing.Size(76, 13);
            this.modelNumberLbl.TabIndex = 36;
            this.modelNumberLbl.Text = "Model Number";
            // 
            // statusLastUpdatedLbl
            // 
            this.statusLastUpdatedLbl.AutoSize = true;
            this.statusLastUpdatedLbl.Location = new System.Drawing.Point(190, 177);
            this.statusLastUpdatedLbl.Name = "statusLastUpdatedLbl";
            this.statusLastUpdatedLbl.Size = new System.Drawing.Size(149, 13);
            this.statusLastUpdatedLbl.TabIndex = 35;
            this.statusLastUpdatedLbl.Text = "Last Updated Date for Status*";
            // 
            // statusLastUpdated
            // 
            this.statusLastUpdated.AllowDrop = true;
            this.statusLastUpdated.Location = new System.Drawing.Point(182, 196);
            this.statusLastUpdated.MaxSelectionCount = 1;
            this.statusLastUpdated.Name = "statusLastUpdated";
            this.statusLastUpdated.TabIndex = 33;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(34, 394);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 34;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(37, 378);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(35, 13);
            this.typeLbl.TabIndex = 32;
            this.typeLbl.Text = "Type*";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(37, 177);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(41, 13);
            this.statusLbl.TabIndex = 31;
            this.statusLbl.Text = "Status*";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(34, 196);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 21);
            this.status.TabIndex = 30;
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(37, 115);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(52, 13);
            this.locationLbl.TabIndex = 29;
            this.locationLbl.Text = "Location*";
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(34, 131);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(121, 21);
            this.location.TabIndex = 28;
            // 
            // assetNameLbl
            // 
            this.assetNameLbl.AutoSize = true;
            this.assetNameLbl.Location = new System.Drawing.Point(37, 57);
            this.assetNameLbl.Name = "assetNameLbl";
            this.assetNameLbl.Size = new System.Drawing.Size(68, 13);
            this.assetNameLbl.TabIndex = 27;
            this.assetNameLbl.Text = "Asset Name*";
            // 
            // assetName
            // 
            this.assetName.Location = new System.Drawing.Point(34, 74);
            this.assetName.MaxLength = 30;
            this.assetName.Name = "assetName";
            this.assetName.Size = new System.Drawing.Size(100, 20);
            this.assetName.TabIndex = 26;
            this.assetName.Validating += new System.ComponentModel.CancelEventHandler(this.AssetName_Validating);
            // 
            // assetID
            // 
            this.assetID.AutoSize = true;
            this.assetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetID.Location = new System.Drawing.Point(37, 30);
            this.assetID.Name = "assetID";
            this.assetID.Size = new System.Drawing.Size(63, 13);
            this.assetID.TabIndex = 51;
            this.assetID.Text = "Asset ID: ";
            // 
            // EditAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 635);
            this.Controls.Add(this.assetID);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.clientVersion);
            this.Controls.Add(this.osVersion);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.modelNumber);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.clientVersionLbl);
            this.Controls.Add(this.osVersionLbl);
            this.Controls.Add(this.manufacturerLbl);
            this.Controls.Add(this.serialNumberLbl);
            this.Controls.Add(this.modelNumberLbl);
            this.Controls.Add(this.statusLastUpdatedLbl);
            this.Controls.Add(this.statusLastUpdated);
            this.Controls.Add(this.type);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.status);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.location);
            this.Controls.Add(this.assetNameLbl);
            this.Controls.Add(this.assetName);
            this.Name = "EditAssetForm";
            this.Text = "Edit Asset";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox borrow;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox clientVersion;
        private System.Windows.Forms.TextBox osVersion;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.TextBox modelNumber;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.Label clientVersionLbl;
        private System.Windows.Forms.Label osVersionLbl;
        private System.Windows.Forms.Label manufacturerLbl;
        private System.Windows.Forms.Label serialNumberLbl;
        private System.Windows.Forms.Label modelNumberLbl;
        private System.Windows.Forms.Label statusLastUpdatedLbl;
        private System.Windows.Forms.MonthCalendar statusLastUpdated;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Label assetNameLbl;
        private System.Windows.Forms.TextBox assetName;
        private System.Windows.Forms.Label assetID;
    }
}