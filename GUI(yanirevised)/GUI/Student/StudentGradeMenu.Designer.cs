namespace GUI
{
    partial class StudentGradeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradeMenu));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentLogoutButton = new System.Windows.Forms.PictureBox();
            this.StudentGradeButton = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentHomeButton = new System.Windows.Forms.PictureBox();
            this.StudentCourseDropdown = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuizListView = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentLogoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGradeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentHomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(699, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Scores :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(225, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quiz :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(941, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "LOG-OUT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "GRADE";
            // 
            // StudentLogoutButton
            // 
            this.StudentLogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentLogoutButton.Image")));
            this.StudentLogoutButton.Location = new System.Drawing.Point(949, 12);
            this.StudentLogoutButton.Name = "StudentLogoutButton";
            this.StudentLogoutButton.Size = new System.Drawing.Size(37, 42);
            this.StudentLogoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentLogoutButton.TabIndex = 23;
            this.StudentLogoutButton.TabStop = false;
            this.StudentLogoutButton.Click += new System.EventHandler(this.StudentLogoutButton_Click);
            // 
            // StudentGradeButton
            // 
            this.StudentGradeButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentGradeButton.Image")));
            this.StudentGradeButton.Location = new System.Drawing.Point(229, 27);
            this.StudentGradeButton.Name = "StudentGradeButton";
            this.StudentGradeButton.Size = new System.Drawing.Size(37, 42);
            this.StudentGradeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentGradeButton.TabIndex = 21;
            this.StudentGradeButton.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "HOME";
            // 
            // StudentHomeButton
            // 
            this.StudentHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentHomeButton.Image")));
            this.StudentHomeButton.Location = new System.Drawing.Point(172, 27);
            this.StudentHomeButton.Name = "StudentHomeButton";
            this.StudentHomeButton.Size = new System.Drawing.Size(36, 42);
            this.StudentHomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentHomeButton.TabIndex = 19;
            this.StudentHomeButton.TabStop = false;
            this.StudentHomeButton.Click += new System.EventHandler(this.StudentHomeButton_Click);
            // 
            // StudentCourseDropdown
            // 
            this.StudentCourseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentCourseDropdown.FormattingEnabled = true;
            this.StudentCourseDropdown.Location = new System.Drawing.Point(257, 123);
            this.StudentCourseDropdown.Name = "StudentCourseDropdown";
            this.StudentCourseDropdown.Size = new System.Drawing.Size(614, 21);
            this.StudentCourseDropdown.TabIndex = 18;
            this.StudentCourseDropdown.SelectedIndexChanged += new System.EventHandler(this.StudentCourseDropdown_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(170, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Course :";
            // 
            // QuizListView
            // 
            this.QuizListView.GridLines = true;
            this.QuizListView.HideSelection = false;
            this.QuizListView.Location = new System.Drawing.Point(18, 186);
            this.QuizListView.Name = "QuizListView";
            this.QuizListView.Size = new System.Drawing.Size(483, 531);
            this.QuizListView.TabIndex = 3;
            this.QuizListView.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(503, 186);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(483, 531);
            this.listView2.TabIndex = 28;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // StudentGradeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.QuizListView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentLogoutButton);
            this.Controls.Add(this.StudentGradeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentHomeButton);
            this.Controls.Add(this.StudentCourseDropdown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "StudentGradeMenu";
            this.Text = "StudentGradeMenu";
            this.Load += new System.EventHandler(this.StudentGradeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentLogoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGradeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentHomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox StudentLogoutButton;
        private System.Windows.Forms.PictureBox StudentGradeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox StudentHomeButton;
        private System.Windows.Forms.ComboBox StudentCourseDropdown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView QuizListView;
        private System.Windows.Forms.ListView listView2;
    }
}