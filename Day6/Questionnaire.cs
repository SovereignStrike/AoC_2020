using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Questionnaire
    {
        List<Answer> answers;
        ConcurrentDictionary<String, int> totals;
        public Questionnaire(string q)
        {
            answers = new List<Answer>();
            totals = new ConcurrentDictionary<String, int>();
            string[] answers_raw = q.Split(" ");
            foreach (string ans in answers_raw)
            {
                answers.Add(new Answer(ans));
            }

            foreach (Answer ans in answers)
            {
                foreach (string str in ans.questions)
                {
                    totals.AddOrUpdate(str, 1, (id, count) => count + 1);
                }
            }


        }

        public int PositiveQuestions()
        {
            return totals.Count; }
    }
}
