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
    public partial class ProfessorMain : Form
    {
        private ProfGrade studentgrademenu;
        private AddCourseMaterial AddCourseMaterial;
        private EditCourseMaterial EditCourseMaterial;
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public ProfessorMain()
        {
            InitializeComponent();
        }

        private void GradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentgrademenu = new ProfGrade();
            studentgrademenu.ShowDialog();
            this.Close();
        }

        private void ProfessorMain_Load(object sender, EventArgs e)
        {
            DataTable dt = SQL_legit.OnLoadData();

            ProfessorCourseDropdown.DisplayMember = "CourseName";
            ProfessorCourseDropdown.ValueMember = "CourseID";
            ProfessorCourseDropdown.DataSource = dt;
            ProfessorCourseDropdown.SelectedIndex = 0;

            AccountLabel.Text = $"Welcome, {Session.AccName}!";
        }

        private void LoadCourseMaterials()
        {
            //Reset ListView
            CourseMaterialsListView.Columns.Clear(); // Clear previously added columns
            CourseMaterialsListView.Items.Clear(); // Clear previously populated items
            CourseMaterialsListView.View = View.Details;

            //Fill ListView
            sql_params = new Dictionary<string, object>
            {
                { "@accid", Session.AccID},
                { "@courseid", ProfessorCourseDropdown.SelectedValue}
            };

            DataTable dt = new DataTable();

            dt = SQL_legit.RunCommand("SELECT MaterialName, MaterialLink, MaterialID " +
                                    "FROM CourseAssignment " +
                                    "INNER JOIN CourseMaterials ON CourseMaterials.CourseID=CourseAssignment.CourseID " +
                                    "WHERE AccID = @accid AND CourseAssignment.CourseID=@courseid;", opt_sql_params: sql_params);

            CourseMaterialsListView.Columns.Add("Material Name");
            CourseMaterialsListView.Columns.Add("Material Link");

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["MaterialName"].ToString());
                item.Tag = row["MaterialID"].ToString();

                item.SubItems.Add(row["MaterialLink"].ToString());
                CourseMaterialsListView.Items.Add(item);
            }

            CourseMaterialsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            CourseMaterialsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadQuizzes()
        {
            QuizzesListView.Columns.Clear(); // Clear previously added columns
            QuizzesListView.Items.Clear(); // Clear previously populated items
            QuizzesListView.View = View.Details;

            //Fill ListView
            sql_params = new Dictionary<string, object>
            {
                { "@accid", Session.AccID},
                { "@courseid", ProfessorCourseDropdown.SelectedValue}
            };

            DataTable qz_dt = new DataTable();

            qz_dt = SQL_legit.RunCommand("SELECT QuizName, QuizID " +
                                    "FROM Quiz " +
                                    "INNER JOIN CourseAssignment ON Quiz.CourseID=CourseAssignment.CourseID " +
                                    "WHERE AccID = @accid AND CourseAssignment.CourseID=@courseid;", opt_sql_params: sql_params);

            QuizzesListView.Columns.Add("Quiz Name");
            QuizzesListView.Columns.Add("Quiz ID");

            foreach (DataRow row in qz_dt.Rows)
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row["QuizName"].ToString());
                item.SubItems.Add(row["QuizID"].ToString());
                QuizzesListView.Items.Add(item);
            }

            QuizzesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            QuizzesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ProfessorCourseDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourseMaterials();
            LoadQuizzes();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.LogOut();
            this.Close();
        }

        private void AddCourseMaterialButton_Click(object sender, EventArgs e)
        {
            AddCourseMaterial = new AddCourseMaterial();
            AddCourseMaterial.SetCourseID(ProfessorCourseDropdown.SelectedValue.ToString());

            if (AddCourseMaterial.ShowDialog() == DialogResult.OK)
            {
                LoadCourseMaterials();
                LoadQuizzes();
            }
        }

        private void EditCourseMaterialButton_Click(object sender, EventArgs e)
        {
            if (CourseMaterialsListView.SelectedItems.Count <= 0)
            {
                return;
            }

            EditCourseMaterial = new EditCourseMaterial();
            EditCourseMaterial.SetMaterialID(CourseMaterialsListView.SelectedItems[0].Tag.ToString());

            if(EditCourseMaterial.ShowDialog() == DialogResult.OK)
            {
                LoadCourseMaterials();
                LoadQuizzes();
            }
        }

        private void RemoveCourseMaterialButton_Click(object sender, EventArgs e)
        {
            if (CourseMaterialsListView.SelectedItems.Count <= 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete this Course Material?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if(result == DialogResult.Yes)
            {
                string MaterialID = CourseMaterialsListView.SelectedItems[0].Tag.ToString();

                sql_params = new Dictionary<string, object>
                {
                    { "@materialid", MaterialID},
                };

                DataTable dt = SQL_legit.RunCommand("DELETE FROM CourseMaterials " +
                                                    "WHERE MaterialId=@materialid", opt_sql_params: sql_params);

                MessageBox.Show("Successfully deleted the Course Material.", "Course Material Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadCourseMaterials();
            LoadQuizzes();
        }
    }
}
