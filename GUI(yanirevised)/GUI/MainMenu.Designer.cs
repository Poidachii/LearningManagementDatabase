namespace GUI
{
    partial class MainMenu
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
            this.MCLLogoPicture = new System.Windows.Forms.PictureBox();
            this.MCLPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WelcomeLabel2 = new System.Windows.Forms.Label();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.WelcomeLabel1 = new System.Windows.Forms.Label();
            this.LinksLabel3 = new System.Windows.Forms.Label();
            this.BlackboardAppButton = new System.Windows.Forms.Button();
            this.LinksLabel2 = new System.Windows.Forms.Label();
            this.OneMCLButton = new System.Windows.Forms.Button();
            this.LinksLabel1 = new System.Windows.Forms.Label();
            this.LinksPanel = new System.Windows.Forms.Panel();
            this.UserBoxPicture = new System.Windows.Forms.PictureBox();
            this.PassBoxPicture = new System.Windows.Forms.PictureBox();
            this.LoginLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PasswordLoginField = new System.Windows.Forms.TextBox();
            this.LoginLabel1 = new System.Windows.Forms.Label();
            this.UsernameLoginField = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MCLLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCLPicture)).BeginInit();
            this.WelcomePanel.SuspendLayout();
            this.LinksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserBoxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBoxPicture)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MCLLogoPicture
            // 
            this.MCLLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.MCLLogoPicture.ErrorImage = null;
            this.MCLLogoPicture.Image = global::GUI.Properties.Resources._377791715_353741580427885_4740537056986506792_n;
            this.MCLLogoPicture.Location = new System.Drawing.Point(500, 50);
            this.MCLLogoPicture.Name = "MCLLogoPicture";
            this.MCLLogoPicture.Size = new System.Drawing.Size(500, 150);
            this.MCLLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MCLLogoPicture.TabIndex = 20;
            this.MCLLogoPicture.TabStop = false;
            // 
            // MCLPicture
            // 
            this.MCLPicture.ErrorImage = null;
            this.MCLPicture.Image = global::GUI.Properties.Resources._379403150_733893148561620_6045000477614317198_n;
            this.MCLPicture.Location = new System.Drawing.Point(0, 80);
            this.MCLPicture.Name = "MCLPicture";
            this.MCLPicture.Size = new System.Drawing.Size(400, 130);
            this.MCLPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MCLPicture.TabIndex = 15;
            this.MCLPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(50, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "View course catalog";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WelcomeLabel2
            // 
            this.WelcomeLabel2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel2.Location = new System.Drawing.Point(125, 210);
            this.WelcomeLabel2.Name = "WelcomeLabel2";
            this.WelcomeLabel2.Size = new System.Drawing.Size(150, 15);
            this.WelcomeLabel2.TabIndex = 14;
            this.WelcomeLabel2.Text = "powered by blackboard";
            this.WelcomeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.WelcomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WelcomePanel.Controls.Add(this.MCLPicture);
            this.WelcomePanel.Controls.Add(this.button1);
            this.WelcomePanel.Controls.Add(this.WelcomeLabel2);
            this.WelcomePanel.Controls.Add(this.WelcomeLabel1);
            this.WelcomePanel.Location = new System.Drawing.Point(75, 300);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(400, 350);
            this.WelcomePanel.TabIndex = 19;
            // 
            // WelcomeLabel1
            // 
            this.WelcomeLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel1.Location = new System.Drawing.Point(125, 30);
            this.WelcomeLabel1.Name = "WelcomeLabel1";
            this.WelcomeLabel1.Size = new System.Drawing.Size(150, 30);
            this.WelcomeLabel1.TabIndex = 14;
            this.WelcomeLabel1.Text = "Welcome to\r\n";
            this.WelcomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinksLabel3
            // 
            this.LinksLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.LinksLabel3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinksLabel3.Location = new System.Drawing.Point(50, 290);
            this.LinksLabel3.Name = "LinksLabel3";
            this.LinksLabel3.Size = new System.Drawing.Size(300, 40);
            this.LinksLabel3.TabIndex = 15;
            this.LinksLabel3.Text = "Access your courses directly on your mobile\r\ndevices, download the Blackboard app" +
    " today";
            this.LinksLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlackboardAppButton
            // 
            this.BlackboardAppButton.BackColor = System.Drawing.Color.Red;
            this.BlackboardAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlackboardAppButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BlackboardAppButton.Location = new System.Drawing.Point(50, 240);
            this.BlackboardAppButton.Name = "BlackboardAppButton";
            this.BlackboardAppButton.Size = new System.Drawing.Size(300, 40);
            this.BlackboardAppButton.TabIndex = 16;
            this.BlackboardAppButton.Text = "Black Board app";
            this.BlackboardAppButton.UseVisualStyleBackColor = false;
            this.BlackboardAppButton.Click += new System.EventHandler(this.BlackboardAppButton_Click);
            // 
            // LinksLabel2
            // 
            this.LinksLabel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.LinksLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.LinksLabel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinksLabel2.Location = new System.Drawing.Point(50, 160);
            this.LinksLabel2.Name = "LinksLabel2";
            this.LinksLabel2.Size = new System.Drawing.Size(300, 50);
            this.LinksLabel2.TabIndex = 11;
            this.LinksLabel2.Text = "For important announcements and notification \r\nregarding your courses, use your M" +
    "apúa MCL \r\nLive email to access your OneMCL account.\r\n";
            this.LinksLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OneMCLButton
            // 
            this.OneMCLButton.BackColor = System.Drawing.Color.Red;
            this.OneMCLButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OneMCLButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.OneMCLButton.Location = new System.Drawing.Point(50, 105);
            this.OneMCLButton.Name = "OneMCLButton";
            this.OneMCLButton.Size = new System.Drawing.Size(300, 40);
            this.OneMCLButton.TabIndex = 14;
            this.OneMCLButton.Text = "One MCL";
            this.OneMCLButton.UseVisualStyleBackColor = false;
            this.OneMCLButton.Click += new System.EventHandler(this.OneMCLButton_Click);
            // 
            // LinksLabel1
            // 
            this.LinksLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinksLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.LinksLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinksLabel1.Location = new System.Drawing.Point(150, 30);
            this.LinksLabel1.Name = "LinksLabel1";
            this.LinksLabel1.Size = new System.Drawing.Size(100, 40);
            this.LinksLabel1.TabIndex = 14;
            this.LinksLabel1.Text = "Links\r\n";
            this.LinksLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinksPanel
            // 
            this.LinksPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.LinksPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LinksPanel.Controls.Add(this.LinksLabel3);
            this.LinksPanel.Controls.Add(this.BlackboardAppButton);
            this.LinksPanel.Controls.Add(this.LinksLabel2);
            this.LinksPanel.Controls.Add(this.OneMCLButton);
            this.LinksPanel.Controls.Add(this.LinksLabel1);
            this.LinksPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LinksPanel.Location = new System.Drawing.Point(1025, 300);
            this.LinksPanel.Name = "LinksPanel";
            this.LinksPanel.Size = new System.Drawing.Size(400, 350);
            this.LinksPanel.TabIndex = 18;
            // 
            // UserBoxPicture
            // 
            this.UserBoxPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserBoxPicture.ErrorImage = null;
            this.UserBoxPicture.Image = global::GUI.Properties.Resources._378326889_281564724736409_3253073940515923188_n;
            this.UserBoxPicture.Location = new System.Drawing.Point(30, 120);
            this.UserBoxPicture.Name = "UserBoxPicture";
            this.UserBoxPicture.Size = new System.Drawing.Size(40, 40);
            this.UserBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserBoxPicture.TabIndex = 14;
            this.UserBoxPicture.TabStop = false;
            // 
            // PassBoxPicture
            // 
            this.PassBoxPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PassBoxPicture.ErrorImage = null;
            this.PassBoxPicture.Image = global::GUI.Properties.Resources._378259570_1452698178910946_7162365543038312775_n;
            this.PassBoxPicture.Location = new System.Drawing.Point(30, 205);
            this.PassBoxPicture.Name = "PassBoxPicture";
            this.PassBoxPicture.Size = new System.Drawing.Size(40, 40);
            this.PassBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassBoxPicture.TabIndex = 3;
            this.PassBoxPicture.TabStop = false;
            // 
            // LoginLinkLabel1
            // 
            this.LoginLinkLabel1.ActiveLinkColor = System.Drawing.Color.AliceBlue;
            this.LoginLinkLabel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.LoginLinkLabel1.LinkColor = System.Drawing.Color.White;
            this.LoginLinkLabel1.Location = new System.Drawing.Point(125, 310);
            this.LoginLinkLabel1.Name = "LoginLinkLabel1";
            this.LoginLinkLabel1.Size = new System.Drawing.Size(150, 20);
            this.LoginLinkLabel1.TabIndex = 13;
            this.LoginLinkLabel1.TabStop = true;
            this.LoginLinkLabel1.Text = "Forgot Password?";
            this.LoginLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.Red;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SignInButton.Location = new System.Drawing.Point(50, 260);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(300, 40);
            this.SignInButton.TabIndex = 12;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PasswordLoginField
            // 
            this.PasswordLoginField.Location = new System.Drawing.Point(80, 215);
            this.PasswordLoginField.Name = "PasswordLoginField";
            this.PasswordLoginField.PasswordChar = '*';
            this.PasswordLoginField.Size = new System.Drawing.Size(270, 20);
            this.PasswordLoginField.TabIndex = 11;
            // 
            // LoginLabel1
            // 
            this.LoginLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginLabel1.Location = new System.Drawing.Point(10, 30);
            this.LoginLabel1.Name = "LoginLabel1";
            this.LoginLabel1.Size = new System.Drawing.Size(380, 50);
            this.LoginLabel1.TabIndex = 9;
            this.LoginLabel1.Text = "Login to Mapua MCL Blackboard";
            this.LoginLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameLoginField
            // 
            this.UsernameLoginField.Location = new System.Drawing.Point(80, 130);
            this.UsernameLoginField.Name = "UsernameLoginField";
            this.UsernameLoginField.Size = new System.Drawing.Size(270, 20);
            this.UsernameLoginField.TabIndex = 10;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PassLabel.Location = new System.Drawing.Point(75, 180);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(78, 20);
            this.PassLabel.TabIndex = 8;
            this.PassLabel.Text = "Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserLabel.Location = new System.Drawing.Point(75, 90);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(83, 20);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "Username";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginPanel.Controls.Add(this.UserBoxPicture);
            this.LoginPanel.Controls.Add(this.PassBoxPicture);
            this.LoginPanel.Controls.Add(this.LoginLinkLabel1);
            this.LoginPanel.Controls.Add(this.SignInButton);
            this.LoginPanel.Controls.Add(this.PasswordLoginField);
            this.LoginPanel.Controls.Add(this.LoginLabel1);
            this.LoginPanel.Controls.Add(this.UsernameLoginField);
            this.LoginPanel.Controls.Add(this.PassLabel);
            this.LoginPanel.Controls.Add(this.UserLabel);
            this.LoginPanel.Location = new System.Drawing.Point(550, 300);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(400, 350);
            this.LoginPanel.TabIndex = 17;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.Screenshot_2023_09_19_185222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.MCLLogoPicture);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.LinksPanel);
            this.Controls.Add(this.LoginPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Mapua Malayan Colleges Laguna";
            ((System.ComponentModel.ISupportInitialize)(this.MCLLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCLPicture)).EndInit();
            this.WelcomePanel.ResumeLayout(false);
            this.LinksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserBoxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassBoxPicture)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MCLLogoPicture;
        private System.Windows.Forms.PictureBox MCLPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WelcomeLabel2;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Label WelcomeLabel1;
        private System.Windows.Forms.Label LinksLabel3;
        private System.Windows.Forms.Button BlackboardAppButton;
        private System.Windows.Forms.Label LinksLabel2;
        private System.Windows.Forms.Button OneMCLButton;
        private System.Windows.Forms.Label LinksLabel1;
        private System.Windows.Forms.Panel LinksPanel;
        private System.Windows.Forms.PictureBox UserBoxPicture;
        private System.Windows.Forms.PictureBox PassBoxPicture;
        private System.Windows.Forms.LinkLabel LoginLinkLabel1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox PasswordLoginField;
        private System.Windows.Forms.Label LoginLabel1;
        private System.Windows.Forms.TextBox UsernameLoginField;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel LoginPanel;
    }
}

