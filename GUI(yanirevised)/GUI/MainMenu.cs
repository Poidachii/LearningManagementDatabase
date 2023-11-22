using GUI.Admin;
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
        private StudentMainMenu student_form = new StudentMainMenu();
        private AccountHandling admin_form = new AccountHandling();
        private Professor professor_form = new Professor();
        
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private DataTable dataset;
        private DataRow query_result;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            sql_params = new Dictionary<string, object>
            {
                { "@name", UsernameLoginField.Text },
                { "@pass", PasswordLoginField.Text }
                
            };

            dataset = SQL_legit.RunCommand("SELECT AccID, AccRole FROM Account WHERE AccName = @name AND AccPass = @pass", opt_sql_params: sql_params);

            if (dataset == null || dataset?.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid username and/or password!");
                return;
            }

            query_result = dataset.Rows[0];
            string token_value = query_result[1].ToString();

            Session.AccID = dataset.Rows[0][0].ToString();


            this.Hide();

            if (token_value == "admin") { admin_form.ShowDialog(); }
            else if (token_value == "prof") { professor_form.ShowDialog(); }
            else { student_form.ShowDialog(); }

            this.Show();
        }

        private void DEBUG_TEST_CLICK(object sender, EventArgs e)
        {
            Session.AccID = "1";
            Session.AccRole = "student";

            this.Hide();
            student_form.ShowDialog();
            this.Show();
        }

        private void OneMCLButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://one.mcl.edu.ph");
        }

        private void BlackboardAppButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mcl.edu.ph");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mcl.blackboard.com/ultra/catalog");
        }
    }
}
