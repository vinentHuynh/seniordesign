namespace Senior_Design
{
    partial class BorrowInfoForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAssetiD = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(86, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 119);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(121, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date (yyyy-mm-dd)";
            this.lblDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAssetiD
            // 
            this.lblAssetiD.AutoSize = true;
            this.lblAssetiD.Location = new System.Drawing.Point(101, 180);
            this.lblAssetiD.Name = "lblAssetiD";
            this.lblAssetiD.Size = new System.Drawing.Size(55, 16);
            this.lblAssetiD.TabIndex = 2;
            this.lblAssetiD.Text = "Asset Id";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(190, 116);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(147, 22);
            this.txtDate.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(190, 59);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(147, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtAssetID
            // 
            this.txtAssetID.Location = new System.Drawing.Point(190, 177);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.Size = new System.Drawing.Size(147, 22);
            this.txtAssetID.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(244, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);  
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BorrowInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(434, 329);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAssetID);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblAssetiD);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUsername);
            this.Name = "BorrowInfoForm";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAssetiD;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAssetID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}