using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class QuizStateContext
    {
        public IQuizState CurrentQuizState;

        public QuizStateContext()
        {
            // Default state is AddQuizState
            CurrentQuizState = new AddQuizState();
        }

        public void SetState(IQuizState NewState)
        {
            CurrentQuizState = NewState;
        }

        public string HandleQuizName(string QuizID)
        {
            return CurrentQuizState.HandleQuizName(QuizID);
        }
        public List<int> HandleItems(string QuizID)
        {
            List<int> sortedlist = CurrentQuizState.HandleItems(QuizID);
            sortedlist.Sort();
            return sortedlist;
        }

        public string HandleQuestionText(string QuizID, string ItemID)
        {
            return CurrentQuizState.HandleQuestionText(QuizID, ItemID);
        }

        public string HandleAnswer(string QuizID, string ItemID)
        {
            return CurrentQuizState.HandleAnswer(QuizID, ItemID);
        }

        public string[] HandleChoices(string QuizID, string ItemID)
        {
            return CurrentQuizState.HandleChoices(QuizID, ItemID);
        }
    }
}
