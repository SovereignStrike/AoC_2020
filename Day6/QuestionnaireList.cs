using System;
using System.Collections.Generic;
using System.Text;
using ChristmasUtils;

namespace Day6
{
    public class QuestionnaireList
    {
        List<Questionnaire> questionnaires;
         public QuestionnaireList(string path)
        {
            questionnaires = new List<Questionnaire>();
            List<string> input = FileUtils.BufferRead(path);
            foreach (string q in input)
            {
                questionnaires.Add(new Questionnaire(q));
            }

        }

        public int PositiveAnswers()
        {
            int answers = 0;
            foreach (Questionnaire q in questionnaires)
            {
                answers = answers + q.PositiveQuestions();
            }
            return answers;
        }

        public int AllPositiveAnswers()
        {
            int answers = 0;
            foreach (Questionnaire q in questionnaires)
            {
                answers = answers + q.AllPositiveQuestions();
            }
            return answers;
        }
    }
}
