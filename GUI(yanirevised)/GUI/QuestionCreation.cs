using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace GUI
{
    public partial class QuestionCreation : Form
    {
        public QuestionCreation()
        {
            InitializeComponent();
        }

        private void ImportQuestion_Click(object sender, EventArgs e)
        {
            string question = QuestionBox.Text;
            string answer = AnswerBox.Text;

            SQL.ChangeDatabaseFilename("<table2file>.mdf");
            DataTable dataset = SQL.RunCommand("SELECT * FROM table2");

            if (SQLData.question.Contains(question)) { MessageBox.Show("Please choose another question."); return; }

            Dictionary<string, object> sql_params = new Dictionary<string, object>();
            sql_params.Add("@question", question);
            sql_params.Add("@answer", answer);

            SQL.RunCommand("INSERT INTO table2 VALUES (@question, @answer)", opt_sql_params: sql_params);

            SQLData.ReloadData();

            MessageBox.Show("Question Imported Successfully!!!");
        }

        private void CheckExist_Click(object sender, EventArgs e)
        {
            string question = QuestionBox.Text;
            string answer = AnswerBox.Text;

            if (SQLData.question.Contains(question) && SQLData.answer[SQLData.iref] != answer) { MessageBox.Show("Question not found..."); return; }
            else { MessageBox.Show("Question found in bank!!!"); return; }
        }

        private void QtoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
