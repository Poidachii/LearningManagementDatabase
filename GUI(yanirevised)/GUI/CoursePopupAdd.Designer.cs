namespace GUI
{
    partial class CoursePopupAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursePopupAdd));
            this.CoursePopupAddlabel1 = new System.Windows.Forms.Label();
            this.CoursePopupAddPicture1 = new System.Windows.Forms.PictureBox();
            this.CoursePopupAddlabel2 = new System.Windows.Forms.Label();
            this.CoursePopupAddtextBox1 = new System.Windows.Forms.TextBox();
            this.CoursePopupAddCourseButton = new System.Windows.Forms.Button();
            this.CoursePopupUpdateCourseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoursePopupAddPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursePopupAddlabel1
            // 
            this.CoursePopupAddlabel1.AutoSize = true;
            this.CoursePopupAddlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CoursePopupAddlabel1.Location = new System.Drawing.Point(250, 110);
            this.CoursePopupAddlabel1.Name = "CoursePopupAddlabel1";
            this.CoursePopupAddlabel1.Size = new System.Drawing.Size(91, 29);
            this.CoursePopupAddlabel1.TabIndex = 3;
            this.CoursePopupAddlabel1.Text = "Course";
            // 
            // CoursePopupAddPicture1
            // 
            this.CoursePopupAddPicture1.Image = ((System.Drawing.Image)(resources.GetObject("CoursePopupAddPicture1.Image")));
            this.CoursePopupAddPicture1.Location = new System.Drawing.Point(12, 12);
            this.CoursePopupAddPicture1.Name = "CoursePopupAddPicture1";
            this.CoursePopupAddPicture1.Size = new System.Drawing.Size(560, 90);
            this.CoursePopupAddPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoursePopupAddPicture1.TabIndex = 2;
            this.CoursePopupAddPicture1.TabStop = false;
            // 
            // CoursePopupAddlabel2
            // 
            this.CoursePopupAddlabel2.AutoSize = true;
            this.CoursePopupAddlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CoursePopupAddlabel2.Location = new System.Drawing.Point(12, 181);
            this.CoursePopupAddlabel2.Name = "CoursePopupAddlabel2";
            this.CoursePopupAddlabel2.Size = new System.Drawing.Size(174, 29);
            this.CoursePopupAddlabel2.TabIndex = 4;
            this.CoursePopupAddlabel2.Text = "Course Name :";
            // 
            // CoursePopupAddtextBox1
            // 
            this.CoursePopupAddtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoursePopupAddtextBox1.Location = new System.Drawing.Point(192, 182);
            this.CoursePopupAddtextBox1.Name = "CoursePopupAddtextBox1";
            this.CoursePopupAddtextBox1.Size = new System.Drawing.Size(379, 29);
            this.CoursePopupAddtextBox1.TabIndex = 5;
            // 
            // CoursePopupAddCourseButton
            // 
            this.CoursePopupAddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoursePopupAddCourseButton.Location = new System.Drawing.Point(205, 281);
            this.CoursePopupAddCourseButton.Name = "CoursePopupAddCourseButton";
            this.CoursePopupAddCourseButton.Size = new System.Drawing.Size(183, 50);
            this.CoursePopupAddCourseButton.TabIndex = 6;
            this.CoursePopupAddCourseButton.Text = "Add Course";
            this.CoursePopupAddCourseButton.UseVisualStyleBackColor = true;
            this.CoursePopupAddCourseButton.Click += new System.EventHandler(this.CoursePopupAddCourseButton_Click);
            // 
            // CoursePopupUpdateCourseButton
            // 
            this.CoursePopupUpdateCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoursePopupUpdateCourseButton.Location = new System.Drawing.Point(205, 350);
            this.CoursePopupUpdateCourseButton.Name = "CoursePopupUpdateCourseButton";
            this.CoursePopupUpdateCourseButton.Size = new System.Drawing.Size(183, 50);
            this.CoursePopupUpdateCourseButton.TabIndex = 7;
            this.CoursePopupUpdateCourseButton.Text = "Update Course";
            this.CoursePopupUpdateCourseButton.UseVisualStyleBackColor = true;
            this.CoursePopupUpdateCourseButton.Click += new System.EventHandler(this.CoursePopupUpdateCourseButton_Click);
            // 
            // CoursePopupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.CoursePopupUpdateCourseButton);
            this.Controls.Add(this.CoursePopupAddCourseButton);
            this.Controls.Add(this.CoursePopupAddtextBox1);
            this.Controls.Add(this.CoursePopupAddlabel2);
            this.Controls.Add(this.CoursePopupAddlabel1);
            this.Controls.Add(this.CoursePopupAddPicture1);
            this.Name = "CoursePopupAdd";
            this.Text = "CoursePopupAdd";
            ((System.ComponentModel.ISupportInitialize)(this.CoursePopupAddPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoursePopupAddlabel1;
        private System.Windows.Forms.PictureBox CoursePopupAddPicture1;
        private System.Windows.Forms.Label CoursePopupAddlabel2;
        private System.Windows.Forms.TextBox CoursePopupAddtextBox1;
        private System.Windows.Forms.Button CoursePopupAddCourseButton;
        private System.Windows.Forms.Button CoursePopupUpdateCourseButton;
    }
}