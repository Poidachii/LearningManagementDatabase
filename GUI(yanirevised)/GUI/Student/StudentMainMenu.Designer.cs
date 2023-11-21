namespace GUI
{
    partial class StudentMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentCourseDropdown = new System.Windows.Forms.ComboBox();
            this.StudentHomeButton = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentGradeButton = new System.Windows.Forms.PictureBox();
            this.StudentCalendarButton = new System.Windows.Forms.PictureBox();
            this.StudentLogoutButton = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentHomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGradeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCalendarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentLogoutButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(311, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(66, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Materials :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(370, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quizzes :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StudentCourseDropdown
            // 
            this.StudentCourseDropdown.FormattingEnabled = true;
            this.StudentCourseDropdown.Location = new System.Drawing.Point(398, 117);
            this.StudentCourseDropdown.Name = "StudentCourseDropdown";
            this.StudentCourseDropdown.Size = new System.Drawing.Size(173, 21);
            this.StudentCourseDropdown.TabIndex = 5;
            this.StudentCourseDropdown.SelectedIndexChanged += new System.EventHandler(this.StudentCourseDropdown_SelectedIndexChanged);
            // 
            // StudentHomeButton
            // 
            this.StudentHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentHomeButton.Image")));
            this.StudentHomeButton.Location = new System.Drawing.Point(168, 12);
            this.StudentHomeButton.Name = "StudentHomeButton";
            this.StudentHomeButton.Size = new System.Drawing.Size(36, 42);
            this.StudentHomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentHomeButton.TabIndex = 8;
            this.StudentHomeButton.TabStop = false;
            this.StudentHomeButton.Click += new System.EventHandler(this.StudentHomeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "HOME";
            // 
            // StudentGradeButton
            // 
            this.StudentGradeButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentGradeButton.Image")));
            this.StudentGradeButton.Location = new System.Drawing.Point(225, 12);
            this.StudentGradeButton.Name = "StudentGradeButton";
            this.StudentGradeButton.Size = new System.Drawing.Size(37, 42);
            this.StudentGradeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentGradeButton.TabIndex = 10;
            this.StudentGradeButton.TabStop = false;
            this.StudentGradeButton.Click += new System.EventHandler(this.StudentGradeButton_Click);
            // 
            // StudentCalendarButton
            // 
            this.StudentCalendarButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentCalendarButton.Image")));
            this.StudentCalendarButton.Location = new System.Drawing.Point(289, 12);
            this.StudentCalendarButton.Name = "StudentCalendarButton";
            this.StudentCalendarButton.Size = new System.Drawing.Size(37, 42);
            this.StudentCalendarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentCalendarButton.TabIndex = 11;
            this.StudentCalendarButton.TabStop = false;
            this.StudentCalendarButton.Click += new System.EventHandler(this.StudentCalendarButton_Click);
            // 
            // StudentLogoutButton
            // 
            this.StudentLogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentLogoutButton.Image")));
            this.StudentLogoutButton.Location = new System.Drawing.Point(533, 12);
            this.StudentLogoutButton.Name = "StudentLogoutButton";
            this.StudentLogoutButton.Size = new System.Drawing.Size(37, 42);
            this.StudentLogoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentLogoutButton.TabIndex = 12;
            this.StudentLogoutButton.TabStop = false;
            this.StudentLogoutButton.Click += new System.EventHandler(this.StudentLogoutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "GRADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CALENDAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "LOG-OUT";
            // 
            // StudentMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentLogoutButton);
            this.Controls.Add(this.StudentCalendarButton);
            this.Controls.Add(this.StudentGradeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentHomeButton);
            this.Controls.Add(this.StudentCourseDropdown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentMainMenu";
            this.Text = "StudentMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentHomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGradeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCalendarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentLogoutButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox StudentCourseDropdown;
        private System.Windows.Forms.PictureBox StudentHomeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox StudentGradeButton;
        private System.Windows.Forms.PictureBox StudentCalendarButton;
        private System.Windows.Forms.PictureBox StudentLogoutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}