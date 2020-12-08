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

        public int FirstEmptySeat()
        {
            List<int> ids = new List<int>();
            foreach (BoardingPass pass in passes)
            {
                ids.Add(pass.id);
            }
            ids.Sort();
            int lastid = ids[0];
            for (int i = 1; i < ids.Count; i++)
            {
                int id = ids[i];
                if (id - lastid > 1) { return lastid+1; }
                lastid = id;
                
            }
            return 0;
        }
    }
}
