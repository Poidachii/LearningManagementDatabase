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
    public partial class Login : Form
    {

        public static string current_user;

        private Student student_form = new Student();
        private Admin admin_form = new Admin();
        private Profesor professor_form = new Profesor();

        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private DataTable dataset;
        private DataRow query_result;

        public Login()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            sql_params.Clear();
            sql_params.Add("@name", UsernameLoginField.Text);
            sql_params.Add("@pass", PasswordLoginField.Text);

            dataset = SQL.RunCommand("SELECT Token FROM Accountlist WHERE Name = @name AND Password = @pass", opt_sql_params: sql_params);

            if (dataset == null || dataset?.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid username and/or password!");
                return;
            }

            query_result = dataset.Rows[0];
            string token_value = query_result[0].ToString();

            username = UsernameLoginField.Text;
            
            this.Hide();

            if (token_value == "admin") { admin_form.ShowDialog(); }
            else if (token_value == "prof") { professor_form.ShowDialog(); }
            else { student_form.ShowDialog(); }

            this.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            List<string> userlist = SQL.GetDataByColumnName("Name", "Accountlist");

            string username = UsernameLoginField.Text;
            string password = PasswordLoginField.Text;

            if (userlist.Contains(username))
            {
                MessageBox.Show("Please choose another username.");
                return;
            }

            if (username.Contains("|"))
            {
                MessageBox.Show("Username must not contain '|' character.");
                return;
            }

            string token;

            //role selection can be optimized
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

            sql_params.Clear();
            sql_params.Add("@name", username);
            sql_params.Add("@pass", password);
            sql_params.Add("@token", token);

            SQL.RunCommand("INSERT INTO Accountlist VALUES (@name, @pass, @token)", opt_sql_params: sql_params);

            MessageBox.Show("User is successfully registered.");
        }
    }
}
