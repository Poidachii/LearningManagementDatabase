using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class EditQuizState : IQuizState
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public string HandleQuizName(string QuizID)
        {
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                };

            DataTable dt = SQL_legit.RunCommand("SELECT QuizName " +
                                                "FROM Quiz " +
                                                "WHERE QuizID = @quizid", opt_sql_params: sql_params);
            return dt.Rows[0]["QuizName"].ToString();
        }
        public string HandleQuestionText(string QuizID, string ItemID)
        {
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@itemid", ItemID}
                };

            DataTable dt = SQL_legit.RunCommand("SELECT QuestionDetail " +
                                                "FROM QuizItems " +
                                                "WHERE QuizID = @quizid AND ItemID = @itemid", opt_sql_params: sql_params);
            return dt.Rows[0]["QuestionDetail"].ToString();
        }

        public string HandleAnswer(string QuizID, string ItemID)
        {
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@itemid", ItemID}
                };

            DataTable dt = SQL_legit.RunCommand("SELECT Answer " +
                                                "FROM QuizItems " +
                                                "WHERE QuizID = @quizid AND ItemID = @itemid", opt_sql_params: sql_params);
            return dt.Rows[0]["Answer"].ToString();
        }

        public string[] HandleChoices(string QuizID, string ItemID)
        {
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                    { "@itemid", ItemID}
                };

            DataTable dt = SQL_legit.RunCommand("SELECT Choices " +
                                                "FROM QuizItems " +
                                                "WHERE QuizID = @quizid AND ItemID = @itemid", opt_sql_params: sql_params);
            string choices = dt.Rows[0]["Choices"].ToString();
            string[] ChoicesList = choices.Split('|');

            return ChoicesList;
        }

        public List<int> HandleItems(string QuizID)
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

            return itemlist;

        }

    }
}
