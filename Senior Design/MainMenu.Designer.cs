namespace Senior_Design
{
    partial class MainMenu
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(133, 50);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(133, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(47, 54);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(47, 103);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(179, 178);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 28);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.btnCreate.Location = new System.Drawing.Point(39, 178);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 28);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 143);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(44, 16);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "label2";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(39, 224);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(120, 28);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(179, 224);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(120, 28);
            this.btnMaintenance.TabIndex = 9;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(329, 278);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnMaintenance;
    }
}