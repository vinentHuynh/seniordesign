namespace Senior_Design
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ticket_button = new System.Windows.Forms.Button();
            this.assets_button = new System.Windows.Forms.Button();
            this.request_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.maintenance_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.users_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Navy;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(61, 61);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 87);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ticket_button
            // 
            this.ticket_button.AccessibleDescription = "Button that takes you to open tickets.";
            this.ticket_button.AccessibleName = "Open Tickets Button";
            this.ticket_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ticket_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticket_button.Location = new System.Drawing.Point(305, 269);
            this.ticket_button.Name = "ticket_button";
            this.ticket_button.Size = new System.Drawing.Size(230, 54);
            this.ticket_button.TabIndex = 2;
            this.ticket_button.Text = "Open Tickets";
            this.ticket_button.UseVisualStyleBackColor = false;
            // 
            // assets_button
            // 
            this.assets_button.AccessibleDescription = "Button that goes to the screen to view/add/delete assets.";
            this.assets_button.AccessibleName = "View Assets Button";
            this.assets_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.assets_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assets_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assets_button.Location = new System.Drawing.Point(61, 119);
            this.assets_button.Name = "assets_button";
            this.assets_button.Size = new System.Drawing.Size(230, 135);
            this.assets_button.TabIndex = 3;
            this.assets_button.Text = "View Assets";
            this.assets_button.UseVisualStyleBackColor = false;
            this.assets_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // request_button
            // 
            this.request_button.AccessibleDescription = "Button that takes you to asset request page.";
            this.request_button.AccessibleName = "Asset Requests Button";
            this.request_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.request_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.request_button.Location = new System.Drawing.Point(61, 269);
            this.request_button.Name = "request_button";
            this.request_button.Size = new System.Drawing.Size(230, 54);
            this.request_button.TabIndex = 6;
            this.request_button.Text = "Asset Requests";
            this.request_button.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(305, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // maintenance_button
            // 
            this.maintenance_button.AccessibleDescription = "Button that takes you to data and maintenance information.";
            this.maintenance_button.AccessibleName = "Maintenance Button";
            this.maintenance_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.maintenance_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenance_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maintenance_button.Location = new System.Drawing.Point(305, 119);
            this.maintenance_button.Name = "maintenance_button";
            this.maintenance_button.Size = new System.Drawing.Size(230, 135);
            this.maintenance_button.TabIndex = 8;
            this.maintenance_button.Text = "Maintenance";
            this.maintenance_button.UseVisualStyleBackColor = false;
            // 
            // exit_button
            // 
            this.exit_button.AccessibleDescription = "Button that exits the program.";
            this.exit_button.AccessibleName = "Exit Button";
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exit_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_button.Location = new System.Drawing.Point(383, 339);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(152, 54);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // settings_button
            // 
            this.settings_button.AccessibleName = "Settings Button";
            this.settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.settings_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings_button.Location = new System.Drawing.Point(220, 339);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(152, 54);
            this.settings_button.TabIndex = 11;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // users_button
            // 
            this.users_button.AccessibleName = "Users Button";
            this.users_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.users_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.users_button.Location = new System.Drawing.Point(61, 339);
            this.users_button.Name = "users_button";
            this.users_button.Size = new System.Drawing.Size(152, 54);
            this.users_button.TabIndex = 12;
            this.users_button.Text = "Users";
            this.users_button.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.AccessibleName = "Test";
            this.ClientSize = new System.Drawing.Size(601, 422);
            this.Controls.Add(this.users_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.maintenance_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.request_button);
            this.Controls.Add(this.assets_button);
            this.Controls.Add(this.ticket_button);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ticket_button;
        private System.Windows.Forms.Button assets_button;
        private System.Windows.Forms.Button request_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button maintenance_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button users_button;
    }
}