using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI
{
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            string username = UsernameField.Text;
            string password = PasswordField.Text;

            if (SQLData.CheckUserIfExists(username))
            {
                MessageBox.Show("Please choose another username.");
                return;
            }

            if (UsernameField.Text.Contains("|"))
            {
                MessageBox.Show("Username must not contain '|' character.");
                return;
            }

            string token;

            switch (password)
            {
                case "$$C1-1013151515":
                    // check if password is for admin
                    token = "admin";
                    break;
                case "C2-1515151515":
                    // check if password is for admin
                    token = "prof";
                    break;
                default:
                    // default case is user
                    token = "user";
                    break;
            }

            Dictionary<string, object> sql_params = new Dictionary<string, object>();
            sql_params.Add("@name", username);
            sql_params.Add("@pass", password);
            sql_params.Add("@token", token);

            SQL.RunCommand("INSERT INTO Accountlist VALUES (@name, @pass, @token)", opt_sql_params: sql_params);

            MessageBox.Show("User is successfully registered.");

            this.Close();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            string username = UsernameField.Text;

            if (!SQLData.CheckUserIfExists(username)) 
            {
                MessageBox.Show("Username does not exist."); 
                return; 
            }

            Dictionary<string, object> sql_params = new Dictionary<string, object>();
            sql_params.Add("@name", username);

            SQL.RunCommand("DELETE FROM Accountlist WHERE Name = @name", opt_sql_params: sql_params);

            MessageBox.Show("User is successfully deleted.");
            this.Close();
        }

        private void AtoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}