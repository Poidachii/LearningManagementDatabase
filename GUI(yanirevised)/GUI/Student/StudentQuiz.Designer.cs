namespace GUI
{
    partial class StudentQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentQuiz));
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuestionNameTitleLabel = new System.Windows.Forms.Label();
            this.CourseNameTitleLabel = new System.Windows.Forms.Label();
            this.CourseNamePanel = new System.Windows.Forms.Panel();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.QuestionNamePanel = new System.Windows.Forms.Panel();
            this.QuestionNameLabel = new System.Windows.Forms.Label();
            this.QuizPanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.RadioGroup = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemTrackerLabel = new System.Windows.Forms.Label();
            this.NavBarTop = new System.Windows.Forms.TableLayoutPanel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.AccountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.CourseNamePanel.SuspendLayout();
            this.QuestionNamePanel.SuspendLayout();
            this.QuizPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.RadioGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NavBarTop.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconPictureBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.IconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.Image")));
            this.IconPictureBox.Location = new System.Drawing.Point(7, 70);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(100, 100);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 5;
            this.IconPictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(125, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "STUDENT - MENU";
            // 
            // QuestionNameTitleLabel
            // 
            this.QuestionNameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuestionNameTitleLabel.AutoSize = true;
            this.QuestionNameTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNameTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionNameTitleLabel.Location = new System.Drawing.Point(18, 14);
            this.QuestionNameTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionNameTitleLabel.Name = "QuestionNameTitleLabel";
            this.QuestionNameTitleLabel.Size = new System.Drawing.Size(187, 26);
            this.QuestionNameTitleLabel.TabIndex = 7;
            this.QuestionNameTitleLabel.Text = "QUESTION NAME:";
            // 
            // CourseNameTitleLabel
            // 
            this.CourseNameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CourseNameTitleLabel.AutoSize = true;
            this.CourseNameTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CourseNameTitleLabel.Location = new System.Drawing.Point(11, 14);
            this.CourseNameTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseNameTitleLabel.Name = "CourseNameTitleLabel";
            this.CourseNameTitleLabel.Size = new System.Drawing.Size(163, 26);
            this.CourseNameTitleLabel.TabIndex = 9;
            this.CourseNameTitleLabel.Text = "COURSE NAME:";
            // 
            // CourseNamePanel
            // 
            this.CourseNamePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.CourseNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CourseNamePanel.Controls.Add(this.CourseNameLabel);
            this.CourseNamePanel.Controls.Add(this.CourseNameTitleLabel);
            this.CourseNamePanel.Location = new System.Drawing.Point(112, 117);
            this.CourseNamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.CourseNamePanel.Name = "CourseNamePanel";
            this.CourseNamePanel.Size = new System.Drawing.Size(381, 53);
            this.CourseNamePanel.TabIndex = 10;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CourseNameLabel.Location = new System.Drawing.Point(178, 21);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(133, 17);
            this.CourseNameLabel.TabIndex = 10;
            this.CourseNameLabel.Text = "[InsertCourseName]";
            // 
            // QuestionNamePanel
            // 
            this.QuestionNamePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.QuestionNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuestionNamePanel.Controls.Add(this.QuestionNameLabel);
            this.QuestionNamePanel.Controls.Add(this.QuestionNameTitleLabel);
            this.QuestionNamePanel.Location = new System.Drawing.Point(588, 117);
            this.QuestionNamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.QuestionNamePanel.Name = "QuestionNamePanel";
            this.QuestionNamePanel.Size = new System.Drawing.Size(381, 53);
            this.QuestionNamePanel.TabIndex = 11;
            // 
            // QuestionNameLabel
            // 
            this.QuestionNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionNameLabel.AutoSize = true;
            this.QuestionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.QuestionNameLabel.Location = new System.Drawing.Point(209, 21);
            this.QuestionNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuestionNameLabel.Name = "QuestionNameLabel";
            this.QuestionNameLabel.Size = new System.Drawing.Size(145, 17);
            this.QuestionNameLabel.TabIndex = 8;
            this.QuestionNameLabel.Text = "[InsertQuestionName]";
            // 
            // QuizPanel
            // 
            this.QuizPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.QuizPanel.Controls.Add(this.SubmitButton);
            this.QuizPanel.Controls.Add(this.tableLayoutPanel1);
            this.QuizPanel.Controls.Add(this.NextButton);
            this.QuizPanel.Controls.Add(this.PreviousButton);
            this.QuizPanel.Location = new System.Drawing.Point(12, 209);
            this.QuizPanel.Name = "QuizPanel";
            this.QuizPanel.Size = new System.Drawing.Size(984, 508);
            this.QuizPanel.TabIndex = 12;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(735, 443);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(222, 53);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.QuestionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadioGroup, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 434);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionLabel.Location = new System.Drawing.Point(397, 96);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(183, 24);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "[InsertQuestionHere]";
            // 
            // RadioGroup
            // 
            this.RadioGroup.ColumnCount = 2;
            this.RadioGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioGroup.Controls.Add(this.radioButton1, 0, 0);
            this.RadioGroup.Controls.Add(this.radioButton2, 1, 0);
            this.RadioGroup.Controls.Add(this.radioButton3, 0, 1);
            this.RadioGroup.Controls.Add(this.radioButton4, 1, 1);
            this.RadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadioGroup.Location = new System.Drawing.Point(3, 220);
            this.RadioGroup.Name = "RadioGroup";
            this.RadioGroup.RowCount = 2;
            this.RadioGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioGroup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioGroup.Size = new System.Drawing.Size(972, 211);
            this.RadioGroup.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(150, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(186, 35);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(636, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 35);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(150, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(186, 35);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(636, 140);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(186, 35);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(381, 443);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(222, 53);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "NEXT";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.Location = new System.Drawing.Point(18, 443);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(222, 53);
            this.PreviousButton.TabIndex = 1;
            this.PreviousButton.Text = "PREVIOUS";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.ItemTrackerLabel);
            this.panel1.Location = new System.Drawing.Point(887, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 29);
            this.panel1.TabIndex = 13;
            // 
            // ItemTrackerLabel
            // 
            this.ItemTrackerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemTrackerLabel.AutoSize = true;
            this.ItemTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTrackerLabel.Location = new System.Drawing.Point(6, 2);
            this.ItemTrackerLabel.Name = "ItemTrackerLabel";
            this.ItemTrackerLabel.Size = new System.Drawing.Size(186, 24);
            this.ItemTrackerLabel.TabIndex = 0;
            this.ItemTrackerLabel.Text = "[CurrentItemNumber]";
            // 
            // NavBarTop
            // 
            this.NavBarTop.AutoSize = true;
            this.NavBarTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.NavBarTop.ColumnCount = 3;
            this.NavBarTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.NavBarTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.NavBarTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.NavBarTop.Controls.Add(this.HomeButton, 0, 0);
            this.NavBarTop.Controls.Add(this.label1, 0, 0);
            this.NavBarTop.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.NavBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBarTop.Location = new System.Drawing.Point(0, 0);
            this.NavBarTop.Name = "NavBarTop";
            this.NavBarTop.RowCount = 1;
            this.NavBarTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavBarTop.Size = new System.Drawing.Size(1008, 54);
            this.NavBarTop.TabIndex = 14;
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImage = global::GUI.Properties.Resources.img_66574;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(179, 2);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(86, 50);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT - QUIZ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.SignOutButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(787, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(218, 48);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SignOutButton.AutoSize = true;
            this.SignOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.Location = new System.Drawing.Point(142, 10);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(73, 27);
            this.SignOutButton.TabIndex = 5;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.button12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AccountLabel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(133, 42);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackgroundImage = global::GUI.Properties.Resources.account_logo_png_11;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(2, 2);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 38);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // AccountLabel
            // 
            this.AccountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.ForeColor = System.Drawing.Color.Transparent;
            this.AccountLabel.Location = new System.Drawing.Point(56, 12);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(75, 17);
            this.AccountLabel.TabIndex = 6;
            this.AccountLabel.Text = "ACCOUNT";
            // 
            // StudentQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.NavBarTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuizPanel);
            this.Controls.Add(this.QuestionNamePanel);
            this.Controls.Add(this.CourseNamePanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IconPictureBox);
            this.Name = "StudentQuiz";
            this.Text = "StudentQuiz";
            this.Load += new System.EventHandler(this.StudentQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.CourseNamePanel.ResumeLayout(false);
            this.CourseNamePanel.PerformLayout();
            this.QuestionNamePanel.ResumeLayout(false);
            this.QuestionNamePanel.PerformLayout();
            this.QuizPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.RadioGroup.ResumeLayout(false);
            this.RadioGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NavBarTop.ResumeLayout(false);
            this.NavBarTop.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label QuestionNameTitleLabel;
        private System.Windows.Forms.Label CourseNameTitleLabel;
        private System.Windows.Forms.Panel CourseNamePanel;
        private System.Windows.Forms.Panel QuestionNamePanel;
        private System.Windows.Forms.Panel QuizPanel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label QuestionNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TableLayoutPanel RadioGroup;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ItemTrackerLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TableLayoutPanel NavBarTop;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label AccountLabel;
    }
}