namespace GUI
{
    partial class Profesor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.GradePanel = new System.Windows.Forms.Panel();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.CoursePanel = new System.Windows.Forms.Panel();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SignOutButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GradeButton = new System.Windows.Forms.Button();
            this.CourseButton = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.GradePanel.SuspendLayout();
            this.CoursePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.HomePanel);
            this.panel2.Controls.Add(this.GradePanel);
            this.panel2.Controls.Add(this.CoursePanel);
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1385, 120);
            this.panel2.TabIndex = 52;
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HomePanel.Controls.Add(this.HomeLabel);
            this.HomePanel.Controls.Add(this.HomeButton);
            this.HomePanel.Location = new System.Drawing.Point(220, 4);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(222, 53);
            this.HomePanel.TabIndex = 2;
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Location = new System.Drawing.Point(2, 2);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(44, 15);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "HOME";
            // 
            // GradePanel
            // 
            this.GradePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.GradePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GradePanel.Controls.Add(this.GradeLabel);
            this.GradePanel.Controls.Add(this.GradeButton);
            this.GradePanel.Location = new System.Drawing.Point(446, 4);
            this.GradePanel.Margin = new System.Windows.Forms.Padding(2);
            this.GradePanel.Name = "GradePanel";
            this.GradePanel.Size = new System.Drawing.Size(222, 53);
            this.GradePanel.TabIndex = 3;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GradeLabel.Location = new System.Drawing.Point(2, 2);
            this.GradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(57, 15);
            this.GradeLabel.TabIndex = 5;
            this.GradeLabel.Text = "GRADES";
            // 
            // CoursePanel
            // 
            this.CoursePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.CoursePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CoursePanel.Controls.Add(this.CourseLabel);
            this.CoursePanel.Controls.Add(this.CourseButton);
            this.CoursePanel.Location = new System.Drawing.Point(672, 5);
            this.CoursePanel.Margin = new System.Windows.Forms.Padding(2);
            this.CoursePanel.Name = "CoursePanel";
            this.CoursePanel.Size = new System.Drawing.Size(222, 53);
            this.CoursePanel.TabIndex = 3;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CourseLabel.Location = new System.Drawing.Point(0, 1);
            this.CourseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(66, 15);
            this.CourseLabel.TabIndex = 3;
            this.CourseLabel.Text = "COURSES";
            // 
            // SignOutButton
            // 
            this.SignOutButton.AutoSize = true;
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignOutButton.Location = new System.Drawing.Point(1309, 14);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(64, 15);
            this.SignOutButton.TabIndex = 6;
            this.SignOutButton.Text = "SIGN OUT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.SignOutButton);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 42);
            this.panel1.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1227, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROF - MENU";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::GUI.Properties.Resources.MMCL_Logo_original;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(5, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(211, 111);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImage = global::GUI.Properties.Resources.img_66574;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(2, 2);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(215, 45);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // GradeButton
            // 
            this.GradeButton.BackgroundImage = global::GUI.Properties.Resources._6343947;
            this.GradeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradeButton.Location = new System.Drawing.Point(1, 2);
            this.GradeButton.Margin = new System.Windows.Forms.Padding(2);
            this.GradeButton.Name = "GradeButton";
            this.GradeButton.Size = new System.Drawing.Size(215, 45);
            this.GradeButton.TabIndex = 9;
            this.GradeButton.UseVisualStyleBackColor = true;
            // 
            // CourseButton
            // 
            this.CourseButton.BackgroundImage = global::GUI.Properties.Resources.img_179623;
            this.CourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseButton.Location = new System.Drawing.Point(2, 2);
            this.CourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CourseButton.Name = "CourseButton";
            this.CourseButton.Size = new System.Drawing.Size(214, 45);
            this.CourseButton.TabIndex = 6;
            this.CourseButton.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::GUI.Properties.Resources.account_logo_png_11;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(1173, 2);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 38);
            this.button12.TabIndex = 4;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(927, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(917, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 55);
            this.label2.TabIndex = 19;
            this.label2.Text = "Course List";
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.GradePanel.ResumeLayout(false);
            this.GradePanel.PerformLayout();
            this.CoursePanel.ResumeLayout(false);
            this.CoursePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel GradePanel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Panel CoursePanel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Button CourseButton;
        private System.Windows.Forms.Label SignOutButton;
        private System.Windows.Forms.Button GradeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}