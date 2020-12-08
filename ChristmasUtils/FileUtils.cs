using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ChristmasUtils
{
    public class FileUtils
    {
        public static string CreateTempFileFromList(IEnumerable input)
        {
            Guid gUID = Guid.NewGuid();

            string testInputFilePath = Path.GetTempPath() + gUID + ".temp";
            StreamWriter sw = new StreamWriter(testInputFilePath);
            foreach (string val in input)
            { sw.WriteLine(val); }
            sw.Close();
            return testInputFilePath;

               }

        

        static public List<string> Read(string testInputFilePath)
        {
            StreamReader sr = new StreamReader(testInputFilePath);
            List<string> values = new List<string>();
            while (sr.Peek() != -1)
            {
                values.Add(sr.ReadLine());

            }
            return values;


        }

        static public List<string> BufferRead(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> values = new List<string>();
            string buffer;
            buffer = "";
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                if (line.Equals(""))
                {
                    values.Add(buffer.Trim());
                    buffer = "";
                }
                else
                {
                    buffer = buffer + " " + line;
                }

            }
            values.Add(buffer.Trim());
            sr.Close();
            return values;
        }
    }
}
