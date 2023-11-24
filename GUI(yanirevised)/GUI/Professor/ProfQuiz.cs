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
    public partial class ProfQuiz : Form
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private ProfessorMain ProfessorMain;
        private List<int> itemlist;

        public QuizStateContext context = new QuizStateContext();
        public string QuizID;
        public string ItemID;
        public string CourseID;
        public string CourseName;
        public ProfQuiz()
        {
            InitializeComponent();
        }

        public void RefreshUI(int SelectedItem)
        {
            System.Diagnostics.Debug.WriteLine(ItemID);
            System.Diagnostics.Debug.WriteLine(QuizID);

            LoadItemList(SelectedItem);
            LoadChoices();

            if (string.IsNullOrWhiteSpace(QuizNameTextBox.Text))
            {
                QuizNameTextBox.Text = context.HandleQuizName(QuizID);
            }

            
            QuestionTextBox.Text = context.HandleQuestionText(QuizID, ItemID);
            AnswerTextBox.Text = context.HandleAnswer(QuizID, ItemID);
        }

        public void SetQuizID(string quizID=null)
        {
            if (quizID != null)
            {
                QuizID = quizID;
                return;
            }

            DataTable dt = SQL_legit.RunCommand("SELECT MAX(QuizID) AS QuizID from Quiz;", opt_sql_params: sql_params);

            int QuizID_int = Convert.ToInt32(dt.Rows[0]["QuizID"]) + 1;
            QuizID = QuizID_int.ToString();
        }

        public void SetCourseID(string courseID)
        {
            CourseID = courseID;
        }

        public void SetCourseName(string coursename)
        {
            CourseName = coursename;
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Session.LogOut();
            this.Close();
        }

        private void LoadItemList(int SelectedItem)
        {
            ItemNumberComboBox.Items.Clear();

            // Add items to combobox
            itemlist = context.HandleItems(QuizID);
            int ItemNumber = 1;

            List<Object> items = new List<Object>();

            ItemNumberComboBox.DisplayMember = "Text";
            ItemNumberComboBox.ValueMember = "Value";

            foreach (object item in itemlist)
            {
                ItemNumberComboBox.Items.Add(new { Text = "Question " + ItemNumber, Value = item.ToString() });
                ItemNumber++;
            }

            ItemID = itemlist[SelectedItem].ToString();
            ItemNumberComboBox.SelectedIndex = SelectedItem;
        }

        private void LoadChoices()
        {
            List<TextBox> TextBoxes = new List<TextBox>() { ChoiceTextBox1, ChoiceTextBox2, ChoiceTextBox3, ChoiceTextBox4};

            string[] choices = context.HandleChoices(QuizID, ItemID);

            for (int i = 0; i < TextBoxes.Count; i++)
            {
                TextBoxes[i].Text = choices[i];
            }
        }

        private void ProfQuiz_Load(object sender, EventArgs e)
        {
            AccountLabel.Text = $"Welcome, {Session.AccName}!";
            CourseNameLabel.Text = CourseName;

            RefreshUI(0);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // When Add Question is clicked, save first then reset to AddQuizState.
            // Don't save if all textboxes are empty.

            // Validation
            if (context.CurrentQuizState is EditQuizState)
            {
                context.SetState(new AddQuizState());
                RefreshUI(ItemNumberComboBox.Items.Count);
                return;
            }

            List<TextBox> TextBoxes = new List<TextBox>()
            {
                QuizNameTextBox, QuestionTextBox, ChoiceTextBox1, ChoiceTextBox2, ChoiceTextBox3, ChoiceTextBox4, AnswerTextBox
            };

            foreach (TextBox textbox in TextBoxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text) || textbox.Text.Contains("|"))
                {
                    MessageBox.Show("Please add some valid text in the textboxes.");
                    return;
                }
            }

            // Saving

            // Add a quiz first if it does not exist
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                };

            DataTable dt = SQL_legit.RunCommand("SELECT * FROM Quiz WHERE QuizID=@quizid", opt_sql_params: sql_params);

            if (dt?.Rows.Count <= 0)
            {

                sql_params = new Dictionary<string, object>
                {
                    { "@courseid", QuizID},
                    { "@quizname", QuizNameTextBox.Text}
                };

                SQL_legit.RunCommand("INSERT INTO Quiz " +
                                "VALUES(@courseid, @quizname)", opt_sql_params: sql_params);
            }

            else
            {
                sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@courseid", CourseID},
                    { "@quizname", QuizNameTextBox.Text}
                };

                SQL_legit.RunCommand("UPDATE Quiz " +
                                "SET CourseID=@courseid, QuizName=@quizname " +
                                "WHERE QuizID=@quizid", opt_sql_params: sql_params);
            }

            //Combine choices
            TextBoxes = new List<TextBox>() { ChoiceTextBox1, ChoiceTextBox2, ChoiceTextBox3, ChoiceTextBox4 };
            string finalchoices = "";
            
            foreach (TextBox textboxes in TextBoxes)
            {
                finalchoices += textboxes.Text + "|";
            }

            if (!finalchoices.Contains(AnswerTextBox.Text))
            {
                MessageBox.Show("Answer is not in choices.");
                return;
            }

            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@courseID", CourseID},
                    { "@question", QuestionTextBox.Text},
                    { "@choices", finalchoices.ToString()},
                    { "@answer", AnswerTextBox.Text},
                };

            SQL_legit.RunCommand("INSERT INTO QuizItems " +
                                "VALUES(@quizid, @courseID, @question, @choices, @answer)", opt_sql_params: sql_params);

            MessageBox.Show("Successfully added the Question.", "Question Added", MessageBoxButtons.OK, MessageBoxIcon.Information);


            context.SetState(new EditQuizState());

            RefreshUI(ItemNumberComboBox.SelectedIndex);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfessorMain = new ProfessorMain();
            ProfessorMain.ShowDialog();
            this.Close();
        }

        private void ItemNumberComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Validation
            if (context.CurrentQuizState is AddQuizState)
            {
                context.SetState(new EditQuizState());
            }

            ItemID = itemlist[ItemNumberComboBox.SelectedIndex].ToString();
            RefreshUI(ItemNumberComboBox.SelectedIndex);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (context.CurrentQuizState is AddQuizState)
            {
                RefreshUI(ItemNumberComboBox.SelectedIndex - 1);
                return;
            }

            if (itemlist.Count == 1)
            {
                MessageBox.Show("This is the only question left. To delete this quiz, please return to the main menu and delete it from there.");
                return;
            }

            sql_params = new Dictionary<string, object>
                {
                    { "@itemid", ItemID}
                };

            SQL_legit.RunCommand("DELETE FROM QuizItems " +
                                "WHERE ItemID=@itemid", opt_sql_params: sql_params);

            MessageBox.Show("Successfully deleted the question.");

            RefreshUI(ItemNumberComboBox.SelectedIndex - 1);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (context.CurrentQuizState is AddQuizState)
            {
                MessageBox.Show("Question does not exist. Can't update the question.");
                return;
            }
            context.SetState(new EditQuizState());

            //Validation

            List<TextBox> TextBoxes = new List<TextBox>()
            {
                QuizNameTextBox, QuestionTextBox, ChoiceTextBox1, ChoiceTextBox2, ChoiceTextBox3, ChoiceTextBox4, AnswerTextBox
            };

            foreach (TextBox textbox in TextBoxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text) || textbox.Text.Contains("|"))
                {
                    MessageBox.Show("Please add some valid text in the textboxes.");
                    return;
                }
            }

            TextBoxes = new List<TextBox>() { ChoiceTextBox1, ChoiceTextBox2, ChoiceTextBox3, ChoiceTextBox4 };
            string finalchoices = "";

            foreach (TextBox textboxes in TextBoxes)
            {
                finalchoices += textboxes.Text + "|";
            }

            if (!finalchoices.Contains(AnswerTextBox.Text))
            {
                MessageBox.Show("Answer is not in choices.");
                return;
            }

            sql_params = new Dictionary<string, object>
                {
                    { "@itemid", ItemID},
                    { "@quizid", QuizID},
                    { "@courseID", CourseID},
                    { "@question", QuestionTextBox.Text},
                    { "@choices", finalchoices.ToString()},
                    { "@answer", AnswerTextBox.Text},
                };

            SQL_legit.RunCommand("UPDATE QuizItems " +
                                "SET QuizID=@quizid, CourseID=@courseID, QuestionDetail=@question, " +
                                "Choices=@choices, Answer=@answer " +
                                "WHERE ItemID=@itemid", opt_sql_params: sql_params);

            MessageBox.Show("Successfully updated the Question.", "Question Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
