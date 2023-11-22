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
    public partial class StudentGradeMenu : Form
    {
        private StudentMainMenu studentmainmenu = new StudentMainMenu();
        private MainMenu menu = new MainMenu();
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        public StudentGradeMenu()
        {
            InitializeComponent();
        }
        private void StudentGradeMenu_Load(object sender, EventArgs e)
        {
            sql_params = new Dictionary<string, object>
            {
                {"@accid", Session.AccID }
            };

            DataTable dt = new DataTable();
            dt = SQL_legit.RunCommand("SELECT CourseAssignment.CourseID, Courses.CourseName" + " FROM CourseAssignment" +
                                         " INNER JOIN COURSES ON Courses.CourseID = CourseAssignment.CourseID" +
                                         " WHERE CourseAssignment.AccID = @accid;", opt_sql_params: sql_params);

            StudentCourseDropdown.DisplayMember = "CourseName";
            StudentCourseDropdown.ValueMember = "CourseID";
            StudentCourseDropdown.DataSource = dt;
            StudentCourseDropdown.SelectedIndex = 0;
        }

        private void StudentCourseDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset ListView
            QuizListView.Columns.Clear(); // Clear previously added columns
            QuizListView.Items.Clear(); // Clear previously populated items
            QuizListView.View = View.Details;

            //Fill ListView
            sql_params = new Dictionary<string, object>
            {
                { "@accid", Session.AccID},
                { "@courseid", StudentCourseDropdown.SelectedValue}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT ScoreID, QuizName " +
                                    "FROM Grades " +
                                    "INNER JOIN Quiz ON Quiz.QuizID=Grades.QuizID " +
                                    "WHERE AccID = @accid AND Grades.CourseID=@courseid;", opt_sql_params: sql_params);

            QuizListView.Columns.Add("QuizName");
            QuizListView.Columns.Add("ScoreID");

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["QuizName"].ToString());
                item.SubItems.Add(row["ScoreID"].ToString());
                QuizListView.Items.Add(item);
            }

            QuizListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            QuizListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void StudentHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentmainmenu.ShowDialog();
            this.Show();

        }

        private void StudentLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.ShowDialog();
           
        }
    }
}
