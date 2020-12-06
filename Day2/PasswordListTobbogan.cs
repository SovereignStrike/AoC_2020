using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day2
{
    public class PasswordListTobbogan
    {
        public List<PasswordRecordTobboggan> records { get; set; }

        public PasswordListTobbogan(string inputFilePath)
        {
            List<string> passwords = Read(inputFilePath);
            records = new List<PasswordRecordTobboggan>();
            foreach (string pass in passwords)
            {
                records.Add(new PasswordRecordTobboggan(pass));
            }
        }

        protected List<string> Read(string testInputFilePath)
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
            foreach (PasswordRecordTobboggan record in records)
            {
                if (record.IsValid())
                { i++; }
            }
            return i;
        }


    }
}

