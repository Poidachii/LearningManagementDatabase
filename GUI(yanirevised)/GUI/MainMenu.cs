using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainMenu : Form
    {
        private WS_Student studentform = new WS_Student();
        private Admin adminform = new Admin();
        private WS_Profesor profform = new WS_Profesor();

        public MainMenu()
        {
            InitializeComponent();
            SQLData.ReloadData();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> sql_params = new Dictionary<string, object>();
            sql_params.Add("@name", UsernameLoginField.Text);
            sql_params.Add("@pass", PasswordLoginField.Text);

            DataTable dataset = SQL.RunCommand("SELECT Token FROM Accountlist WHERE Name = @name AND Password = @pass", opt_sql_params: sql_params);

            if (dataset == null || dataset?.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid username and/or password!");
                return;
            }

            DataRow Query_Result = dataset.Rows[0];
            string token_value = Query_Result[0].ToString();

            this.Hide();

            if (token_value == "admin") { adminform.ShowDialog(); }
            else if (token_value == "prof") { profform.ShowDialog(); }
            else { studentform.ShowDialog(); }

            this.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string username = UsernameLoginField.Text;
            string password = PasswordLoginField.Text;

            if (SQLData.CheckUserIfExists(username))
            {
                MessageBox.Show("Please choose another username.");
                return;
            }

            if (UsernameLoginField.Text.Contains("|"))
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
        }
    }
}
