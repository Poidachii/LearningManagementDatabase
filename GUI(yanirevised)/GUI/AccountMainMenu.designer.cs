using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class AccountMainMenu
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
            this.CreateAccount = new System.Windows.Forms.Button();
            this.EditAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAccount
            // 
            this.CreateAccount.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CreateAccount.Location = new System.Drawing.Point(123, 150);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(175, 59);
            this.CreateAccount.TabIndex = 0;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // EditAccountBtn
            // 
            this.EditAccountBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.EditAccountBtn.Location = new System.Drawing.Point(123, 215);
            this.EditAccountBtn.Name = "EditAccountBtn";
            this.EditAccountBtn.Size = new System.Drawing.Size(175, 59);
            this.EditAccountBtn.TabIndex = 1;
            this.EditAccountBtn.Text = "Edit Account";
            this.EditAccountBtn.UseVisualStyleBackColor = true;
            this.EditAccountBtn.Click += new System.EventHandler(this.EditAccountBtn_Click);
            // 
            // AccountMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 390);
            this.Controls.Add(this.EditAccountBtn);
            this.Controls.Add(this.CreateAccount);
            this.Name = "AccountMainMenu";
            this.Text = "AccountMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CreateAccount;
        private Button EditAccountBtn;
    }
}