using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Linq;

namespace GUI
{
    public partial class AccountCreation : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private DataTable dataset;
        Random rnd = new Random();

        public static List<string> idlist = new List<string>();
        private string old_name;
        private string id;
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

                while (true)
                {
                    int rndint = rnd.Next(0000, 9999);
                    id = rndint.ToString();
                    DataTable dataset = SQL_legit.RunCommand("SELECT * FROM Account");
                    idlist = dataset.AsEnumerable().Select(x => x.Field<string>("AccID")).ToList();

                    if (idlist.Contains(id) == false) break;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {

                { "@name", UsernameField.Text },
                { "@pass", PasswordField.Text },
                { "@role", RoleDropDown.SelectedItem.ToString().ToLower() },
                { "@accid", id.ToString() }

                };

                SQL_legit.RunCommand("INSERT INTO Account(AccID, AccName, AccPass, AccRole) VALUES (@accid, @name, @pass, @role)", opt_sql_params: sql_params);

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

                SQL_legit.RunCommand("REPLACE INTO AccountList(AccName, AccPass, AccRole) VALUES (@name, @pass, @role) WHERE AccName = @oldname", opt_sql_params: sql_params);

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

            dataset = SQL_legit.RunCommand("SELECT AccName FROM AccountList WHERE AccName = @name");

            if (dataset?.Rows.Count == 0)
            {
                MessageBox.Show("Your account was not in the database.");
                return;
            }

            SQL_legit.RunCommand("DELETE FROM AccountList WHERE AccName = @name", opt_sql_params: sql_params);

            MessageBox.Show("Account has been removed successfully.");

            CreateButton.Text = "Create Account";
            DeleteButton.Text = "";
            DeleteButton.Enabled = false;

            this.Close();
        }
    }
}