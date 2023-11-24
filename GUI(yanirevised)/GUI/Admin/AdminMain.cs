using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class AdminMain : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private DataTable dataset;

        private string role, name;

        public AdminMain()
        {
            InitializeComponent();

            AccountLabel.Text = "Welcome, " + Session.AccID;

            StudentListButton.Enabled = true;
            StudentListButton.BackColor = Color.White;
            ProfessorListButton.Enabled = true;
            ProfessorListButton.BackColor = Color.White;
            AdminListButton.Enabled = true;
            AdminListButton.BackColor = Color.White;
            AllListButton.Enabled = false;
            AllListButton.BackColor = Color.Gray;

            AccountHandleButton.Enabled = false;

            role = "all";

            SQL.RunCommand("SELECT * FROM AccountList", AccountViewGrid);
        }

        private void AccountHandleButton_Click(object sender, EventArgs e)
        {
            AccountHandlingPanel.Show();
            // CourseHandlingPanel.Hide();
            AccountHandleButton.Enabled = false;
            CourseHandleButton.Enabled = true;
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            AccountHandlingPanel.Hide();
            // CourseHandlingPanel.Show();
            CourseHandleButton.Enabled = false;
            AccountHandleButton.Enabled = true;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDisplay()
        {
            if (name == "")
            {
                if (role == "all")
                {
                    sql_params.Clear();
                    sql_params = new Dictionary<string, object>()
                    {
                        { "@name", "%" + name + "%" }
                    };

                    SQL.RunCommand("SELECT * FROM AccountList WHERE AccName LIKE @name", AccountViewGrid, sql_params);

                    return;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@role", role }
                };

                SQL.RunCommand("SELECT * FROM AccountList WHERE AccRole = @role", AccountViewGrid, sql_params);
            }

            else if (name != "")
            {
                if (role == "all")
                {
                    sql_params.Clear();
                    sql_params = new Dictionary<string, object>()
                    {
                        { "@name", "%" + name + "%" }
                    };

                    SQL.RunCommand("SELECT * FROM AccountList WHERE AccName LIKE @name", AccountViewGrid, sql_params);

                    return;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@name", "%" + name + "%" },
                    { "@role", role }
                };

                SQL.RunCommand("SELECT * FROM AccountList WHERE (AccName LIKE @name AND AccRole = @role)", AccountViewGrid, sql_params);
            }
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = false;
            StudentListButton.BackColor = Color.Gray;
            ProfessorListButton.Enabled = true;
            ProfessorListButton.BackColor = Color.White;
            AdminListButton.Enabled = true;
            AdminListButton.BackColor = Color.White;
            AllListButton.Enabled = true;
            AllListButton.BackColor = Color.White;

            role = "student";

            UpdateDisplay();
        }

        private void ProfessorListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            StudentListButton.BackColor = Color.White;
            ProfessorListButton.Enabled = false;
            ProfessorListButton.BackColor = Color.Gray;
            AdminListButton.Enabled = true;
            AdminListButton.BackColor = Color.White;
            AllListButton.Enabled = true;
            AllListButton.BackColor = Color.White;

            role = "professor";

            UpdateDisplay();
        }

        private void AdminListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            StudentListButton.BackColor = Color.White;
            ProfessorListButton.Enabled = true;
            ProfessorListButton.BackColor = Color.White;
            AdminListButton.Enabled = false;
            AdminListButton.BackColor = Color.Gray;
            AllListButton.Enabled = true;
            AllListButton.BackColor = Color.White;

            role = "admin";

            UpdateDisplay();
        }

        private void AllListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            StudentListButton.BackColor = Color.White;
            ProfessorListButton.Enabled = true;
            ProfessorListButton.BackColor = Color.White;
            AdminListButton.Enabled = true;
            AdminListButton.BackColor = Color.White;
            AllListButton.Enabled = false;
            AllListButton.BackColor = Color.Gray;

            role = "all";

            UpdateDisplay();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            name = SearchBar.Text;

            UpdateDisplay();
        }
    }
}
