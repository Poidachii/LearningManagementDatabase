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
        private List<int> itemlist;
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public string QuizID;
        public StudentQuiz()
        {
            InitializeComponent();
        }

        public void SetQuizID(string quizid)
        {
            QuizID = quizid;
        }

        private void LoadQuizItems()
        {

        }

        private void StudentQuiz_Load(object sender, EventArgs e)
        {
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                };

            DataTable dt = SQL_legit.RunCommand("SELECT ItemID " +
                                                "FROM QuizItems " +
                                                "WHERE QuizID = @quizid", opt_sql_params: sql_params);
            List<int> itemlist = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                itemlist.Add(Convert.ToInt32(row["ItemID"]));
            }
        }
    }
}
