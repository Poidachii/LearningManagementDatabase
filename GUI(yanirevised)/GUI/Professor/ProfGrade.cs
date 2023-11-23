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
    public partial class ProfGrade : Form
    {
        private ProfessorMain ProfessorMain;
        private UpdateQuizScore UpdateQuizScore;
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public ProfGrade()
        {
            InitializeComponent();
        }

        private void ProfGrade_Load(object sender, EventArgs e)
        {
            DataTable dt = SQL_legit.OnLoadData();

            CourseListComboBox.DisplayMember = "CourseName";
            CourseListComboBox.ValueMember = "CourseID";
            CourseListComboBox.DataSource = dt;
            CourseListComboBox.SelectedIndex = 0;

            AccountLabel.Text = $"Welcome, {Session.AccName}!";
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.LogOut();
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfessorMain = new ProfessorMain();
            ProfessorMain.ShowDialog();
            this.Close();
        }

        private void GradeButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void CourseListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql_params = new Dictionary<string, object>
            {
                { "@courseid", CourseListComboBox.SelectedValue}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT AccName, AccountList.AccID " +
                                    "FROM AccountList " +
                                    "INNER JOIN CourseAssignment ON AccountList.AccID = CourseAssignment.AccID " +
                                    "WHERE AccRole='student' and CourseID = @courseid;", opt_sql_params: sql_params);

            List<Object> items = new List<Object>();

            StudentListComboBox.DisplayMember = "Text";
            StudentListComboBox.ValueMember = "Value";
                                                                                                                                                                                                                                                                                                                                                                                                            
            foreach (DataRow row in dt.Rows)
            {
                items.Add(new { Text = row["AccName"], Value = row["AccID"] });
            }

            StudentListComboBox.DataSource = items;
            StudentListComboBox.SelectedIndex = 0;
        }

        private void LoadGrades()
        {
            //Reset ListView
            GradesListView.Columns.Clear(); // Clear previously added columns
            GradesListView.Items.Clear(); // Clear previously populated items
            GradesListView.View = View.Details;

            //Fill ListView
            sql_params = new Dictionary<string, object>
            {
                { "@accid", StudentListComboBox.SelectedValue},
                { "@courseid", CourseListComboBox.SelectedValue}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT Grades.QuizID, QuizName, Score " +
                                        "FROM Quiz " +
                                        "INNER JOIN Grades ON Grades.CourseID=Quiz.CourseID " +
                                        "WHERE AccID = @accid AND Grades.CourseID=@courseid;", opt_sql_params: sql_params);

            GradesListView.Columns.Add("Quiz Name");
            GradesListView.Columns.Add("Score");

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["QuizName"].ToString());
                item.Tag = row["QuizID"].ToString();

                item.SubItems.Add(row["Score"].ToString());
                GradesListView.Items.Add(item);
            }

            GradesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            GradesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void StudentListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (GradesListView.SelectedItems.Count <= 0)
            {
                return;
            }

            UpdateQuizScore = new UpdateQuizScore();
            UpdateQuizScore.SetAccID(StudentListComboBox.SelectedValue.ToString());
            UpdateQuizScore.SetQuizID(GradesListView.SelectedItems[0].Tag.ToString());

            if (UpdateQuizScore.ShowDialog() == DialogResult.OK)
            {
                LoadGrades();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (GradesListView.SelectedItems.Count <= 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete this Score?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                sql_params = new Dictionary<string, object>
                {
                    { "@score", 0},
                    { "@accid", StudentListComboBox.SelectedValue.ToString()},
                    { "@quizid", GradesListView.SelectedItems[0].Tag.ToString()}
                };

                    SQL_legit.RunCommand("UPDATE Grades " +
                                        "SET Score=@score " +
                                        "WHERE AccID=@accid and QuizID=@quizid", opt_sql_params: sql_params);

                MessageBox.Show("Successfully deleted the Score.", "Score Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadGrades();
        }
    }
}
