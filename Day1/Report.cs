using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day1
{
    public class Report
    {
        List<int> values = new List<int>();
        private string testInputFilePath;

        public Report(string testInputFilePath)
        {
            this.testInputFilePath = testInputFilePath;
            this.values = Read(testInputFilePath);
        }

        public int Compute()
        {
            foreach (int value in values)
            {
                int match = FindComplement(value);
                if (match != -1)
                { return value * match; }
                    
                    
            }
            return 0;

        }

        private  List<int> Read(string testInputFilePath)
        {
            StreamReader sr = new StreamReader(testInputFilePath);
            List<int> values = new List<int>();
            while (sr.Peek() != -1)
            {
                values.Add(Int32.Parse(sr.ReadLine()));
            }
            return values;

        }

        private int FindComplement(int match)
        {
            foreach (int val in values)
            {
                if( match + val == 2020)
                {
                    return val;
                }
            }

            return -1;
                }


    }
}
