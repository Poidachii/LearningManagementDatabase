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
    public partial class StudentMainMenu : Form
    {
        private StudentGradeMenu studentgrademenu;
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void StudentMainMenu_Load(object sender, EventArgs e)
        {
            //Fill DropDown
            sql_params = new Dictionary<string, object>
            {
                { "@accid", Session.AccID}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT CourseAssignment.CourseID, Courses.CourseName" + " FROM CourseAssignment" + 
                                      " INNER JOIN Courses ON Courses.CourseID = CourseAssignment.CourseID" +
                                      " WHERE CourseAssignment.AccID = @accid;", opt_sql_params: sql_params);

            StudentCourseDropdown.DisplayMember = "CourseName";
            StudentCourseDropdown.ValueMember = "CourseID";
            StudentCourseDropdown.DataSource = dt; 
            StudentCourseDropdown.SelectedIndex = 0;
        }

        private void StudentGradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentgrademenu = new StudentGradeMenu();
            studentgrademenu.ShowDialog();
            this.Show();
        }

        private void StudentCourseDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset ListView
            CourseMaterialsListView.Columns.Clear(); // Clear previously added columns
            CourseMaterialsListView.Items.Clear(); // Clear previously populated items
            CourseMaterialsListView.View = View.Details;

            //Fill ListView
            sql_params = new Dictionary<string, object>
            {
                { "@accid", Session.AccID},
                { "@courseid", StudentCourseDropdown.SelectedValue}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT MaterialName, MaterialLink " +
                                    "FROM CourseAssignment " +
                                    "INNER JOIN CourseMaterials ON CourseMaterials.CourseID=CourseAssignment.CourseID " +
                                    "WHERE AccID = @accid AND CourseAssignment.CourseID=@courseid;", opt_sql_params: sql_params);

            CourseMaterialsListView.Columns.Add("MaterialName");
            CourseMaterialsListView.Columns.Add("MaterialLink");

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["MaterialName"].ToString());
                item.SubItems.Add(row["MaterialLink"].ToString());
                CourseMaterialsListView.Items.Add(item);
            }

            CourseMaterialsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            CourseMaterialsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        
    }
}
