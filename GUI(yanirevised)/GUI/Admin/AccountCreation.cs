using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace GUI
{
    public partial class AccountCreation : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private DataTable dataset;

        private string old_name;

        public void Initialize(string name, string pass, string role)
        {
            old_name = name;
            UsernameField.Text = name;
            PasswordField.Text = pass;

            for (int i = 0; i < RoleDropDown.Items.Count; i++)
            {
                if (RoleDropDown.Items[i].ToString() == role)
                {
                    RoleDropDown.SelectedIndex = i;
                    break;
                }
            }

            CreateButton.Text = "Update Account";
            DeleteButton.Text = "Remove Account";
            DeleteButton.Enabled = true;
        }

        public AccountCreation()
        {
            InitializeComponent();

            DeleteButton.Text = "";
            DeleteButton.Enabled = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CreateButton.Text == "Create Account")
            {
                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@name", UsernameField.Text },
                    { "@pass", PasswordField.Text },
                    { "@role", RoleDropDown.SelectedItem.ToString().ToLower() }
                };

                SQL.RunCommand("INSERT INTO AccountList(AccName, AccPass, AccRole) VALUES (@name, @pass, @role)", opt_sql_params: sql_params);

                MessageBox.Show("Account added successfully.");

            }
            
            else if (CreateButton.Text == "Update Account")
            {
                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    {"@oldname", old_name },
                    { "@name", UsernameField.Text },
                    { "@pass", PasswordField.Text },
                    { "@role", RoleDropDown.SelectedItem.ToString().ToLower() }
                };

                SQL.RunCommand("REPLACE INTO AccountList(AccName, AccPass, AccRole) VALUES (@name, @pass, @role) WHERE AccName = @oldname", opt_sql_params: sql_params);

                MessageBox.Show("Account updated successfully.");

                CreateButton.Text = "Create Account";
                DeleteButton.Text = "";
                DeleteButton.Enabled = false;
            }

            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            sql_params.Clear();
            sql_params.Add("@name", UsernameField.Text);

            dataset = SQL.RunCommand("SELECT AccName FROM AccountList WHERE AccName = @name");

            if (dataset?.Rows.Count == 0)
            {
                MessageBox.Show("Your account was not in the database.");
                return;
            }

            SQL.RunCommand("DELETE FROM AccountList WHERE AccName = @name", opt_sql_params: sql_params);

            MessageBox.Show("Account has been removed successfully.");

            CreateButton.Text = "Create Account";
            DeleteButton.Text = "";
            DeleteButton.Enabled = false;

            this.Close();
        }
    }
}