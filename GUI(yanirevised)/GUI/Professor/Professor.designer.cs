namespace GUI
{
    partial class Professor
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
            this.FrontEndPanel = new System.Windows.Forms.Panel();
            this.CourseListLabel = new System.Windows.Forms.Label();
            this.CourseListComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GradePanel = new System.Windows.Forms.Panel();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeButton = new System.Windows.Forms.Button();
            this.CoursePanel = new System.Windows.Forms.Panel();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.CourseButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseLabel1 = new System.Windows.Forms.Label();
            this.QuizLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuizRemoveButton = new System.Windows.Forms.Button();
            this.QuizUpdateButton = new System.Windows.Forms.Button();
            this.QuizAddButton = new System.Windows.Forms.Button();
            this.CourseRemoveButton = new System.Windows.Forms.Button();
            this.CourseUpdateButton = new System.Windows.Forms.Button();
            this.CourseAddButton = new System.Windows.Forms.Button();
            this.FrontEndPanelVertical = new System.Windows.Forms.Panel();
            this.FrontEndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.GradePanel.SuspendLayout();
            this.CoursePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrontEndPanel
            // 
            this.FrontEndPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.FrontEndPanel.Controls.Add(this.CourseListLabel);
            this.FrontEndPanel.Controls.Add(this.CourseListComboBox);
            this.FrontEndPanel.Controls.Add(this.pictureBox6);
            this.FrontEndPanel.Controls.Add(this.HomePanel);
            this.FrontEndPanel.Controls.Add(this.GradePanel);
            this.FrontEndPanel.Controls.Add(this.CoursePanel);
            this.FrontEndPanel.Location = new System.Drawing.Point(0, 42);
            this.FrontEndPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FrontEndPanel.Name = "FrontEndPanel";
            this.FrontEndPanel.Size = new System.Drawing.Size(1385, 120);
            this.FrontEndPanel.TabIndex = 52;
            // 
            // CourseListLabel
            // 
            this.CourseListLabel.AutoSize = true;
            this.CourseListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseListLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CourseListLabel.Location = new System.Drawing.Point(918, 10);
            this.CourseListLabel.Name = "CourseListLabel";
            this.CourseListLabel.Size = new System.Drawing.Size(344, 55);
            this.CourseListLabel.TabIndex = 19;
            this.CourseListLabel.Text = "COURSE LIST";
            // 
            // CourseListComboBox
            // 
            this.CourseListComboBox.FormattingEnabled = true;
            this.CourseListComboBox.Location = new System.Drawing.Point(928, 77);
            this.CourseListComboBox.Name = "CourseListComboBox";
            this.CourseListComboBox.Size = new System.Drawing.Size(445, 21);
            this.CourseListComboBox.TabIndex = 18;
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
            // CourseLabel1
            // 
            this.CourseLabel1.AutoSize = true;
            this.CourseLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CourseLabel1.Location = new System.Drawing.Point(199, 174);
            this.CourseLabel1.Name = "CourseLabel1";
            this.CourseLabel1.Size = new System.Drawing.Size(230, 55);
            this.CourseLabel1.TabIndex = 20;
            this.CourseLabel1.Text = "COURSE";
            // 
            // QuizLabel
            // 
            this.QuizLabel.AutoSize = true;
            this.QuizLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuizLabel.Location = new System.Drawing.Point(1008, 174);
            this.QuizLabel.Name = "QuizLabel";
            this.QuizLabel.Size = new System.Drawing.Size(138, 55);
            this.QuizLabel.TabIndex = 53;
            this.QuizLabel.Text = "QUIZ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.QuizRemoveButton);
            this.panel2.Controls.Add(this.QuizUpdateButton);
            this.panel2.Controls.Add(this.QuizAddButton);
            this.panel2.Controls.Add(this.CourseRemoveButton);
            this.panel2.Controls.Add(this.CourseUpdateButton);
            this.panel2.Controls.Add(this.CourseAddButton);
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1385, 50);
            this.panel2.TabIndex = 53;
            // 
            // QuizRemoveButton
            // 
            this.QuizRemoveButton.Location = new System.Drawing.Point(1236, 13);
            this.QuizRemoveButton.Name = "QuizRemoveButton";
            this.QuizRemoveButton.Size = new System.Drawing.Size(112, 26);
            this.QuizRemoveButton.TabIndex = 5;
            this.QuizRemoveButton.Text = "REMOVE";
            this.QuizRemoveButton.UseVisualStyleBackColor = true;
            // 
            // QuizUpdateButton
            // 
            this.QuizUpdateButton.Location = new System.Drawing.Point(1008, 13);
            this.QuizUpdateButton.Name = "QuizUpdateButton";
            this.QuizUpdateButton.Size = new System.Drawing.Size(112, 26);
            this.QuizUpdateButton.TabIndex = 4;
            this.QuizUpdateButton.Text = "UPDATE";
            this.QuizUpdateButton.UseVisualStyleBackColor = true;
            // 
            // QuizAddButton
            // 
            this.QuizAddButton.Location = new System.Drawing.Point(785, 13);
            this.QuizAddButton.Name = "QuizAddButton";
            this.QuizAddButton.Size = new System.Drawing.Size(112, 26);
            this.QuizAddButton.TabIndex = 3;
            this.QuizAddButton.Text = "ADD";
            this.QuizAddButton.UseVisualStyleBackColor = true;
            // 
            // CourseRemoveButton
            // 
            this.CourseRemoveButton.Location = new System.Drawing.Point(471, 13);
            this.CourseRemoveButton.Name = "CourseRemoveButton";
            this.CourseRemoveButton.Size = new System.Drawing.Size(112, 26);
            this.CourseRemoveButton.TabIndex = 2;
            this.CourseRemoveButton.Text = "REMOVE";
            this.CourseRemoveButton.UseVisualStyleBackColor = true;
            // 
            // CourseUpdateButton
            // 
            this.CourseUpdateButton.Location = new System.Drawing.Point(243, 13);
            this.CourseUpdateButton.Name = "CourseUpdateButton";
            this.CourseUpdateButton.Size = new System.Drawing.Size(112, 26);
            this.CourseUpdateButton.TabIndex = 1;
            this.CourseUpdateButton.Text = "UPDATE";
            this.CourseUpdateButton.UseVisualStyleBackColor = true;
            // 
            // CourseAddButton
            // 
            this.CourseAddButton.Location = new System.Drawing.Point(20, 13);
            this.CourseAddButton.Name = "CourseAddButton";
            this.CourseAddButton.Size = new System.Drawing.Size(112, 26);
            this.CourseAddButton.TabIndex = 0;
            this.CourseAddButton.Text = "ADD";
            this.CourseAddButton.UseVisualStyleBackColor = true;
            // 
            // FrontEndPanelVertical
            // 
            this.FrontEndPanelVertical.BackColor = System.Drawing.Color.MidnightBlue;
            this.FrontEndPanelVertical.Location = new System.Drawing.Point(700, 162);
            this.FrontEndPanelVertical.Margin = new System.Windows.Forms.Padding(2);
            this.FrontEndPanelVertical.Name = "FrontEndPanelVertical";
            this.FrontEndPanelVertical.Size = new System.Drawing.Size(50, 550);
            this.FrontEndPanelVertical.TabIndex = 54;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.FrontEndPanelVertical);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.QuizLabel);
            this.Controls.Add(this.CourseLabel1);
            this.Controls.Add(this.FrontEndPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Professor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.FrontEndPanel.ResumeLayout(false);
            this.FrontEndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.GradePanel.ResumeLayout(false);
            this.GradePanel.PerformLayout();
            this.CoursePanel.ResumeLayout(false);
            this.CoursePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FrontEndPanel;
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
        private System.Windows.Forms.Label CourseListLabel;
        private System.Windows.Forms.ComboBox CourseListComboBox;
        private System.Windows.Forms.Label CourseLabel1;
        private System.Windows.Forms.Label QuizLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel FrontEndPanelVertical;
        private System.Windows.Forms.Button QuizRemoveButton;
        private System.Windows.Forms.Button QuizUpdateButton;
        private System.Windows.Forms.Button QuizAddButton;
        private System.Windows.Forms.Button CourseRemoveButton;
        private System.Windows.Forms.Button CourseUpdateButton;
        private System.Windows.Forms.Button CourseAddButton;
    }
}