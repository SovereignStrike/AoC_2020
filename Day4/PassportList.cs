using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ChristmasUtils;

namespace Day4
{
    public class PassportList
    {
        private List<Passport> passports;
        public PassportList(string inputpath)
        {
            passports = new List<Passport>();
            foreach (string input in Read(inputpath))
             {
                passports.Add(new Passport(input));
            }
            
        }

        public int ValidPasswordsCount(string[] requiredFields)
        {
            int count = 0;

            foreach (Passport passport in passports)
            {
                if (passport.IsValid(requiredFields))
                { count++; }
            }
            return count;
        }

        public List<string> Read(string path)
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
