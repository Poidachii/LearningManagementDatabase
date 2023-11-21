using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GUI
{
    internal class Necessities
    {
        private static Dictionary<string, object> sql_params = new Dictionary<string, object>();
        private static DataTable dataset;
        
        /*
            AccountList
            - AccID PRIMARY KEY
            - AccUser
            - AccPass
            - AccRole

            Courses
            - CourseID PRIMARY KEY
            - CourseName

            CourseAssignment
            - AccID FOREIGN KEY
            - CourseID FOREIGN KEY

            CourseMaterial
            - CourseID FOREIGN KEY
            - Material

            Quiz
            - QuizID PRIMARY KEY
            - CourseID FOREIGN KEY
            - QuizName

            QuizItems
            - ItemID PRIMARY KEY
            - QuizID FOREIGN KEY
            - Choices delim = |
            - Answer

            Grades
            - CourseID FOREIGN KEY
            - QuizID FOREIGN KEY
            - AccID FOREIGN KEY
            - Score
        */

        // Student functions
        public void LoadQuiz(string quiz_id) {
            sql_params.Clear();
            sql_params.Add("@id", quiz_id)

            dataset = SQL.RunCommand("SELECT * FROM QuizItems WHERE QuizID = @id");

        
        }
    }
}