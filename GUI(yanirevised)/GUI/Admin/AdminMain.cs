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

        private string old_name, old_pass, old_role, role, name, type;
        
        private bool account_creation_is_hidden,
            account_handling_is_hidden,
            course_handling_is_hidden,
            course_adding_is_hidden,
            course_assigning_is_hidden;

        public AdminMain()
        {
            InitializeComponent();

            // Side Panel update
            AccountHandleButton.Enabled = false;

            // Account Handling Panel update
            account_handling_is_hidden = true;
            ToggleAccountHandlingPanel();

            AccountAllListButton.Enabled = false;
            AccountAllListButton.BackColor = Color.Gray;

            role = "all";

            SQL_legit.RunCommand("SELECT * FROM AccountList", AccountViewGrid);

            // Account Creation Panel update
            account_creation_is_hidden = false;
            ToggleAccountCreationPanel();

            // Course Handling Panel update
            course_handling_is_hidden = false;
            ToggleCourseHandlingPanel();

            CourseAllListButton.Enabled = false;
            CourseAllListButton.BackColor = Color.Gray;

            sql_params.Clear();
            sql_params = new Dictionary<string, object>()
            {
                { "@role", "admin" }
            };

            role = "all";

            SQL_legit.RunCommand(
                "SELECT AccountList.AccName, AccountList.AccRole, Courses.CourseName " +
                "FROM AccountList " +
                "LEFT JOIN CourseAssignment ON AccountList.AccID = CourseAssignment.AccID " +
                "LEFT JOIN Courses ON Courses.CourseID = CourseAssignment.CourseID " +
                "WHERE AccRole != @role", CourseViewGrid, sql_params);

            // Course Adding Panel update
            course_adding_is_hidden = false;
            ToggleCourseAddingPanel();

            // Course Assigning Panel update
            course_assigning_is_hidden = false;
            ToggleCourseAssigningPanel();
        }

        public void SetGreeting()
        {
            AccountLabel.Text = "Welcome, " + Session.AccName;
        }

        private void ToggleAccountHandlingPanel()
        {
            AccountHandlingPanel.Location = new Point(300, 50);
            AccountHandlingPanel.Size = new Size(1100, 750);

            if (account_handling_is_hidden) { AccountHandlingPanel.Show();} else { AccountHandlingPanel.Hide(); }

            account_handling_is_hidden = !account_handling_is_hidden;
        }

        private void ToggleAccountCreationPanel()
        {
            AccountCreationPanel.Location = new Point(300, 50);
            AccountCreationPanel.Size = new Size(1100, 750);

            if (account_creation_is_hidden) { AccountCreationPanel.Show(); } else { AccountCreationPanel.Hide(); }

            account_creation_is_hidden = !account_creation_is_hidden;
        }

        private void ToggleCourseHandlingPanel()
        {
            CourseHandlingPanel.Location = new Point(300, 50);
            CourseHandlingPanel.Size = new Size(1100, 750);

            if (course_handling_is_hidden) { CourseHandlingPanel.Show(); } else { CourseHandlingPanel.Hide(); }

            course_handling_is_hidden = !course_handling_is_hidden;
        }

        private void ToggleCourseAddingPanel()
        {
            CourseAddingPanel.Location = new Point(300, 50);
            CourseAddingPanel.Size = new Size(1100, 750);

            if (course_adding_is_hidden) { CourseAddingPanel.Show(); } else { CourseAddingPanel.Hide(); }

            course_adding_is_hidden = !course_adding_is_hidden;
        }

        private void ToggleCourseAssigningPanel()
        {
            CourseAssigningPanel.Location = new Point(300, 50);
            CourseAssigningPanel.Size = new Size(1100, 750);

            if (course_assigning_is_hidden) { CourseAssigningPanel.Show(); } else { CourseAssigningPanel.Hide(); }

            course_assigning_is_hidden = !course_assigning_is_hidden;
        }

        private void AccountHandleButton_Click(object sender, EventArgs e)
        {
            account_handling_is_hidden = true;
            account_creation_is_hidden = false;
            course_handling_is_hidden = false;
            course_adding_is_hidden = false;
            course_assigning_is_hidden = false;
            
            ToggleAccountHandlingPanel();
            ToggleAccountCreationPanel();
            ToggleCourseHandlingPanel();
            ToggleCourseAddingPanel();
            ToggleCourseAssigningPanel();

            AccountHandleButton.Enabled = false;
            CourseHandleButton.Enabled = true;
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            account_handling_is_hidden = false;
            account_creation_is_hidden = false;
            course_handling_is_hidden = true;
            course_adding_is_hidden = false;
            course_assigning_is_hidden = false;

            ToggleAccountHandlingPanel();
            ToggleAccountCreationPanel();
            ToggleCourseHandlingPanel();
            ToggleCourseAddingPanel();
            ToggleCourseAssigningPanel();

            CourseHandleButton.Enabled = false;
            AccountHandleButton.Enabled = true;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.Logout();

            this.Close();
        }

        private void CourseUpdateDisplay()
        {
            if (name == "")
            {
                if (role == "all")
                {
                    sql_params.Clear();
                    sql_params = new Dictionary<string, object>()
                    {
                        { "@role", "admin" }
                    };

                    SQL_legit.RunCommand(
                        "SELECT AccountList.AccName, AccountList.AccRole, Courses.CourseName " +
                        "FROM AccountList " +
                        "LEFT JOIN CourseAssignment ON AccountList.AccID = CourseAssignment.AccID " +
                        "LEFT JOIN Courses ON Courses.CourseID = CourseAssignment.CourseID " +
                        "WHERE AccRole != @role", CourseViewGrid, sql_params);

                    return;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@role", role }
                };

                SQL_legit.RunCommand(
                        "SELECT AccountList.AccName, AccountList.AccRole, Courses.CourseName " +
                        "FROM AccountList " +
                        "LEFT JOIN CourseAssignment ON AccountList.AccID = CourseAssignment.AccID " +
                        "LEFT JOIN Courses ON Courses.CourseID = CourseAssignment.CourseID " +
                        "WHERE AccRole = @role", CourseViewGrid, sql_params);
            }

            else if (name != "")
            {
                if (role == "all")
                {
                    sql_params.Clear();
                    sql_params = new Dictionary<string, object>()
                    {
                        { "@role", "admin" },
                        { "@name", "%" + name + "%" }
                    };

                    SQL_legit.RunCommand(
                        "SELECT AccountList.AccName, AccountList.AccRole, Courses.CourseName " +
                        "FROM AccountList " +
                        "LEFT JOIN CourseAssignment ON AccountList.AccID = CourseAssignment.AccID " +
                        "LEFT JOIN Courses ON Courses.CourseID = CourseAssignment.CourseID " +
                        "WHERE (AccRole != @role AND AccName LIKE @name)", CourseViewGrid, sql_params);

                    return;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@name", "%" + name + "%" },
                    { "@role", role }
                };

                SQL_legit.RunCommand(
                        "SELECT AccountList.AccName, AccountList.AccRole, Courses.CourseName " +
                        "FROM AccountList " +
                        "LEFT JOIN CourseAssignment ON AccountList.AccID = CourseAssignment.AccID " +
                        "LEFT JOIN Courses ON Courses.CourseID = CourseAssignment.CourseID " +
                        "WHERE (AccRole = @role AND AccName LIKE @name)", CourseViewGrid, sql_params);
            }
        }

        private void AccountUpdateDisplay()
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

                    SQL_legit.RunCommand("SELECT * FROM AccountList WHERE AccName LIKE @name", AccountViewGrid, sql_params);

                    return;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@role", role }
                };

                SQL_legit.RunCommand("SELECT * FROM AccountList WHERE AccRole = @role", AccountViewGrid, sql_params);
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

                    SQL_legit.RunCommand("SELECT * FROM AccountList WHERE AccName LIKE @name", AccountViewGrid, sql_params);

                    return;
                }

                sql_params.Clear();
                sql_params = new Dictionary<string, object>()
                {
                    { "@name", "%" + name + "%" },
                    { "@role", role }
                };

                SQL_legit.RunCommand("SELECT * FROM AccountList WHERE (AccName LIKE @name AND AccRole = @role)", AccountViewGrid, sql_params);
            }
        }

        private void AccountStudentListButton_Click(object sender, EventArgs e)
        {
            AccountStudentListButton.Enabled = false;
            AccountStudentListButton.BackColor = Color.Gray;
            AccountProfessorListButton.Enabled = true;
            AccountProfessorListButton.BackColor = Color.White;
            AccountAdminListButton.Enabled = true;
            AccountAdminListButton.BackColor = Color.White;
            AccountAllListButton.Enabled = true;
            AccountAllListButton.BackColor = Color.White;

            role = "student";

            AccountUpdateDisplay();
        }

        private void AccountProfessorListButton_Click(object sender, EventArgs e)
        {
            AccountStudentListButton.Enabled = true;
            AccountStudentListButton.BackColor = Color.White;
            AccountProfessorListButton.Enabled = false;
            AccountProfessorListButton.BackColor = Color.Gray;
            AccountAdminListButton.Enabled = true;
            AccountAdminListButton.BackColor = Color.White;
            AccountAllListButton.Enabled = true;
            AccountAllListButton.BackColor = Color.White;

            role = "professor";

            AccountUpdateDisplay();
        }

        private void AccountAdminListButton_Click(object sender, EventArgs e)
        {
            AccountStudentListButton.Enabled = true;
            AccountStudentListButton.BackColor = Color.White;
            AccountProfessorListButton.Enabled = true;
            AccountProfessorListButton.BackColor = Color.White;
            AccountAdminListButton.Enabled = false;
            AccountAdminListButton.BackColor = Color.Gray;
            AccountAllListButton.Enabled = true;
            AccountAllListButton.BackColor = Color.White;

            role = "admin";

            AccountUpdateDisplay();
        }

        private void AccountAllListButton_Click(object sender, EventArgs e)
        {
            AccountStudentListButton.Enabled = true;
            AccountStudentListButton.BackColor = Color.White;
            AccountProfessorListButton.Enabled = true;
            AccountProfessorListButton.BackColor = Color.White;
            AccountAdminListButton.Enabled = true;
            AccountAdminListButton.BackColor = Color.White;
            AccountAllListButton.Enabled = false;
            AccountAllListButton.BackColor = Color.Gray;

            role = "all";

            AccountUpdateDisplay();
        }

        private void AccountSearchBar_TextChanged(object sender, EventArgs e)
        {
            name = AccountSearchBar.Text;

            AccountUpdateDisplay();
        }

        private void AccountViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = AccountViewGrid.Rows[e.RowIndex];

            try
            {
                old_name = dr.Cells["AccName"].Value.ToString();
                old_pass = dr.Cells["AccPass"].Value.ToString();
                old_role = dr.Cells["AccRole"].Value.ToString();

                UsernameField.Text = old_name;
                PasswordField.Text = old_pass;
                AccountRoleField.SelectedIndex = AccountRoleField.Items.IndexOf(old_role);
            }

            catch (Exception) { return; }

            AddAccountButton.Hide();
            UpdateAccountButton.Show();
            RemoveAccountButton.Show();

            ToggleAccountCreationPanel();
            ToggleAccountHandlingPanel();
        }

        private void AddCreationButton_Click(object sender, EventArgs e)
        {
            UsernameField.Text = "";
            PasswordField.Text = "";
            AccountRoleField.SelectedIndex = 0;

            AddAccountButton.Show();
            UpdateAccountButton.Hide();
            RemoveAccountButton.Hide();

            ToggleAccountCreationPanel();
            ToggleAccountHandlingPanel();
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            sql_params.Clear();
            sql_params = new Dictionary<string, object>()
            {
                { "@name", UsernameField.Text },
                { "@pass", PasswordField.Text },
                { "@role", AccountRoleField.SelectedItem.ToString() }
            };

            SQL_legit.RunCommand("INSERT INTO AccountList VALUES (@name, @pass, @role)", opt_sql_params: sql_params);

            role = "all";
            name = "";

            AccountUpdateDisplay();

            MessageBox.Show("Account added successfully.");

            ToggleAccountCreationPanel();
            ToggleAccountHandlingPanel();
        }

        private void UpdateAccountButton_Click(object sender, EventArgs e)
        {
            sql_params.Clear();
            sql_params = new Dictionary<string, object>()
            {
                { "@name", UsernameField.Text },
                { "@pass", PasswordField.Text },
                { "@role", AccountRoleField.SelectedItem.ToString() },
                { "oldname", old_name },
                { "@oldpass", old_pass },
                { "@oldrole", old_role }
            };

            SQL_legit.RunCommand(
                "UPDATE AccountList SET AccName = @name , AccPass = @pass , AccRole = @role " +
                "WHERE (AccName = @oldname AND AccPass = @oldpass AND AccRole = @oldrole)",
                opt_sql_params: sql_params
            );

            role = "all";
            name = "";

            AccountUpdateDisplay();

            MessageBox.Show("Account updated successfully.");

            ToggleAccountCreationPanel();
            ToggleAccountHandlingPanel();
        }

        private void RemoveAccountButton_Click(object sender, EventArgs e)
        {
            sql_params.Clear();
            sql_params = new Dictionary<string, object>()
            {
                { "oldname", old_name },
                { "@oldpass", old_pass },
                { "@oldrole", old_role }
            };

            SQL_legit.RunCommand(
                "DELETE FROM AccountList " +
                "WHERE (AccName = @oldname AND AccPass = @oldpass AND AccRole = @oldrole)",
                opt_sql_params: sql_params
            );

            role = "all";
            name = "";

            AccountUpdateDisplay();

            MessageBox.Show("Account removed successfully.");

            ToggleAccountCreationPanel();
            ToggleAccountHandlingPanel();
        }

        private void CourseSearchBar_TextChanged(object sender, EventArgs e)
        {
            name = CourseSearchBar.Text;

            CourseUpdateDisplay();
        }

        private void CourseViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string accrole, accname;

            try
            {
                DataGridViewRow dr = CourseViewGrid.Rows[e.RowIndex];
                accname = dr.Cells["AccName"].Value.ToString();
                accrole = dr.Cells["AccRole"].Value.ToString();
            }
            catch (Exception) { return; }

            sql_params.Clear();
            sql_params["@role"] = "admin";

            DataTable dt = SQL_legit.RunCommand(
                "SELECT Courses.CourseName, AccountList.AccName, AccountList.AccRole " +
                "FROM Courses " +
                "LEFT JOIN CourseAssignment ON Courses.CourseID = CourseAssignment.CourseID " +
                "LEFT JOIN AccountList ON CourseAssignment.AccID = AccountList.AccID " +
                "WHERE AccRole != @role", opt_sql_params: sql_params);

            ToggleCourseHandlingPanel();

            if (accrole == "student")
            {
                type = "cell";
                CourseListLabel.Text = "Courses:";

                List<string> courses = new List<string>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["AccName"].ToString() == accname)
                    {
                        courses.Add(dt.Rows[i]["CourseName"].ToString());
                    }
                }

                CourseList.DataSource = courses;
                CourseList.SelectedIndex = 0;

                ToggleCourseAddingPanel();
            }
            
            else if (accrole == "professor")
            {
                type = "cell";

                List<string> professor_name = new List<string>() { accname };
                List<string> professor_courses = new List<string>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["AccName"].ToString() == accname)
                    {
                        professor_courses.Add(dt.Rows[i]["CourseName"].ToString());
                    }
                }

                ProfessorNameField.DataSource = professor_name;
                ProfessorNameField.SelectedIndex = 0;
                ProfessorNameField.Enabled = false;

                ProfessorCourseField.DataSource = professor_courses;
                ProfessorCourseField.SelectedIndex = 0;

                ToggleCourseAssigningPanel();
            }
        } 

        private void CourseStudentListButton_Click(object sender, EventArgs e)
        {
            CourseStudentListButton.Enabled = false;
            CourseStudentListButton.BackColor = Color.Gray;
            CourseProfessorListButton.Enabled = true;
            CourseProfessorListButton.BackColor = Color.White;
            CourseAllListButton.Enabled = true;
            CourseAllListButton.BackColor = Color.White;

            role = "student";

            CourseUpdateDisplay();
        }

        private void CourseProfessorListButton_Click(object sender, EventArgs e)
        {
            CourseStudentListButton.Enabled = true;
            CourseStudentListButton.BackColor = Color.White;
            CourseProfessorListButton.Enabled = false;
            CourseProfessorListButton.BackColor = Color.Gray;
            CourseAllListButton.Enabled = true;
            CourseAllListButton.BackColor = Color.White;

            role = "professor";

            CourseUpdateDisplay();
        }

        private void CourseAllListButton_Click(object sender, EventArgs e)
        {
            CourseStudentListButton.Enabled = true;
            CourseStudentListButton.BackColor = Color.White;
            CourseProfessorListButton.Enabled = true;
            CourseProfessorListButton.BackColor = Color.White;
            CourseAllListButton.Enabled = false;
            CourseAllListButton.BackColor = Color.Gray;

            role = "all";

            CourseUpdateDisplay();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            type = "button";
            CourseListLabel.Text = "All Courses:";

            List<string> course_list = SQL_legit.GetDataByColumnName("CourseName", "Courses");
            CourseList.DataSource = course_list;
            CourseList.SelectedIndex = 0;

            ToggleCourseAddingPanel();
            ToggleCourseHandlingPanel();
        }
        private void AddStudentCourseButton_Click(object sender, EventArgs e)
        {
            if (type == "button")
            {
                sql_params.Clear();
                sql_params["@course"] = CourseField.Text;

                SQL_legit.RunCommand("INSERT INTO Courses VALUES (@course)", opt_sql_params: sql_params);

                MessageBox.Show("Course added successfully.");
            }

            else if (type == "cell")
            {
                sql_params.Clear();
                sql_params["@course"] = CourseField.Text;

                DataTable dt = SQL_legit.RunCommand("INSERT INTO Courses VALUES (@course)", opt_sql_params: sql_params);

                string course_id = dt.Rows[0]["CourseID"].ToString();

                sql_params.Clear();
                sql_params["@name"] = old_name;

                dt = SQL_legit.RunCommand("SELECT AccID FROM AccountList WHERE AccName = @name", opt_sql_params: sql_params);

                string name_id = dt.Rows[0]["AccID"].ToString();

                sql_params.Clear();
                sql_params["@accid"] = name_id;
                sql_params["@courseid"] = course_id;

                SQL_legit.RunCommand("INSERT INTO CourseAssignment VALUES (@accid, @courseid)", opt_sql_params: sql_params);

                MessageBox.Show("Course added successfully.");
            }

            ToggleCourseAddingPanel();
            ToggleCourseHandlingPanel();
        }

        private void UpdateStudentCourseButton_Click(object sender, EventArgs e)
        {
            if (type == "button")
            {
                sql_params.Clear();
                sql_params["@course"] = CourseField.Text;
                sql_params["@coursename"] = CourseList.SelectedItem.ToString();

                SQL_legit.RunCommand("UPDATE Courses SET CourseName = @course WHERE CourseName = @coursename", opt_sql_params: sql_params);

                MessageBox.Show("Course updated successfully.");
            }

            else if (type == "cell")
            {

            }

            ToggleCourseAddingPanel();
            ToggleCourseHandlingPanel();
        }

        private void RemoveStudentCourseButton_Click(object sender, EventArgs e)
        {
            if (type == "button")
            {

            }

            else if (type == "cell")
            {

            }

            ToggleCourseAddingPanel();
            ToggleCourseHandlingPanel();
        }

        private void AssignCourseButton_Click(object sender, EventArgs e)
        {
            type = "button";

            sql_params.Clear();
            sql_params["@role"] = "professor";

            DataTable dt = SQL_legit.RunCommand("SELECT AccName FROM AccountList WHERE AccRole = @role", opt_sql_params: sql_params);

            List<string> professor_list = new List<string>();
            List<string> course_list = SQL_legit.GetDataByColumnName("CourseName", "Courses");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                professor_list.Add(dt.Rows[i]["AccName"].ToString());
            }

            ProfessorNameField.DataSource = professor_list;
            ProfessorCourseField.DataSource = course_list;

            ToggleCourseHandlingPanel();
            ToggleCourseAssigningPanel();
        }

        private void AssignProfessorCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveProfessorCourseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
