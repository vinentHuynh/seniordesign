namespace Senior_Design
{
    partial class AddAssetForm
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
            this.assetName = new System.Windows.Forms.TextBox();
            this.assetNameLbl = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.locationLbl = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.statusLastUpdated = new System.Windows.Forms.MonthCalendar();
            this.statusLastUpdatedLbl = new System.Windows.Forms.Label();
            this.modelNumberLbl = new System.Windows.Forms.Label();
            this.serialNumberLbl = new System.Windows.Forms.Label();
            this.manufacturerLbl = new System.Windows.Forms.Label();
            this.osVersionLbl = new System.Windows.Forms.Label();
            this.clientVersionLbl = new System.Windows.Forms.Label();
            this.notesLbl = new System.Windows.Forms.Label();
            this.modelNumber = new System.Windows.Forms.TextBox();
            this.serialNumber = new System.Windows.Forms.TextBox();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.osVersion = new System.Windows.Forms.TextBox();
            this.clientVersion = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.borrow = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // assetName
            // 
            this.assetName.Location = new System.Drawing.Point(36, 52);
            this.assetName.MaxLength = 30;
            this.assetName.Name = "assetName";
            this.assetName.Size = new System.Drawing.Size(100, 20);
            this.assetName.TabIndex = 0;
            this.assetName.Validating += new System.ComponentModel.CancelEventHandler(this.AssetName_Validating);
            // 
            // assetNameLbl
            // 
            this.assetNameLbl.AutoSize = true;
            this.assetNameLbl.Location = new System.Drawing.Point(39, 35);
            this.assetNameLbl.Name = "assetNameLbl";
            this.assetNameLbl.Size = new System.Drawing.Size(68, 13);
            this.assetNameLbl.TabIndex = 1;
            this.assetNameLbl.Text = "Asset Name*";
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(36, 109);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(121, 21);
            this.location.TabIndex = 2;
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(39, 93);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(52, 13);
            this.locationLbl.TabIndex = 3;
            this.locationLbl.Text = "Location*";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(36, 174);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 21);
            this.status.TabIndex = 4;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(39, 155);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(41, 13);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "Status*";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(39, 356);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(35, 13);
            this.typeLbl.TabIndex = 6;
            this.typeLbl.Text = "Type*";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(36, 372);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 8;
            // 
            // statusLastUpdated
            // 
            this.statusLastUpdated.AllowDrop = true;
            this.statusLastUpdated.Location = new System.Drawing.Point(184, 174);
            this.statusLastUpdated.MaxSelectionCount = 1;
            this.statusLastUpdated.Name = "statusLastUpdated";
            this.statusLastUpdated.TabIndex = 7;
            // 
            // statusLastUpdatedLbl
            // 
            this.statusLastUpdatedLbl.AutoSize = true;
            this.statusLastUpdatedLbl.Location = new System.Drawing.Point(192, 155);
            this.statusLastUpdatedLbl.Name = "statusLastUpdatedLbl";
            this.statusLastUpdatedLbl.Size = new System.Drawing.Size(149, 13);
            this.statusLastUpdatedLbl.TabIndex = 9;
            this.statusLastUpdatedLbl.Text = "Last Updated Date for Status*";
            // 
            // modelNumberLbl
            // 
            this.modelNumberLbl.AutoSize = true;
            this.modelNumberLbl.Location = new System.Drawing.Point(528, 37);
            this.modelNumberLbl.Name = "modelNumberLbl";
            this.modelNumberLbl.Size = new System.Drawing.Size(76, 13);
            this.modelNumberLbl.TabIndex = 10;
            this.modelNumberLbl.Text = "Model Number";
            // 
            // serialNumberLbl
            // 
            this.serialNumberLbl.AutoSize = true;
            this.serialNumberLbl.Location = new System.Drawing.Point(528, 95);
            this.serialNumberLbl.Name = "serialNumberLbl";
            this.serialNumberLbl.Size = new System.Drawing.Size(73, 13);
            this.serialNumberLbl.TabIndex = 11;
            this.serialNumberLbl.Text = "Serial Number";
            // 
            // manufacturerLbl
            // 
            this.manufacturerLbl.AutoSize = true;
            this.manufacturerLbl.Location = new System.Drawing.Point(528, 157);
            this.manufacturerLbl.Name = "manufacturerLbl";
            this.manufacturerLbl.Size = new System.Drawing.Size(70, 13);
            this.manufacturerLbl.TabIndex = 12;
            this.manufacturerLbl.Text = "Manufacturer";
            // 
            // osVersionLbl
            // 
            this.osVersionLbl.AutoSize = true;
            this.osVersionLbl.Location = new System.Drawing.Point(528, 217);
            this.osVersionLbl.Name = "osVersionLbl";
            this.osVersionLbl.Size = new System.Drawing.Size(60, 13);
            this.osVersionLbl.TabIndex = 13;
            this.osVersionLbl.Text = "OS Version";
            // 
            // clientVersionLbl
            // 
            this.clientVersionLbl.AutoSize = true;
            this.clientVersionLbl.Location = new System.Drawing.Point(528, 277);
            this.clientVersionLbl.Name = "clientVersionLbl";
            this.clientVersionLbl.Size = new System.Drawing.Size(71, 13);
            this.clientVersionLbl.TabIndex = 14;
            this.clientVersionLbl.Text = "Client Version";
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(39, 437);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(35, 13);
            this.notesLbl.TabIndex = 16;
            this.notesLbl.Text = "Notes";
            // 
            // modelNumber
            // 
            this.modelNumber.Location = new System.Drawing.Point(526, 53);
            this.modelNumber.MaxLength = 30;
            this.modelNumber.Name = "modelNumber";
            this.modelNumber.Size = new System.Drawing.Size(100, 20);
            this.modelNumber.TabIndex = 17;
            // 
            // serialNumber
            // 
            this.serialNumber.Location = new System.Drawing.Point(526, 112);
            this.serialNumber.MaxLength = 30;
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(100, 20);
            this.serialNumber.TabIndex = 18;
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(526, 173);
            this.manufacturer.MaxLength = 30;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(100, 20);
            this.manufacturer.TabIndex = 19;
            // 
            // osVersion
            // 
            this.osVersion.Location = new System.Drawing.Point(526, 233);
            this.osVersion.MaxLength = 30;
            this.osVersion.Name = "osVersion";
            this.osVersion.Size = new System.Drawing.Size(100, 20);
            this.osVersion.TabIndex = 20;
            // 
            // clientVersion
            // 
            this.clientVersion.Location = new System.Drawing.Point(526, 293);
            this.clientVersion.MaxLength = 30;
            this.clientVersion.Name = "clientVersion";
            this.clientVersion.Size = new System.Drawing.Size(100, 20);
            this.clientVersion.TabIndex = 21;
            // 
            // notes
            // 
            this.notes.AcceptsReturn = true;
            this.notes.Location = new System.Drawing.Point(36, 454);
            this.notes.MaxLength = 255;
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(650, 85);
            this.notes.TabIndex = 23;
            // 
            // borrow
            // 
            this.borrow.AutoSize = true;
            this.borrow.Location = new System.Drawing.Point(526, 376);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(160, 17);
            this.borrow.TabIndex = 22;
            this.borrow.Text = "Can this asset be borrowed?";
            this.borrow.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(526, 573);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 24;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.CausesValidation = false;
            this.cancel.Location = new System.Drawing.Point(611, 573);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 25;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.Save_Click);
            // 
            // AddAssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 628);
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
            this.Name = "AddAssetForm";
            this.Text = "AddAssetForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assetName;
        private System.Windows.Forms.Label assetNameLbl;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.MonthCalendar statusLastUpdated;
        private System.Windows.Forms.Label statusLastUpdatedLbl;
        private System.Windows.Forms.Label modelNumberLbl;
        private System.Windows.Forms.Label serialNumberLbl;
        private System.Windows.Forms.Label manufacturerLbl;
        private System.Windows.Forms.Label osVersionLbl;
        private System.Windows.Forms.Label clientVersionLbl;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.TextBox modelNumber;
        private System.Windows.Forms.TextBox serialNumber;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.TextBox osVersion;
        private System.Windows.Forms.TextBox clientVersion;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.CheckBox borrow;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}