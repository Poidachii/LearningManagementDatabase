using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminCourseHandling : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public AdminCourseHandling()
        {
            InitializeComponent();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = false;
            ProfessorListButton.Enabled = true;
            AllListButton.Enabled = true;
        }

        private void ProfessorListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            ProfessorListButton.Enabled = false;
            AllListButton.Enabled = true;
        }

        private void AllListButton_Click(object sender, EventArgs e)
        {
            StudentListButton.Enabled = true;
            ProfessorListButton.Enabled = true;
            AllListButton.Enabled = false;
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string name = SearchBar.Text;

            sql_params.Clear();
            sql_params.Add("@name", name);

            SQL.RunCommand("SELECT * FROM AccountList WHERE Name = @name", CourseDataViewer, sql_params);
        }
    }
}
