using System;
using System.Collections.Generic;
using System.Text;
using ChristmasUtils;

namespace Day5
{
    public class BoardingPassList
    {
        private List<BoardingPass> passes;

        public BoardingPassList(string path)
        {
            var lis = FileUtils.Read(path);
            passes = new List<BoardingPass>();
            foreach (string el in lis)
            {
                passes.Add(new BoardingPass(el));
            }
        }

        public int HighestId()
        {
            int answer = 0;
            foreach(BoardingPass pass in passes)
            {
                if (pass.id > answer)
                { answer = pass.id; }
            }
            return answer;
        }
    }
}
