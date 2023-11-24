
namespace GUI.Admin
{
    partial class AdminMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CourseHandleButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccountHandleButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.AccountHandlingPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.AllListButton = new System.Windows.Forms.Button();
            this.AdminListButton = new System.Windows.Forms.Button();
            this.ProfessorListButton = new System.Windows.Forms.Button();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.AccountViewGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.AccountHandlingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.SignOutButton);
            this.panel1.Controls.Add(this.AccountLabel);
            this.panel1.Controls.Add(this.MenuLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 50);
            this.panel1.TabIndex = 25;
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Location = new System.Drawing.Point(1180, 5);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(200, 40);
            this.SignOutButton.TabIndex = 4;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // AccountLabel
            // 
            this.AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountLabel.ForeColor = System.Drawing.Color.Transparent;
            this.AccountLabel.Location = new System.Drawing.Point(875, 5);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(300, 40);
            this.AccountLabel.TabIndex = 3;
            this.AccountLabel.Text = "WELCOME, <NAME>";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuLabel.Location = new System.Drawing.Point(5, 6);
            this.MenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(165, 26);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "ADMIN - MENU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 720);
            this.panel2.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.CourseHandleButton);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(5, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 50);
            this.panel4.TabIndex = 53;
            // 
            // CourseHandleButton
            // 
            this.CourseHandleButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CourseHandleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseHandleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CourseHandleButton.Location = new System.Drawing.Point(50, 5);
            this.CourseHandleButton.Margin = new System.Windows.Forms.Padding(2);
            this.CourseHandleButton.Name = "CourseHandleButton";
            this.CourseHandleButton.Size = new System.Drawing.Size(235, 40);
            this.CourseHandleButton.TabIndex = 0;
            this.CourseHandleButton.Text = "Course Handling";
            this.CourseHandleButton.UseVisualStyleBackColor = false;
            this.CourseHandleButton.Click += new System.EventHandler(this.CourseButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.course_management;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.AccountHandleButton);
            this.panel3.Location = new System.Drawing.Point(5, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 50);
            this.panel3.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.acc_handling;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AccountHandleButton
            // 
            this.AccountHandleButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AccountHandleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountHandleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountHandleButton.Location = new System.Drawing.Point(50, 5);
            this.AccountHandleButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccountHandleButton.Name = "AccountHandleButton";
            this.AccountHandleButton.Size = new System.Drawing.Size(235, 40);
            this.AccountHandleButton.TabIndex = 1;
            this.AccountHandleButton.Text = "Account Handling";
            this.AccountHandleButton.UseVisualStyleBackColor = false;
            this.AccountHandleButton.Click += new System.EventHandler(this.AccountHandleButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::GUI.Properties.Resources.MMCL_Logo_original;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(10, 10);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(280, 162);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // AccountHandlingPanel
            // 
            this.AccountHandlingPanel.Controls.Add(this.pictureBox3);
            this.AccountHandlingPanel.Controls.Add(this.SearchBar);
            this.AccountHandlingPanel.Controls.Add(this.AllListButton);
            this.AccountHandlingPanel.Controls.Add(this.AdminListButton);
            this.AccountHandlingPanel.Controls.Add(this.ProfessorListButton);
            this.AccountHandlingPanel.Controls.Add(this.StudentListButton);
            this.AccountHandlingPanel.Controls.Add(this.AccountViewGrid);
            this.AccountHandlingPanel.Location = new System.Drawing.Point(300, 50);
            this.AccountHandlingPanel.Name = "AccountHandlingPanel";
            this.AccountHandlingPanel.Size = new System.Drawing.Size(1100, 750);
            this.AccountHandlingPanel.TabIndex = 52;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI.Properties.Resources.status;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1030, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchBar.Location = new System.Drawing.Point(829, 56);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(195, 38);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // AllListButton
            // 
            this.AllListButton.BackColor = System.Drawing.Color.White;
            this.AllListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AllListButton.Location = new System.Drawing.Point(455, 70);
            this.AllListButton.Name = "AllListButton";
            this.AllListButton.Size = new System.Drawing.Size(150, 30);
            this.AllListButton.TabIndex = 4;
            this.AllListButton.Text = "All";
            this.AllListButton.UseVisualStyleBackColor = false;
            this.AllListButton.Click += new System.EventHandler(this.AllListButton_Click);
            // 
            // AdminListButton
            // 
            this.AdminListButton.BackColor = System.Drawing.Color.White;
            this.AdminListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdminListButton.Location = new System.Drawing.Point(305, 70);
            this.AdminListButton.Name = "AdminListButton";
            this.AdminListButton.Size = new System.Drawing.Size(150, 30);
            this.AdminListButton.TabIndex = 3;
            this.AdminListButton.Text = "Admin List";
            this.AdminListButton.UseVisualStyleBackColor = false;
            this.AdminListButton.Click += new System.EventHandler(this.AdminListButton_Click);
            // 
            // ProfessorListButton
            // 
            this.ProfessorListButton.BackColor = System.Drawing.Color.White;
            this.ProfessorListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfessorListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProfessorListButton.Location = new System.Drawing.Point(155, 70);
            this.ProfessorListButton.Name = "ProfessorListButton";
            this.ProfessorListButton.Size = new System.Drawing.Size(150, 30);
            this.ProfessorListButton.TabIndex = 2;
            this.ProfessorListButton.Text = "Professor List";
            this.ProfessorListButton.UseVisualStyleBackColor = false;
            this.ProfessorListButton.Click += new System.EventHandler(this.ProfessorListButton_Click);
            // 
            // StudentListButton
            // 
            this.StudentListButton.BackColor = System.Drawing.Color.White;
            this.StudentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentListButton.Location = new System.Drawing.Point(5, 70);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(150, 30);
            this.StudentListButton.TabIndex = 1;
            this.StudentListButton.Text = "Student List";
            this.StudentListButton.UseVisualStyleBackColor = false;
            this.StudentListButton.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // AccountViewGrid
            // 
            this.AccountViewGrid.AllowUserToAddRows = false;
            this.AccountViewGrid.AllowUserToDeleteRows = false;
            this.AccountViewGrid.AllowUserToResizeColumns = false;
            this.AccountViewGrid.AllowUserToResizeRows = false;
            this.AccountViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountViewGrid.BackgroundColor = System.Drawing.Color.White;
            this.AccountViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountViewGrid.Location = new System.Drawing.Point(5, 100);
            this.AccountViewGrid.Name = "AccountViewGrid";
            this.AccountViewGrid.Size = new System.Drawing.Size(1075, 605);
            this.AccountViewGrid.TabIndex = 0;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.AccountHandlingPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.AccountHandlingPanel.ResumeLayout(false);
            this.AccountHandlingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button AccountHandleButton;
        private System.Windows.Forms.Button CourseHandleButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel AccountHandlingPanel;
        private System.Windows.Forms.DataGridView AccountViewGrid;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button AllListButton;
        private System.Windows.Forms.Button AdminListButton;
        private System.Windows.Forms.Button ProfessorListButton;
        private System.Windows.Forms.Button StudentListButton;
    }
}