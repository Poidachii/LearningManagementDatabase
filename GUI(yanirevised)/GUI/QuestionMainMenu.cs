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
    public partial class QuestionMainMenu : Form
    {
        public QuestionMainMenu()
        {
            InitializeComponent();
        }

        private void CreateQuestionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionCreation QuestionCreation = new QuestionCreation();
            QuestionCreation.ShowDialog();
            this.Show();
        }

        private void EditQuestionBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
