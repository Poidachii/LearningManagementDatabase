using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace GUI
{
    partial class AccountCreation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleDropDown = new System.Windows.Forms.ComboBox();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(20, 33);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(152, 32);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Username:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(20, 116);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(146, 32);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Password:";
            // 
            // UsernameField
            // 
            this.UsernameField.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.UsernameField.Location = new System.Drawing.Point(200, 33);
            this.UsernameField.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(350, 43);
            this.UsernameField.TabIndex = 3;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PasswordField.Location = new System.Drawing.Point(200, 116);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(350, 43);
            this.PasswordField.TabIndex = 4;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CreateButton.Location = new System.Drawing.Point(120, 350);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(250, 80);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create Account";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.DeleteButton.Location = new System.Drawing.Point(430, 350);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(250, 80);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Remove Account";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.InputPanel.Controls.Add(this.RoleDropDown);
            this.InputPanel.Controls.Add(this.RoleLabel);
            this.InputPanel.Controls.Add(this.UsernameField);
            this.InputPanel.Controls.Add(this.UserLabel);
            this.InputPanel.Controls.Add(this.PasswordField);
            this.InputPanel.Controls.Add(this.PassLabel);
            this.InputPanel.Location = new System.Drawing.Point(100, 30);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(600, 298);
            this.InputPanel.TabIndex = 7;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.RoleLabel.ForeColor = System.Drawing.Color.White;
            this.RoleLabel.Location = new System.Drawing.Point(26, 206);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(81, 32);
            this.RoleLabel.TabIndex = 6;
            this.RoleLabel.Text = "Role:";
            // 
            // RoleDropDown
            // 
            this.RoleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.RoleDropDown.FormattingEnabled = true;
            this.RoleDropDown.Items.AddRange(new object[] {
            "Student",
            "Professor",
            "Admin"});
            this.RoleDropDown.Location = new System.Drawing.Point(200, 206);
            this.RoleDropDown.Name = "RoleDropDown";
            this.RoleDropDown.Size = new System.Drawing.Size(350, 40);
            this.RoleDropDown.TabIndex = 7;
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(782, 524);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountCreation";
            this.Text = "Account Creation";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private Button CreateButton;
        private Button DeleteButton;
        private Panel InputPanel;
        private ComboBox RoleDropDown;
        private System.Windows.Forms.Label RoleLabel;
    }
}