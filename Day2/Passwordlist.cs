using System;
using System.Collections.Generic;
using System.IO;
namespace Day2
{
    public class PasswordList
    {
        public List<PasswordRecord> records { get; }
        public PasswordList(string inputFilePath)
        {
            List<string> passwords = Read(inputFilePath);
            records = new List<PasswordRecord>();
            foreach (string pass in passwords)
            {
                records.Add(new PasswordRecord(pass));
            }
        }

        private List<string> Read(string testInputFilePath)
        {
            StreamReader sr = new StreamReader(testInputFilePath);
            List<string> values = new List<string>();
            while (sr.Peek() != -1)
            {
                values.Add(sr.ReadLine());

            }
            return values;


        }

        public int ValidPasswordsCount()
        {
            int i = 0;
            foreach (PasswordRecord record in records)
            {
                if (record.IsValid())
                { i++; }
            }
            return i;
        }


    }
}