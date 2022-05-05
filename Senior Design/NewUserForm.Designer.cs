namespace Senior_Design
{
    partial class NewUserForm
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
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnCreateAcct = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(147, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(147, 147);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(132, 22);
            this.txtRePassword.TabIndex = 3;
            // 
            // btnCreateAcct
            // 
            this.btnCreateAcct.Location = new System.Drawing.Point(178, 312);
            this.btnCreateAcct.Name = "btnCreateAcct";
            this.btnCreateAcct.Size = new System.Drawing.Size(120, 28);
            this.btnCreateAcct.TabIndex = 4;
            this.btnCreateAcct.Text = "Create Account";
            this.btnCreateAcct.UseVisualStyleBackColor = true;
            this.btnCreateAcct.Click += new System.EventHandler(this.btnCreateAcct_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(64, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(67, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(12, 150);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(122, 16);
            this.lblRePassword.TabIndex = 8;
            this.lblRePassword.Text = "Re-enter Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(36, 272);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 16);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "error";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(93, 242);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 197);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(97, 16);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(147, 194);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 239);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(329, 375);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateAcct);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "NewUserForm";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Button btnCreateAcct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
    }
}