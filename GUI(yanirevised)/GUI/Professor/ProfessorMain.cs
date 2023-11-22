﻿using System;
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
        private StudentGradeMenu studentgrademenu;
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public ProfessorMain()
        {
            InitializeComponent();
        }

        private void StudentGradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentgrademenu = new StudentGradeMenu();
            studentgrademenu.ShowDialog();
            this.Show();
        }

        private void ProfessorMain_Load(object sender, EventArgs e)
        {
            DataTable dt = SQL_legit.OnLoadData();

            ProfessorCourseDropdown.DisplayMember = "CourseName";
            ProfessorCourseDropdown.ValueMember = "CourseID";
            ProfessorCourseDropdown.DataSource = dt;
            ProfessorCourseDropdown.SelectedIndex = 0;
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

            QuizzesListView.Columns.Add("QuizName");
            QuizzesListView.Columns.Add("QuizID");

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

    }
}