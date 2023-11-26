using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public interface IQuizState
    {
        string HandleQuizName(string QuizID);
        List<int> HandleItems(string QuizID);
        string HandleQuestionText(string QuizID, string ItemID);
        string HandleAnswer(string QuizID, string ItemID);
        string[] HandleChoices(string QuizID, string ItemID);
        
    }
}
