namespace Senior_Design
{
    partial class MaintenanceForm
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
            this.lblAssetID = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAssetID
            // 
            this.lblAssetID.AutoSize = true;
            this.lblAssetID.Location = new System.Drawing.Point(60, 38);
            this.lblAssetID.Name = "lblAssetID";
            this.lblAssetID.Size = new System.Drawing.Size(57, 16);
            this.lblAssetID.TabIndex = 1;
            this.lblAssetID.Text = "Asset ID";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(42, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 16);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(248, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 31);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(123, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAssetID
            // 
            this.txtAssetID.Location = new System.Drawing.Point(123, 35);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.Size = new System.Drawing.Size(135, 22);
            this.txtAssetID.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(123, 84);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.AutoSize = false;
            this.txtDesc.Size = new System.Drawing.Size(218, 70);
            this.txtDesc.TabIndex = 6;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(435, 252);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtAssetID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblAssetID);
            this.Name = "MaintenanceForm";
            this.Text = "Request Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAssetID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAssetID;
        private System.Windows.Forms.TextBox txtDesc;
    }
}