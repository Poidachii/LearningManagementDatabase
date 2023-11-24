namespace GUI.Admin
{
    partial class AccountHandling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountHandling));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountDataViewer = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.AllListButton = new System.Windows.Forms.Button();
            this.AdminListButton = new System.Windows.Forms.Button();
            this.ProfessorListButton = new System.Windows.Forms.Button();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.SearchBarIcon = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataViewer)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBarIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 720);
            this.panel2.TabIndex = 53;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::GUI.Properties.Resources.MMCL_Logo_original;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(5, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(211, 111);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.HomeButton);
            this.panel4.Location = new System.Drawing.Point(0, 119);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 53);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "HOME";
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImage = global::GUI.Properties.Resources.img_66574;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(217, 50);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.SignOutButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 42);
            this.panel1.TabIndex = 52;
            // 
            // SignOutButton
            // 
            this.SignOutButton.Location = new System.Drawing.Point(1295, 11);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(56, 19);
            this.SignOutButton.TabIndex = 1;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN - ACCOUNT HANDLING";
            // 
            // AccountDataViewer
            // 
            this.AccountDataViewer.AllowUserToAddRows = false;
            this.AccountDataViewer.AllowUserToDeleteRows = false;
            this.AccountDataViewer.AllowUserToResizeColumns = false;
            this.AccountDataViewer.AllowUserToResizeRows = false;
            this.AccountDataViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataViewer.Location = new System.Drawing.Point(228, 99);
            this.AccountDataViewer.Name = "AccountDataViewer";
            this.AccountDataViewer.RowHeadersWidth = 51;
            this.AccountDataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDataViewer.Size = new System.Drawing.Size(1144, 650);
            this.AccountDataViewer.TabIndex = 55;
            this.AccountDataViewer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDataViewer_CellDoubleClick);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Controls.Add(this.AllListButton);
            this.panel15.Controls.Add(this.AdminListButton);
            this.panel15.Controls.Add(this.ProfessorListButton);
            this.panel15.Controls.Add(this.StudentListButton);
            this.panel15.Controls.Add(this.SearchBarIcon);
            this.panel15.Controls.Add(this.SearchBar);
            this.panel15.Controls.Add(this.AddButton);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(225, 46);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1147, 48);
            this.panel15.TabIndex = 54;
            // 
            // AllListButton
            // 
            this.AllListButton.Location = new System.Drawing.Point(592, 10);
            this.AllListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AllListButton.Name = "AllListButton";
            this.AllListButton.Size = new System.Drawing.Size(82, 25);
            this.AllListButton.TabIndex = 8;
            this.AllListButton.Text = "All";
            this.AllListButton.UseVisualStyleBackColor = true;
            this.AllListButton.Click += new System.EventHandler(this.AllListButton_Click);
            // 
            // AdminListButton
            // 
            this.AdminListButton.Location = new System.Drawing.Point(506, 9);
            this.AdminListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminListButton.Name = "AdminListButton";
            this.AdminListButton.Size = new System.Drawing.Size(82, 25);
            this.AdminListButton.TabIndex = 7;
            this.AdminListButton.Text = "Admin List";
            this.AdminListButton.UseVisualStyleBackColor = true;
            this.AdminListButton.Click += new System.EventHandler(this.AdminListButton_Click);
            // 
            // ProfessorListButton
            // 
            this.ProfessorListButton.Location = new System.Drawing.Point(410, 7);
            this.ProfessorListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfessorListButton.Name = "ProfessorListButton";
            this.ProfessorListButton.Size = new System.Drawing.Size(91, 28);
            this.ProfessorListButton.TabIndex = 6;
            this.ProfessorListButton.Text = "Professor List";
            this.ProfessorListButton.UseVisualStyleBackColor = true;
            this.ProfessorListButton.Click += new System.EventHandler(this.ProfessorListButton_Click);
            // 
            // StudentListButton
            // 
            this.StudentListButton.Location = new System.Drawing.Point(310, 7);
            this.StudentListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(95, 28);
            this.StudentListButton.TabIndex = 5;
            this.StudentListButton.Text = "Student List";
            this.StudentListButton.UseVisualStyleBackColor = true;
            this.StudentListButton.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // SearchBarIcon
            // 
            this.SearchBarIcon.BackColor = System.Drawing.Color.Transparent;
            this.SearchBarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBarIcon.Enabled = false;
            this.SearchBarIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchBarIcon.Image")));
            this.SearchBarIcon.InitialImage = null;
            this.SearchBarIcon.Location = new System.Drawing.Point(1115, 7);
            this.SearchBarIcon.Name = "SearchBarIcon";
            this.SearchBarIcon.Size = new System.Drawing.Size(25, 28);
            this.SearchBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchBarIcon.TabIndex = 4;
            this.SearchBarIcon.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(827, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(282, 20);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.AliceBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(152, 9);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 26);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Account List";
            // 
            // AccountHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.AccountDataViewer);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AccountHandling";
            this.Text = "AccountHandling";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataViewer)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBarIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AccountDataViewer;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox SearchBarIcon;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button AllListButton;
        private System.Windows.Forms.Button AdminListButton;
        private System.Windows.Forms.Button ProfessorListButton;
        private System.Windows.Forms.Button StudentListButton;
        private System.Windows.Forms.Button SignOutButton;
    }
}