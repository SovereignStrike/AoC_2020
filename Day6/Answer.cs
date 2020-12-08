using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Answer
    {
        public List<string> questions;
        public Answer(string ans)
        {
            questions = new List<string>();
            foreach (char item in ans.ToCharArray())
            {
                questions.Add(item.ToString());
            }



        }
    }
}
