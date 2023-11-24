using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class AddQuizState : IQuizState
    {
        private Dictionary<string, object> sql_params = new Dictionary<string, object>();

        public string HandleQuizName(string QuizID)
        {
            return null;
        }
        public string HandleQuestionText(string QuizID, string ItemID)
        {
            return null;
        }

        public string HandleAnswer(string QuizID, string ItemID)
        {
            return null;
        }

        public string[] HandleChoices(string QuizID, string ItemID)
        {
            return new string[4];
        }

        public List<int> HandleItems(string QuizID)
        {
            DataTable dt = new DataTable();
            List<int> itemlist = new List<int>();

            // check if a question item or highest ID exists
            dt = SQL_legit.RunCommand("SELECT max(ItemID) AS ItemID FROM QuizItems;", opt_sql_params: sql_params);
            object MaxItemID = dt?.Rows[0]["ItemID"];
            if (string.IsNullOrWhiteSpace(MaxItemID.ToString()))
            {
                MaxItemID = 0;
            }

            // Add previous entries
            sql_params = new Dictionary<string, object>
                {
                    { "@quizid", QuizID},
                };

            dt = SQL_legit.RunCommand("SELECT ItemID FROM QuizItems WHERE QuizID=@quizid;", opt_sql_params: sql_params);

            foreach (DataRow row in dt?.Rows)
            {
                itemlist.Add(Convert.ToInt32(row["ItemID"]));
            }

            // Add new entry
            int ItemID_int = Convert.ToInt32(MaxItemID) + 1;
            itemlist.Add(ItemID_int);

            return itemlist;
        }
    }
}
