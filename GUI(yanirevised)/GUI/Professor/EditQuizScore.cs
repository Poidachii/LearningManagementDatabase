using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UpdateQuizScore : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private string AccID;
        private string QuizID;
        public UpdateQuizScore()
        {
            InitializeComponent();
        }

        public void SetAccID(string id)
        {
            AccID = id;
        }

        public void SetQuizID(string id)
        {
            QuizID = id;
        }

        private void UpdateQuizScore_Load(object sender, EventArgs e)
        {
            sql_params = new Dictionary<string, object>
            {
                { "@accid", AccID},
                { "@quizid", QuizID}
            };

            DataTable dt = SQL_legit.RunCommand("SELECT QuizName, Score " +
                                                "FROM Quiz " +
                                                "INNER JOIN Grades ON Grades.CourseID=Quiz.CourseID " +
                                                "WHERE AccID=@accid and Grades.QuizID=@quizid", opt_sql_params: sql_params);

            string QuizName = dt.Rows[0]["QuizName"].ToString();
            string Score = dt.Rows[0]["Score"].ToString();

            QuizNameLabel.Text = QuizName;
            ScoreTextBox.Text = Score;
        }

        private void EditQuizButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ScoreTextBox.Text))
            {
                MessageBox.Show("Please add a score", "No Quiz Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql_params = new Dictionary<string, object>
            {
                { "@score", ScoreTextBox.Text},
                { "@accid", AccID},
                { "@quizid", QuizID}
            };

            SQL_legit.RunCommand("UPDATE Grades " +
                                "SET Score=@score " +
                                "WHERE AccID=@accid and QuizID=@quizid", opt_sql_params: sql_params);

            MessageBox.Show("Successfully changed the Quiz Score.", "Score Edited.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
