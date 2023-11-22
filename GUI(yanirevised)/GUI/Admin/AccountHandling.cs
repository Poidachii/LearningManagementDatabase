using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class AccountHandling : Form
    {
        private AccountCreation account_creation = new AccountCreation();

        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public AccountHandling()
        {
            InitializeComponent();

            StudentListButton.Enabled = true;
            ProfessorListButton.Enabled = true;
            AdminListButton.Enabled = true;
            AllListButton.Enabled = false;
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string name = SearchBar.Text;

            sql_params.Clear();
            sql_params.Add("@name", name);

            SQL_legit.RunCommand("SELECT * FROM Account WHERE name = @name", AccountDataViewer, sql_params);
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = false;
            ProfessorListButton.Enabled = true;
            AdminListButton.Enabled = true;
            AllListButton.Enabled = true;
 
            SQL_legit.RunCommand("SELECT * FROM Account WHERE AccRole = 'student'", AccountDataViewer, sql_params);
        }

        private void ProfessorListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            ProfessorListButton.Enabled = false;
            AdminListButton.Enabled = true;
            AllListButton.Enabled = true;

            SQL_legit.RunCommand("SELECT * FROM Account WHERE AccRole = 'prof'", AccountDataViewer, sql_params);
        }

        private void AdminListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            ProfessorListButton.Enabled = true;
            AdminListButton.Enabled = false;
            AllListButton.Enabled = true;

            SQL_legit.RunCommand("SELECT * FROM Account WHERE AccRole = 'admin'", AccountDataViewer, sql_params);
        }

        private void AllListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            ProfessorListButton.Enabled = true;
            AdminListButton.Enabled = true;
            AllListButton.Enabled = false;

            SQL_legit.RunCommand("SELECT * FROM Account", AccountDataViewer, sql_params);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            account_creation.ShowDialog();
            SQL_legit.RunCommand("SELECT * FROM Account", AccountDataViewer, sql_params);
            this.Show();
        }

        private void AccountDataViewer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = AccountDataViewer.Rows[e.RowIndex].Cells["AccName"].ToString();
            string pass = AccountDataViewer.Rows[e.RowIndex].Cells["AccPass"].ToString();
            string role = AccountDataViewer.Rows[e.RowIndex].Cells["AccRole"].ToString();

            this.Hide();
            account_creation.Initialize(name, pass, role);
            account_creation.ShowDialog();
            SQL_legit.RunCommand("SELECT * FROM Account", AccountDataViewer, sql_params);
            this.Show();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
