using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentGrade : Form
    {
        private StudentMain studentmainmenu;
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public StudentGrade()
        {
            InitializeComponent();
        }

        private void StudentGradeMenu_Load(object sender, EventArgs e)
        {
            DataTable dt = SQL_legit.OnLoadData();

            StudentCourseDropdown.DisplayMember = "CourseName";
            StudentCourseDropdown.ValueMember = "CourseID";
            StudentCourseDropdown.DataSource = dt; 
            StudentCourseDropdown.SelectedIndex = 0;

            AccountLabel.Text = $"Welcome, {Session.AccName}!";
        }

        private void StudentCourseDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset ListView
            GradesListView.Columns.Clear(); // Clear previously added columns
            GradesListView.Items.Clear(); // Clear previously populated items
            GradesListView.View = View.Details;

            //Fill ListView
            sql_params = new Dictionary<string, object>
            {
                { "@accid", Session.AccID},
                { "@courseid", StudentCourseDropdown.SelectedValue}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT QuizName, Score " +
                                        "FROM Quiz " +
                                        "INNER JOIN Grades ON Grades.CourseID=Quiz.CourseID " +
                                        "WHERE AccID = @accid AND Grades.CourseID=@courseid;", opt_sql_params: sql_params);

            GradesListView.Columns.Add("QuizName");
            GradesListView.Columns.Add("Score");

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["QuizName"].ToString());
                item.SubItems.Add(row["Score"].ToString());
                GradesListView.Items.Add(item);
            }

            GradesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            GradesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentmainmenu = new StudentMain();
            studentmainmenu.ShowDialog();
            this.Close();
        }

        private void StudentGradeButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
