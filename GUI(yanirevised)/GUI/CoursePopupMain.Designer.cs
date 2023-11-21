namespace GUI
{
    partial class CoursePopupMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoursePopupMain));
            this.CoursePopupMainLabel1 = new System.Windows.Forms.Label();
            this.CoursePopupMainRemoveButton = new System.Windows.Forms.Button();
            this.CoursePopupMainAddButton = new System.Windows.Forms.Button();
            this.CoursePopupMainEditButton = new System.Windows.Forms.Button();
            this.CoursePopupMaindataGridView1 = new System.Windows.Forms.DataGridView();
            this.CoursePopupMainPicture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CoursePopupMaindataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursePopupMainPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursePopupMainLabel1
            // 
            this.CoursePopupMainLabel1.AutoSize = true;
            this.CoursePopupMainLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CoursePopupMainLabel1.Location = new System.Drawing.Point(250, 110);
            this.CoursePopupMainLabel1.Name = "CoursePopupMainLabel1";
            this.CoursePopupMainLabel1.Size = new System.Drawing.Size(91, 29);
            this.CoursePopupMainLabel1.TabIndex = 1;
            this.CoursePopupMainLabel1.Text = "Course";
            // 
            // CoursePopupMainRemoveButton
            // 
            this.CoursePopupMainRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoursePopupMainRemoveButton.Location = new System.Drawing.Point(411, 148);
            this.CoursePopupMainRemoveButton.Name = "CoursePopupMainRemoveButton";
            this.CoursePopupMainRemoveButton.Size = new System.Drawing.Size(161, 55);
            this.CoursePopupMainRemoveButton.TabIndex = 2;
            this.CoursePopupMainRemoveButton.Text = "Remove Course";
            this.CoursePopupMainRemoveButton.UseVisualStyleBackColor = true;
            // 
            // CoursePopupMainAddButton
            // 
            this.CoursePopupMainAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoursePopupMainAddButton.Location = new System.Drawing.Point(12, 148);
            this.CoursePopupMainAddButton.Name = "CoursePopupMainAddButton";
            this.CoursePopupMainAddButton.Size = new System.Drawing.Size(161, 55);
            this.CoursePopupMainAddButton.TabIndex = 3;
            this.CoursePopupMainAddButton.Text = "Add Course";
            this.CoursePopupMainAddButton.UseVisualStyleBackColor = true;
            // 
            // CoursePopupMainEditButton
            // 
            this.CoursePopupMainEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoursePopupMainEditButton.Location = new System.Drawing.Point(214, 148);
            this.CoursePopupMainEditButton.Name = "CoursePopupMainEditButton";
            this.CoursePopupMainEditButton.Size = new System.Drawing.Size(161, 55);
            this.CoursePopupMainEditButton.TabIndex = 4;
            this.CoursePopupMainEditButton.Text = "Edit Course";
            this.CoursePopupMainEditButton.UseVisualStyleBackColor = true;
            // 
            // CoursePopupMaindataGridView1
            // 
            this.CoursePopupMaindataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursePopupMaindataGridView1.Location = new System.Drawing.Point(12, 222);
            this.CoursePopupMaindataGridView1.Name = "CoursePopupMaindataGridView1";
            this.CoursePopupMaindataGridView1.Size = new System.Drawing.Size(560, 227);
            this.CoursePopupMaindataGridView1.TabIndex = 5;
            // 
            // CoursePopupMainPicture1
            // 
            this.CoursePopupMainPicture1.Image = ((System.Drawing.Image)(resources.GetObject("CoursePopupMainPicture1.Image")));
            this.CoursePopupMainPicture1.Location = new System.Drawing.Point(12, 12);
            this.CoursePopupMainPicture1.Name = "CoursePopupMainPicture1";
            this.CoursePopupMainPicture1.Size = new System.Drawing.Size(560, 90);
            this.CoursePopupMainPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CoursePopupMainPicture1.TabIndex = 0;
            this.CoursePopupMainPicture1.TabStop = false;
            // 
            // CoursePopupMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.CoursePopupMaindataGridView1);
            this.Controls.Add(this.CoursePopupMainEditButton);
            this.Controls.Add(this.CoursePopupMainAddButton);
            this.Controls.Add(this.CoursePopupMainRemoveButton);
            this.Controls.Add(this.CoursePopupMainLabel1);
            this.Controls.Add(this.CoursePopupMainPicture1);
            this.Name = "CoursePopupMain";
            this.Text = "CoursePopupMain";
            ((System.ComponentModel.ISupportInitialize)(this.CoursePopupMaindataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursePopupMainPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoursePopupMainPicture1;
        private System.Windows.Forms.Label CoursePopupMainLabel1;
        private System.Windows.Forms.Button CoursePopupMainRemoveButton;
        private System.Windows.Forms.Button CoursePopupMainAddButton;
        private System.Windows.Forms.Button CoursePopupMainEditButton;
        private System.Windows.Forms.DataGridView CoursePopupMaindataGridView1;
    }
}