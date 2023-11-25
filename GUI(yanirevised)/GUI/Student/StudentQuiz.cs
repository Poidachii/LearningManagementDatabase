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
        private StudentMain studentmainmenu;

        private Dictionary<object, object> itemlist = new Dictionary<object, object>();
        private Dictionary<object, object> Questions = new Dictionary<object, object>();
        private Dictionary<object, object> Choices = new Dictionary<object, object>();
        private Dictionary<object, object> CorrectAnswers = new Dictionary<object, object>();
        private Dictionary<object, string> StudentAnswers = new Dictionary<object, string>();
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

            var buttons = RadioGroup.Controls.OfType<RadioButton>();

            // Clear any checked button for the current item
            var checkedButton = buttons.FirstOrDefault(r => r.Checked);
            if (checkedButton != null && StudentAnswers[itemlist[CurrentItemNumber]] != null)
            {
                checkedButton.Checked = false;
            }

            CurrentItemNumber--;
            LoadQuestion(CurrentItemNumber);

            // Set the checked button based on the student's answer for the next item
            var selectedButton = buttons.FirstOrDefault(button => button.Text == StudentAnswers[itemlist[CurrentItemNumber]]);
            if (selectedButton != null && StudentAnswers[itemlist[CurrentItemNumber]] != null)
            {
                selectedButton.Checked = true;
            }

            ItemTrackerLabel.Text = $"{CurrentItemNumber} / {itemlist.Count}";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentItemNumber == itemlist.Count) { return; }

            var buttons = RadioGroup.Controls.OfType<RadioButton>();

            // Clear any checked button for the current item
            var checkedButton = buttons.FirstOrDefault(r => r.Checked);
            if (checkedButton != null && StudentAnswers[itemlist[CurrentItemNumber]] != null)
            {
                checkedButton.Checked = false;
            }

            CurrentItemNumber++;
            LoadQuestion(CurrentItemNumber);

            // Set the checked button based on the student's answer for the next item
            var selectedButton = buttons.FirstOrDefault(button => button.Text == StudentAnswers[itemlist[CurrentItemNumber]]);
            if (selectedButton != null && StudentAnswers[itemlist[CurrentItemNumber]] != null)
            {
                selectedButton.Checked = true;
            }

            ItemTrackerLabel.Text = $"{CurrentItemNumber} / {itemlist.Count}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    // Only one radio button will be checked
                    StudentAnswers[itemlist[CurrentItemNumber]] = rb.Text;
                    return;
                }
            }
        }

        private void ReturnHome()
        {
            this.Hide();
            studentmainmenu = new StudentMain();
            studentmainmenu.ShowDialog();
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ReturnHome();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int score = 0;
            bool containsNull = StudentAnswers.Values.Any(value => value == null);
            if (containsNull)
            {
                MessageBox.Show("Please answer all questions.");
                return;
            }

            foreach (var ItemID in StudentAnswers.Keys)
            {
                if (string.Compare(StudentAnswers[ItemID], CorrectAnswers[ItemID].ToString()) == 0)
                {
                    score++;
                }
            }

            MessageBox.Show("Quiz submitted.");

            // Add a quiz first if it does not exist
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@accid", Session.AccID}
                };

            DataTable dt = SQL_legit.RunCommand("SELECT * FROM Grades WHERE QuizID=@quizid AND AccID=@accid", opt_sql_params: sql_params);

            if (dt?.Rows.Count <= 0)
            {

                sql_params = new Dictionary<string, object>
                {
                    { "@courseid", CourseID},
                    { "@quizid", QuizID},
                    { "@accid", Session.AccID},
                    { "@score", score}
                };

                SQL_legit.RunCommand("INSERT INTO Grades " +
                                "VALUES(@accid, @courseid, @quizid, @score)", opt_sql_params: sql_params);
            }

            else
            {
                sql_params = new Dictionary<string, object>
                {
                    { "@accid", Session.AccID},
                    { "@quizid", QuizID},
                    { "@score", score}
                };

                SQL_legit.RunCommand("UPDATE Grades " +
                                "SET Score=@score " +
                                "WHERE QuizID=@quizid AND AccID=@accid ", opt_sql_params: sql_params);
            }

            ReturnHome();
        }
    }
}
