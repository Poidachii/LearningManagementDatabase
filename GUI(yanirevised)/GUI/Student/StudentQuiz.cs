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
    public partial class StudentQuiz : Form
    {
        private Dictionary<object, object> itemlist = new Dictionary<object, object>();
        private Dictionary<object, object> Questions = new Dictionary<object, object>();
        private Dictionary<object, object> Choices = new Dictionary<object, object>();
        private Dictionary<object, object> CorrectAnswers = new Dictionary<object, object>();
        private Dictionary<object, object> StudentAnswers = new Dictionary<object, object>();
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private int CurrentItemNumber = 1;

        public string QuizID;
        public string CourseID;
        public string ItemID;
        public StudentQuiz()
        {
            InitializeComponent();
        }

        public void SetQuizID(string quizid)
        {
            QuizID = quizid;
        }

        public void SetCourseID(string courseid)
        {
            CourseID = courseid;
        }

        private void LoadQuestionData()
        {
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID}
                };

            DataTable dt = SQL_legit.RunCommand("SELECT ItemID, QuestionDetail, Choices, Answer " +
                                        "FROM QuizItems " +
                                        "WHERE QuizID = @quizid", opt_sql_params: sql_params);

            int ItemNumber = 1;
            foreach (DataRow row in dt.Rows)
            {
                itemlist.Add(ItemNumber, row["ItemID"].ToString());
                Questions.Add(row["ItemID"].ToString(), row["QuestionDetail"].ToString());
                Choices.Add(row["ItemID"].ToString(), row["Choices"].ToString());
                CorrectAnswers.Add(row["ItemID"].ToString(), row["Answer"].ToString());
                StudentAnswers.Add(row["ItemID"].ToString(), null);
                ItemNumber++;
            }
        }

        private void LoadQuestion(object ItemNumber)
        {
            object ItemID = itemlist[ItemNumber].ToString();
            QuestionLabel.Text = Questions[ItemID].ToString();
            LoadChoices(ItemID);
            CurrentItemNumber = (int)ItemNumber;
        }

        private void LoadChoices(object ItemID)
        {
            string choices = Choices[ItemID].ToString();
            string[] ChoicesList = choices.Split('|');

            List<RadioButton> radios = new List<RadioButton>() { radioButton1, radioButton2, radioButton3, radioButton4 };

            for (int i=0; i < radios.Count; i++)
            {
                radios[i].Text = ChoicesList[i];
            }
        }

        private void StudentQuiz_Load(object sender, EventArgs e)
        {
            // Load Course Name
            sql_params = new Dictionary<string, object>
                {
                    { "@courseid", CourseID},
                };

            DataTable dt = SQL_legit.RunCommand("SELECT CourseName " +
                                                "FROM Courses " +
                                                "WHERE CourseID=@courseid", opt_sql_params: sql_params);

            CourseNameLabel.Text = dt?.Rows[0]["CourseName"].ToString();

            // Load Quiz Name
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@courseid", CourseID},
                };

            dt = SQL_legit.RunCommand("SELECT QuizName " +
                                        "FROM Quiz " +
                                        "WHERE CourseID = @courseid AND QuizID = @quizid", opt_sql_params: sql_params);

            QuestionNameLabel.Text = dt?.Rows[0]["QuizName"].ToString();

            LoadQuestionData();

            LoadQuestion(CurrentItemNumber);

            ItemTrackerLabel.Text = $"{CurrentItemNumber} / {itemlist.Count}";

            AccountLabel.Text = $"Welcome, {Session.AccName}!";
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.Close();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if(CurrentItemNumber == 1) { return; }
            var checkedButton = RadioGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton?.Checked == true)
            {
                checkedButton.Checked = false;
            }

            CurrentItemNumber -= 1;
            LoadQuestion(CurrentItemNumber);

            ItemTrackerLabel.Text = $"{CurrentItemNumber} / {itemlist.Count}";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentItemNumber == itemlist.Count) { return; }
            CurrentItemNumber += 1;
            var checkedButton = RadioGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton?.Checked == true)
            {
                checkedButton.Checked = false;
            }
            LoadQuestion(CurrentItemNumber);

            ItemTrackerLabel.Text = $"{CurrentItemNumber} / {itemlist.Count}";
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var checkedButton = RadioGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            StudentAnswers[itemlist[CurrentItemNumber]] = checkedButton;
        }
    }
}
